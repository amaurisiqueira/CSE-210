using System;
using System.IO;
//using Newtonsoft.Json;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace W03
{
    public class ActionSave : ActionInterface
    {
        private void SaveFile(string myFile, List<TypeUserData> data)
        {
            using (StreamWriter w = new StreamWriter(myFile))
            {
                string jsonString = JsonConvert.SerializeObject(data);
                w.Write(jsonString);

            }
        }//end SaveFile

        public int Action(ref MngJornal jornal)
        {
            if (!jornal.NeedToSave())
            {
                Console.WriteLine("Nothing to save!!!");
                return 1;
            }
            string _filename = "";
            while (_filename.Length < 2)
            {
                Console.Write("Enter a file name;");
                _filename = Console.ReadLine().Trim();
                if (_filename.Length < 1) Console.WriteLine("Please enter a valid file name. Thank you!");

            }
            SaveFile(_filename, jornal.Get());
            jornal.Reset_total();
            Console.WriteLine("");
            return 1;

        }//------------------------------

    }
}
