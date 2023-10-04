using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace Develop04
{
    public class Journal
    {
        private List<Entry> _entry = null;
        public Journal()
        {
            _entry = new List<Entry>(); 


        }

        public void Write()
        {

            PromptGenerator _generator = new PromptGenerator();

            string _myPrompt = _generator.GetPrompt(); 
            Console.WriteLine($"{_myPrompt}");
            string _myMessage = "";
            while (_myMessage.Length < 1)
            {
                _myMessage = Console.ReadLine().Trim();
                if (_myMessage.Length < 1) Console.WriteLine("Please enter a valid message. Thank you!");

            }
            Entry _new = new Entry();
            string strDate = DateTime.Now.ToString("MM/dd/yyyy");
          

            _new.Message = _myMessage;
            _new.Prompt  = _myPrompt;
            _new.Date = strDate;
;           _entry.Add(_new);

        }

        public void Display()
        {

            if (_entry.Count < 1)
            {
                Console.WriteLine("The journal is empty. Please write a journal entry.");
                return;
            }

            foreach (Entry mydata in _entry)
            {
                Console.WriteLine($"Date:{mydata.Date} -- Prompt:{mydata.Prompt}\n{mydata.Message}");

            }

        }//end  void ShowData()



        private void SaveFile(string myFile, List<Entry> data)
        {
            using (StreamWriter w = new StreamWriter(myFile))
            {
                string jsonString = JsonConvert.SerializeObject(data);
                w.Write(jsonString);

            }
        }//end SaveFile

        private System.Collections.Generic.List<Entry> LoadFile(string myFile)
        {
            System.Collections.Generic.List<Entry> data = new System.Collections.Generic.List<Entry>();

            if (File.Exists(myFile))
            {
                using (StreamReader r = new StreamReader(myFile))
                {
                    string json = r.ReadToEnd();
                    data = JsonConvert.DeserializeObject<List<Entry>>(json);
                }
            }
            return data;
        }//end LoadFile


        public void Load( )
        {
            string filename = "";
            while (filename.Length < 2)
            {
                Console.Write("Enter a file name;");
                filename = Console.ReadLine().Trim();
                if (filename.Length < 1) Console.WriteLine("Please enter a valid file name. Thank you!");

            }
            _entry = LoadFile(filename);
             
            Console.WriteLine(" ");
            return  ;
        }//----------------------------------------



        public void Save( )
        {
            if (_entry.Count<1)
            {
                Console.WriteLine("Nothing to save!!!");
                return  ;
            }
            string _filename = "";
            while (_filename.Length < 2)
            {
                Console.Write("Enter a file name;");
                _filename = Console.ReadLine().Trim();
                if (_filename.Length < 1) Console.WriteLine("Please enter a valid file name. Thank you!");

            }
            SaveFile(_filename, _entry);
            Console.WriteLine("");
            return ;

        }//------------------------------

    }
}
