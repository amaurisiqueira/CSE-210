using System;
namespace W03
{
    public struct TypeUserData
    {
        private string _date;
        private string _prompt;
        private string _message;
        public string Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
        public string Prompt
        {
            get { return _prompt; }
            set { _prompt = value; }

        }
        public string Message
        {

            get { return _message; }

            set { _message = value; }

        }


    }
}
