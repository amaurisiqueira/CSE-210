using System;
using System.Collections.Generic;

namespace W03
{
    public class MngJornal
    {
        int _start_total;
        List<TypeUserData> myData = null;
        public MngJornal()
        {
            _start_total = 0;
            myData = new List<TypeUserData>();
        }//end constructor

        public void Set(List<TypeUserData> data)
        {
            myData.Clear();
            foreach (TypeUserData aa in data)
            {
                myData.Add(aa);
            }
            _start_total = data.Count;

        }//

        public List<TypeUserData> Get()
        {
            return myData;
        }
        public void Reset_total()
        {
            _start_total = myData.Count;
        }
        public void Add(string prompt, string message)
        {
            string strDate = DateTime.Now.ToString("MM/dd/yyyy");
            TypeUserData NewRecord = new TypeUserData();
            NewRecord.Date = strDate;
            NewRecord.Prompt = prompt;
            NewRecord.Message = message;
            myData.Add(NewRecord);

        }//en of add

        public void ShowData()
        {

            if (myData.Count < 1)
            {
                Console.WriteLine("The journal is empty. Please write a journal entry.");
                return;
            }

            foreach (TypeUserData mydata in myData)
            {
                Console.WriteLine($"Date:{mydata.Date} -- Prompt:{mydata.Prompt}\n{mydata.Message}");

            }

        }//end  void ShowData()

        public bool NeedToSave()
        {
            if (myData == null) return false;
            return _start_total != myData.Count;
        }//end need to save

    }
}
