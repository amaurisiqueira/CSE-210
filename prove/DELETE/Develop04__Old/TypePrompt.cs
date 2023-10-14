using System;
namespace W03
{
    public struct TypePrompt
    {
        private string _id;
        private string _description;
        public string Id
        {
            set
            {
                _id = value;
            }
            get
            {
                return _id;
            }
        }//end ID

        public string Description
        {
            set
            {
                _description = value;
            }
            get
            {
                return _description;
            }
        }
    }
}
