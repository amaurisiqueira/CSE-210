using System;

class Program
{

    static List<Activity> _allActivities = new List<Activity>();
    static void CallRunning()
    {
        DateOnly date = new(2023, 11, 28);
        Rumning run = new("Rumning", date, 49  , 12.34);
        _allActivities.Add(run);
    }
    static void CallCycling()
    {
        DateOnly date = new(2023, 11, 29);
        Cycling cycling = new("Cycling", date, 90,  22);
        _allActivities.Add(cycling);
    }
    static void CallSwimming()
    {
        DateOnly date = new(2023, 11, 30);
        Swimming cycling = new("Swimming", date, 83, 30);
        _allActivities.Add(cycling);
    }

    static void ListAllActivities()
    {
        foreach (Activity a in _allActivities)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"{a.GetSummary()}");
        }
    }

    static void Main(string[] args)
    {
        CallRunning();
        CallCycling();
        CallSwimming();
        //List
        ListAllActivities();
    }
}