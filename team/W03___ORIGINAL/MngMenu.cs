using System;
using System.Collections.Generic;

namespace W03
{

    public struct MenuType
    {
        public int id;
        public string descripcion;
    };

    public class MngMenu
    {
        MngJornal jornal = null;
        private const int MAXMENU = 5;
        private const string WELCOME = "Welcome to de Journal Program!";

        ActionInterface[] Actions = new ActionInterface[]
        {
            new ActionWrite(),
            new ActionDisplay(),
            new ActionLoad(),
            new ActionSave(),
            new ActionQuit()
        };
        bool live = true;
        private int choice()
        {
            while (true)
            {
                Console.Write("What would you like to do?");
                string tmp = "";
                try
                {
                    tmp = Console.ReadLine().Trim();

                }
                catch (Exception e)
                {
                    Console.WriteLine($"Invalid format !!!{e.ToString() }");
                }


                tmp = tmp.Replace('\0', ' ');
                tmp = tmp.Trim();
                if (tmp.Length < 1 || tmp == "\0") tmp = "0";
                int myoption = Convert.ToInt16(tmp);
                bool found = false;
                foreach (MenuType m in myMenu)
                {
                    if (m.id == myoption)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Please, type a valid number!!!!!!");
                    continue;
                }
                return myoption;

            }//-------------------------------------------


        }//---- end of choice

        public bool doWhile()
        {
            while (live)
            {
                ListMainMenu();
                live = Actions[choice() - 1].Action(ref jornal) > 0;
            }
            return false;
        }

        private void ListMainMenu()
        {
            Console.WriteLine(WELCOME);
            Console.WriteLine("");
            foreach (MenuType mymenu in myMenu)
            {
                Console.WriteLine($"{mymenu.id}) {mymenu.descripcion}");
            }
        }
        private void LoadMenu(int myId, string myDescripcion)
        {
            MenuType var = new MenuType();
            var.id = myId;
            var.descripcion = myDescripcion;
            myMenu.Add(var);
        }//end load menu

        List<MenuType> myMenu = null;
        public MngMenu()
        {
            Console.Clear();
            jornal = new MngJornal();
            myMenu = new List<MenuType>();
            LoadMenu(1, "Write");
            LoadMenu(2, "Display");
            LoadMenu(3, "Load");
            LoadMenu(4, "Save");
            LoadMenu(5, "Quit");

        }


    }
}
