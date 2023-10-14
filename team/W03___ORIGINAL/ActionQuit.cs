using System;
namespace W03
{
    public class ActionQuit : ActionInterface
    {
        public int Action(ref MngJornal jornal)
        {
            if (jornal.NeedToSave())
            {
                Console.WriteLine("You need to save the journal and then exit!");
                return 1;
            };
            Console.WriteLine("Bye");
            return 0;

        }
    }
}
