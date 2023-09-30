using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace W03
{
    public class ActionLoad : ActionInterface
    {
        private System.Collections.Generic.List<TypeUserData> LoadFile(string myFile)
        {
            System.Collections.Generic.List<TypeUserData> data = new System.Collections.Generic.List<TypeUserData>();

            if (File.Exists(myFile))
            {
                using (StreamReader r = new StreamReader(myFile))
                {
                    string json = r.ReadToEnd();
                    data = JsonConvert.DeserializeObject<List<TypeUserData>>(json);
                }
            }
            return data;
        }//end LoadFile


        public int Action(ref MngJornal jornal)
        {
            string filename = "";
            while (filename.Length < 2)
            {
                Console.Write("Enter a file name;");
                filename = Console.ReadLine().Trim();
                if (filename.Length < 1) Console.WriteLine("Please enter a valid file name. Thank you!");

            }
            jornal.Set(LoadFile(filename));
            // LoadFile(string myFile)
            Console.WriteLine(" ");
            return 1;
        }//----------------------------------------

    }
}
