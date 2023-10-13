using System;
namespace Develop02
{
    public class PromptGenerator
    {

        private System.Collections.Generic.List<string> _myList ;


        public PromptGenerator()
        {
            _myList = new System.Collections.Generic.List<string>();

            _myList.Add("Who was the most interesting person I interacted with today?");
            _myList.Add("What was the best part of my day?");
            _myList.Add("How did I see the hand of the Lord in my life today?");
            _myList.Add("What was the strongest emotion I felt today?");
            _myList.Add("If I had one thing I could do over today, what would it be?");

        }

        public string GetPrompt()
        {
            Random rnd = new Random();
            return _myList[ (rnd.Next(1, _myList.Count)-1)];
        }

    }
}
