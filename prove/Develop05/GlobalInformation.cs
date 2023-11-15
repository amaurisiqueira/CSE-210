

public class GlobalInformation
{
    private int _totalscore;
    private readonly List<Goal> _allgoals = new();

    public GlobalInformation()
    {
        _totalscore = 0;
    }
    public List<string> GetList(bool onlyuncompleted = false)
    {
        List<String> listTmp = new();
        foreach (Goal p in _allgoals)
        {
            if (onlyuncompleted && p.IsComplete())
            {
                continue;
            }
            listTmp.Add(p.GetStringToFormated());
        }
        return listTmp;
    }
    public void NewGoal(SimpleGoal mygoal)
    {
        _allgoals.Add(mygoal);
    }
    public void NewGoal(EternalGoal mygoal)
    {
        _allgoals.Add(mygoal);
    }
    public void NewGoal(CheckListGoal mygoal)
    {
        _allgoals.Add(mygoal);
    }
    public void NewGoal(NegativeGoals mygoal)
    {
        _allgoals.Add(mygoal);
    }

    public int RecordEvent(int recno)
    {
        if (recno < 0 || recno >= _allgoals.Count) return 0;
        int tmpvalue = _allgoals[recno].RecordEvent();
        _totalscore += tmpvalue;
        return tmpvalue;
    }
    public int GetTotalScore()
    {
        return _totalscore;
    }
    public void Display(bool onlyuncompleted = false)
    {

        if (_allgoals.Count == 0)
        {
            Console.WriteLine("Don't have any goals to show!!!");
            return;
        }

        int times = 0;
        Console.WriteLine("The goals are:");
        foreach (Goal g in _allgoals)
        {
            if (onlyuncompleted && g.IsComplete())
            {
                continue;
            }
            Console.WriteLine($"{++times}. {g.GetStringToShow()}");
        }
    }

    public void SalveToFile(string filename)
    {
        List<string> data = new List<string>();
        data.Add(_totalscore.ToString());
        foreach (Goal g in _allgoals)
        {
            data.Add(g.GetStringToFormated());
        }
        // string jsonString = JsonConvert.SerializeObject(data);
        // File.WriteAllText(filename, jsonString);
        File.WriteAllLines(filename, data);
    }

    public void LoadFromFile(string filename)
    {

        _allgoals.Clear();
        //List<string> data = new List<string>();
        if (File.Exists(filename))
        {

            string[] data = File.ReadAllLines(filename);



            if (data.Length > 1)
            {

                bool resultado = int.TryParse(data[0], out _totalscore);
                int goaltype;
                for (int myrow = 1; myrow < data.Length; myrow++)
                {
                    string[] parts = data[myrow].Split("|");
                    resultado = int.TryParse(parts[0], out goaltype);
                    switch (goaltype)
                    {
                        case 1:
                            {


                                //s/tring[] parts = parameter.Split("|");
                                bool tmp_complete = false;
                                int tmp_amount;
                                if (parts[1] == "1") tmp_complete = true; ;//int _int_ended = 0;
                                string tmp_name = parts[2];//_name
                                string tmp_description = parts[3];//_description
                                resultado = int.TryParse(parts[4], out tmp_amount); //_amount
                                SimpleGoal mygoal = new(tmp_name, tmp_description, tmp_amount, tmp_complete);

                                NewGoal(mygoal);
                                break;
                            }
                        case 2:
                            {
                                int tmp_amount;
                                string tmp_name = parts[2];//_name
                                string tmp_description = parts[3];//_description
                                resultado = int.TryParse(parts[4], out tmp_amount); //_amount
                                EternalGoal mygoal = new(tmp_name, tmp_description, tmp_amount);
                                NewGoal(mygoal);
                                break;
                            }
                        case 3:
                            {
                                int tmp_amount;
                                int tmp_current_iteration;
                                int tmp_totaliteraction;
                                int tmp_bonus;
                                string tmp_name = parts[2];//_name
                                string tmp_description = parts[3];//_description
                                resultado = int.TryParse(parts[4], out tmp_amount); //_amount
                                resultado = int.TryParse(parts[5], out tmp_current_iteration);// 5  _current_iteration
                                resultado = int.TryParse(parts[6], out tmp_totaliteraction);// 6 _totaliteraction
                                resultado = int.TryParse(parts[7], out tmp_bonus);// 7 _bonus
                                CheckListGoal mygoal = new(tmp_name, tmp_description, tmp_amount, tmp_totaliteraction, tmp_bonus, tmp_current_iteration);

                                NewGoal(mygoal);
                                break;
                            }
                        case 4:
                            {


                                int tmp_amount;
                                string tmp_name = parts[2];//_name
                                string tmp_description = parts[3];//_description
                                resultado = int.TryParse(parts[4], out tmp_amount); //_amount
                                NegativeGoals mynegativegoal = new(tmp_name, tmp_description, tmp_amount);
                                NewGoal(mynegativegoal);
                                break;
                            }

                    }
                }
            }
        }

    }//-------------------

}