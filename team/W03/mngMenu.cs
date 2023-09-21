using System;
using System.Collections.Generic;

namespace W03
{
   


    public struct menu
    {
        public int id;
        public string descripcion;
    };

    public class mngMenu
    {
        private const string WELCOME = "Welcome to de Journal Program!";

        bool live = true;
        public bool doWhile()
        {
            return live;
        }

        public void listMainMenu()
        {
            Console.Clear();
            Console.WriteLine(WELCOME);
            Console.WriteLine("");
            foreach (menu mymenu in myMenu)
            {
                Console.WriteLine($"{mymenu.id}) {mymenu.descripcion}");
            }

        }
        private void loadMenu( int myId , string myDescripcion)
        {
            menu var = new menu();
            var.id = myId;
            var.descripcion = myDescripcion;
            myMenu.Add(var);
        }//end load menu


        List<menu> myMenu = null;
        public mngMenu()
        {
            myMenu = new List<menu>(); 
            loadMenu(1, "Write");
            loadMenu(2, "Display");
            loadMenu(3, "Load");
            loadMenu(4, "Save");
            loadMenu(5, "Quit");

        }


    }
}
