using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace W03
{
    public class mngPrompt
    {
        private  List<typePrompt> loadFile(string myFile)
        {
            using (StreamReader r = new StreamReader(myFile))
            {
                string json = r.ReadToEnd();
                List<typePrompt> Properties = JsonConvert.DeserializeObject<List<typePrompt>>(json);
                return Properties;
            }
        }

        List<typePrompt> myList = null;
        // new List<typePrompt>();
        public mngPrompt()
        {
            myList = loadFile("properties.json");

        }


        public typePrompt  getPropertiesById(string id)
        {
            typePrompt myReturn= new typePrompt();
             foreach ( typePrompt a in myList)
            {
                if((a.id == id) )
                {
                    myReturn.id = a.id;
                    myReturn.description = a.description;
                    break;
                }

            }
            return myReturn;
        }


    }
}
