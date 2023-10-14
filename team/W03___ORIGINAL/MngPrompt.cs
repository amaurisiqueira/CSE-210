using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace W03
{
    public class MngPrompt
    {
        private List<TypePrompt> _myList = null;

        private List<TypePrompt> LoadFile(string myFile)
        {
            using (StreamReader r = new StreamReader(myFile))
            {
                string json = r.ReadToEnd();
                List<TypePrompt> Properties = JsonConvert.DeserializeObject<List<TypePrompt>>(json);
                return Properties;
            }
        }
        // new List<TypePrompt>();
        public MngPrompt()
        {
            _myList = LoadFile("properties.json");

        }

        public int GetCount()
        {
            return _myList.Count;
        }

        public TypePrompt getPropertiesById(string id)
        {
            TypePrompt myReturn = new TypePrompt();
            foreach (TypePrompt a in _myList)
            {
                if ((a.Id == id))
                {
                    myReturn.Id = a.Id;
                    myReturn.Description = a.Description;
                    break;
                }
            }
            return myReturn;
        }
    }
}
