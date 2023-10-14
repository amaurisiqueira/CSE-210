using System;
namespace W03
{
    public class ActionDisplay : ActionInterface
    {
        public int Action(ref MngJornal jornal)
        {

            jornal.ShowData();
            return 1;

        }
    }
}
