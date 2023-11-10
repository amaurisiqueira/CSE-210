using System;
class Program
{
    static List<string> _myMenu = new List<string>
            {
                "Create New Goal",
                "List Goals",
                "Save Goals",
                "Load Goals",
                "Record Event",
                "Quit"
            };
    static GlobalInformation GlobalGoals = new GlobalInformation();

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
            Console.Write("Select a choice from the menu?");
            string tmp = "";
            try
            {
                tmp = Console.ReadLine().Trim();

            }
            catch (Exception e)
            {
                Console.WriteLine($"Invalid format !!!{e.ToString()}");
            }
            tmp = tmp.Replace('\0', ' ');
            tmp = tmp.Trim();
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
    public static void Main(string[] args)
    {
        Console.Clear();
        bool live = true;
        while (live)
        {
            ListMainMenu();
            switch (choice())
            {
                case 0:
                    {
                        // GlobalGoals.Write();
                        break;
                    }
                case 1:
                    {
                        // GlobalGoals.Display();
                        break;
                    }
                case 2:
                    {
                        // GlobalGoals.Load();
                        break;
                    }
                case 3:
                    {
                        // GlobalGoals.Save();
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                case 5:
                    {
                        live = false;
                        break;
                    }
            }
        }
        Console.WriteLine("\n\nBYE !!!!!!");
    }
}