using System;

namespace W03
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MngMenu _mymenu = new MngMenu();
            MngPrompt _mngPrompt = new MngPrompt();
            while (_mymenu.doWhile())
            {
            }
            Console.WriteLine("End of program!!!");
        }
    }
}
