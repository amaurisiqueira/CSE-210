using System;
class Program
{
    static List<string> _myMenu = new List<string>
            {
               "Create New Goal" ,
                "List Goals",
                "Save Goals",
                "Load Goals",
                "Record Event",
                "Quit"
            };
    static GlobalInformation GlobalGoals = new GlobalInformation();

    private const string WELCOME = "Welcome to the Journal Program!";

    static private void ListMainMenu(List<string> mydata)
    {
        Console.WriteLine(WELCOME);
        Console.WriteLine("");
        int n = 0;
        foreach (string mymenu in mydata)
        {
            Console.WriteLine($"{++n}) {mymenu}");

        }
    }
    static private int choice(List<string> mydata)
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
            if (myoption < 1 || myoption > mydata.Count)
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
            ListMainMenu(_myMenu);
            switch (choice(_myMenu))
            {
                case 0:
                    {
                        // GlobalGoals.Write();
                        List<string> _mySubMenu = new List<string>
                        {
                        "Simple Goal" ,
                        "Ethernal Goal",
                        "Check List Goal",
                        };
                        ListMainMenu(_mySubMenu);
                        switch (choice(_mySubMenu))
                        {
                            case 0:
                                break;
                            case 1:
                                break;
                            case 2:
                                break;
                        }
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