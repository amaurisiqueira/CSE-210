using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Develop02
{
    public class Journal
    {
        private List<Entry> entries = new List<Entry>(); 
        PromptGenerator generator = new PromptGenerator();
        public void Write()
        {
            string myPrompt = generator.GetPrompt(); 
            Console.WriteLine($"{myPrompt}");
            string myMessage = "";
            while (myMessage.Length==0)
            {
                myMessage = Console.ReadLine().Trim();
                if (myMessage.Length==0) Console.WriteLine("Please enter a valid message. Thank you!");
            }
            Entry entry = new Entry();
            string strDate = DateTime.Now.ToString("MM/dd/yyyy");
            entry.Message = myMessage;
            entry.Prompt  = myPrompt;
            entry.Date = strDate;
            entries.Add(entry);
        }
        public void Display()
        {
            if (entries.Count==0)
            {
                Console.WriteLine("The journal is empty. Please write a journal entry.");
                return;
            }
            foreach (Entry mydata in entries)
            {
                Console.WriteLine($"Date:{mydata.Date} -- Prompt:{mydata.Prompt}\n{mydata.Message}");
            }
        }
        private void SaveFile(string myFile, List<Entry> data)
        {
            using (StreamWriter w = new StreamWriter(myFile))
            {
                string jsonString = JsonConvert.SerializeObject(data);
                w.Write(jsonString);
            }
        } 
        private List<Entry> LoadFile(string myFile)
        {
            List<Entry> data = new List<Entry>();
            if (File.Exists(myFile))
            {
                using (StreamReader r = new StreamReader(myFile))
                {
                    string json = r.ReadToEnd();
                    data = JsonConvert.DeserializeObject<List<Entry>>(json);
                }
            }
            return data;
        } 
        public void Load( )
        {
            string filename = "";
            while (filename.Length==0)
            {
                Console.Write("Enter a file name;");
                filename = Console.ReadLine().Trim();
                if (filename.Length==0) Console.WriteLine("Please enter a valid file name. Thank you!");
            }
            entries = LoadFile(filename);
            Console.WriteLine(" ");
            return  ;
        } 
        public void Save( )
        {
            if (entries.Count==0)
            {
                Console.WriteLine("Nothing to save!!!");
                return  ;
            }
            string _filename = "";
            while (_filename.Length==0)
            {
                Console.Write("Enter a file name;");
                _filename = Console.ReadLine().Trim();
                if (_filename.Length==0) Console.WriteLine("Please enter a valid file name. Thank you!");
            }
            SaveFile(_filename, entries);
            Console.WriteLine("");
            return ;
        } 
    }
}
