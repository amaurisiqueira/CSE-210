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



    static private void ListMainMenu(List<string> mydata, string text)
    {
        Console.WriteLine(text);
        //Console.WriteLine("");
        int n = 0;
        foreach (string mymenu in mydata)
        {
            Console.WriteLine($"{++n}. {mymenu}");

        }
    }
    static private string ReadText(string caption)
    {
        while (true)
        {
            Console.Write(caption + " ");
            string tmp = "";
            try
            {
                tmp = Console.ReadLine().Trim();

            }
            catch (Exception e)
            {
                Console.WriteLine($"Invalid format !!!{e.ToString()}");
            }

            tmp = tmp.Trim();

            if (tmp.Length == 0) continue;
            return tmp;
        }
    }
    static private int ReadInt(string caption)
    {
        while (true)
        {
            Console.Write(caption + " ");
            string tmp = "";
            try
            {
                tmp = Console.ReadLine().Trim();

            }
            catch (Exception e)
            {
                Console.WriteLine($"Invalid format !!!{e.ToString()}");
            }

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
            if (myoption < 1)
            {
                Console.WriteLine("Please, type a valid number!!!!!!");
                continue;
            }
            return myoption;
        }
    }
    static private int choice(List<string> mydata, string text)
    {
        while (true)
        {
            Console.Write(text);
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

            Console.WriteLine($"\nYou have {GlobalGoals.GetTotalScore()} points\n");

            ListMainMenu(_myMenu, "Menu Options:");
            switch (choice(_myMenu, "Select a choice from the menu:"))
            {
                case 0:
                    {
                        // GlobalGoals.Write();
                        List<string> _mySubMenu = new List<string>
                        {
                        "Simple Goal" ,
                        "Eternal Goal",
                        "CheckList Goal",
                        "Negative Goals",

                        };
                        ListMainMenu(_mySubMenu, "The types of Goals are:");
                        switch (choice(_mySubMenu, "Which type of goal yould you like to create?"))
                        {
                            case 0:
                                {
                                    string name = ReadText("What is the name of your goal?");
                                    string description = ReadText("What is a short description of if?");
                                    int amount = ReadInt("What is the amount of points associated with this goal?");

                                    SimpleGoal nn = new(name, description, amount);
                                    GlobalGoals.NewGoal(nn);

                                    break;
                                }
                            case 1:
                                {
                                    string name = ReadText("What is the name of your goal?");
                                    string description = ReadText("What is a short description of if?");
                                    int amount = ReadInt("What is the amount of points associated with this goal?");

                                    EternalGoal nn = new(name, description, amount);
                                    GlobalGoals.NewGoal(nn);

                                    break;
                                }
                            case 2:
                                {
                                    string name = ReadText("What is the name of your goal?");
                                    string description = ReadText("What is a short description of if?");
                                    int amount = ReadInt("What is the amount of points associated with this goal?");
                                    int times = ReadInt("How many times does this goal need to be accomplished for a bonus?");
                                    int bonus = ReadInt("What is the bonus for accomplishing it that many times?");
                                    CheckListGoal nn = new(name, description, amount, times, bonus, 0);
                                    GlobalGoals.NewGoal(nn);
                                    break;
                                }
                            case 3:
                                {
                                    string name = ReadText("What is the name of your negative goal?");
                                    string description = ReadText("What is a short description of if?");
                                    int amount = ReadInt("What is the amount of points associated with this goal?");
                                    NegativeGoals nn = new(name, description, amount);
                                    GlobalGoals.NewGoal(nn);
                                    break;
                                }
                        }
                        break;
                    }
                case 1:
                    {

                        GlobalGoals.Display();
                        break;
                    }
                case 2:
                    {
                        string name = ReadText("What the name of file to salve?");
                        GlobalGoals.SalveToFile(name);
                        break;
                    }
                case 3:
                    {
                        string name = ReadText("What the name of file to load?");
                        GlobalGoals.LoadFromFile(name);
                        break;
                    }
                case 4:
                    {
                        GlobalGoals.Display();
                        List<string> parameter = GlobalGoals.GetList();
                        if (parameter.Count != 0)
                        {
                            int position = choice(parameter, "Which goal did you Acomplish?");
                            GlobalGoals.RecordEvent(position);

                        }
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