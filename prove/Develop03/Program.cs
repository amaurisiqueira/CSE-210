using System;
using Newtonsoft.Json;

namespace Develop03
{
    public struct tmp_data
    {
        public string _book;
        public int _chapter;
        public int _verse_start;
        public int _verse_end;
        public string _content;
        public tmp_data(string book, int chapter, int verse_start, int verse_end, string content)
        {
            _book = book;
            _chapter = chapter;
            _verse_start = verse_start;
            _verse_end = verse_end;
            _content = content;
        }

        public readonly string GetBook() { return _book; }
        public readonly int GetChapter() { return _chapter; }
        public readonly int GetVerse_start() { return _verse_start; }
        public readonly int GetVerse_end() { return _verse_end; }
        public readonly string GetContent() { return _content; }
    };

    class Develop03
    {

        public static void Main(string[] args)
        {
            Random rnd = new();
            int dificult_level = 3;
            List<tmp_data> myCollection = LoadFile("scripts.json");

            if (myCollection.Count==0)
            {
                Console.WriteLine("No have scripts to show!");
                return;
            }

            tmp_data myOption = myCollection[rnd.Next(1, myCollection.Count) - 1];
            // Console.WriteLine(myOption.book);
            Scripture myscript;
            if (myOption.GetVerse_start() == myOption.GetVerse_end())
            {
                myscript = new Scripture(myOption.GetBook(), myOption.GetChapter(), myOption.GetVerse_start(), myOption.GetContent());
            }
            else
            {
                myscript = new Scripture(myOption.GetBook(), myOption.GetChapter(), myOption.GetVerse_start(), myOption.GetVerse_end(), myOption.GetContent());
            }
            while (true)
            {
                Console.Clear();
                myscript.PrintTexts();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                string myMessage = Console.ReadLine().Trim().ToLower();
                if (myMessage == "quit") break;
                if (!myscript.IsWorking()) break;
                for (int dificult = 0; dificult < dificult_level; dificult++) myscript.HideRandomly();
            }
        }


        private static List<tmp_data> LoadFile(string myFile)
        {
            List<tmp_data> data = new List<tmp_data>();
            if (File.Exists(myFile))
            {
                using (StreamReader r = new StreamReader(myFile))
                {
                    string json = r.ReadToEnd();
                    Console.WriteLine(json);
                    data = JsonConvert.DeserializeObject<List<tmp_data>>(json);
                }
            }
            return data;
        }
    }
}