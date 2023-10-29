using System;

class Develo04
{

    static List<string> _myMenu = new List<string>
            {
                "Start breathing activity",
                "Start reflecting activity",
                "Start listing activity",
                "Show log register",
                "Quit"
            };
    private const string WELCOME = "Menu Options:";
    static private void ListMainMenu()
    {
        Console.WriteLine(WELCOME);
        Console.WriteLine("");
        int n = 0;
        foreach (string mymenu in _myMenu)
        {
            Console.WriteLine($"{++n}. {mymenu}");

        }
    }
    static private int choice()
    {
        while (true)
        {
            Console.Write("Select a choice from the menu:");
            string tmp = "";
            try
            {
                tmp = Console.ReadLine().Trim();

            }
            catch (Exception e)
            {
                Console.WriteLine($"Invalid format !!!{e.ToString()}");
            }


            int myoption = 0;
            try
            {
                myoption = Convert.ToInt16(tmp);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Please, type a valid number!!!!!!\nError:{e.Message}");
                continue;
            }
            if (myoption < 1 || myoption > _myMenu.Count)
            {
                Console.WriteLine("Please, type a valid number!!!!!!");
                continue;
            }
            return myoption - 1;
        }
    }
    static void Main(string[] args)
    {

        // Log register = new Log("mylog.dat");
        /*register.WriteLogActivity("Start activity");
        Thread.Sleep(1000);
        register.WriteLogActivity("Another activity");
         Console.WriteLine("Hello Develop04.2 World!"); */
        // register.ListLogActivity();

        //Activity unitActivity = new ("breathing.json") ;
        // Activity unitActivity = new ("reflecting.json") ;

        bool live = true;
        while (live)
        {
            Console.Clear();
            ListMainMenu();
            switch (choice())
            {
                case 0:
                    {
                        BreathingActivity breathing = new("breathing.json");
                        breathing.Play();
                        break;
                    }
                case 1:
                    {
                        ReflectingActivity reflecting = new("reflecting.json");
                        reflecting.Play();
                        break;
                    }
                case 2:
                    {
                        ListingActivity listing = new("listing.json");
                        listing.Play();
                        break;
                    }
                case 3:
                    {
                        PrintLog myPrint = new("listing.json");
                        myPrint.Play();
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