using System;

namespace Develop02
{
    class Program
    {
      static   List<string> _myMenu = new List<string>
            {
                "Write",
                "Display",
                "Load",
                "Save",
                "Quit"
            };

        static Journal _jornal = new Journal() ;
        private const int MAXMENU = 5;
        private const string WELCOME = "Welcome to the Journal Program!";

        static private void ListMainMenu()
        {
            Console.WriteLine(WELCOME);
            Console.WriteLine("");
            int n = 0;
            foreach (string mymenu in _myMenu)
            {
                Console.WriteLine($"{++n}) {mymenu}");

            }
        } 

        static private int choice()
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
                if (tmp.Length==0 || tmp == "\0") tmp = "0";

                int myoption =0;
                try
                {
                    myoption =Convert.ToInt16(tmp);   
                }catch ( Exception e)
                {                    
                    Console.WriteLine($"Please, type a valid number!!!!!!\nError:{e.Message}");
                    continue;
                }
                 
              
             
                if (myoption<1 || myoption > _myMenu.Count)
                {
                    Console.WriteLine("Please, type a valid number!!!!!!");
                    continue;
                }

                return myoption-1;

            } 

        } 
        

        public static void Main(string[] args)
        {

            Console.Clear(); 
             bool live = true;
             while (live)
            {
                ListMainMenu();
                switch (choice()) {
                    case 0:
                        {
                            _jornal.Write();
                            break;
                        }
                    case 1:
                        {
                            _jornal.Display();
                            break;
                        }
                    case 2:
                        {
                            _jornal.Load();
                            break;
                        }
                    case 3:
                        {
                            _jornal.Save();
                            break;
                        }
                    case 4:
                        {
                            live = false;
                            break;
                        }

                }


            }

            Console.WriteLine("\n\nBYE !!!!!!");

        }
    }
}
