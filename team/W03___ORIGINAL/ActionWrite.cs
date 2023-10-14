using System;
namespace W03
{
    public class ActionWrite : ActionInterface
    {
        MngPrompt _prompt = null;
        public ActionWrite()
        {
            _prompt = new MngPrompt();
        }

        public int Action(ref MngJornal jornal)
        {

            Random rnd = new Random(); 
            string _myPromptID = Convert.ToString(rnd.Next(1, _prompt.GetCount()));
            string _myPrompt = _prompt.getPropertiesById(_myPromptID).Description;
            Console.WriteLine($"{_myPrompt}");
            string _myMessage = "";
            while (_myMessage.Length < 1)
            {
                _myMessage = Console.ReadLine().Trim();
                if (_myMessage.Length < 1) Console.WriteLine("Please enter a valid message. Thank you!");

            } 
            jornal.Add(_myPrompt, _myMessage); 
            return 1;
        }
    }
}
