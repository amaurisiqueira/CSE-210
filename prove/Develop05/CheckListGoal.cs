public class CheckListGoal : Goal
{
    public override bool IsComplete()
    {
        if (_current_iteration >= _totaliteraction) return true;
        return false;
    }
    private int _totaliteraction;
    private int _bonus;
    private int _current_iteration;

    public CheckListGoal(string name, string description, int amount, int anytime, int bonus, int current) : base(name, description, amount)
    {
        _totaliteraction = anytime;
        _bonus = bonus;
        _current_iteration = current;

    }

    public override string GetStringToShow()
    {
        string myreturn;
        if (IsComplete())
        {
            myreturn = $"[X] {_name}({_description})";
        }
        else
        {
            myreturn = $"[ ] {_name}({_description}) --- Currently completed:{_current_iteration}/{_totaliteraction}";
        }

        return myreturn;
    }

    public override string GetStringToFormated()
    {
        int _int_ended = 0;
        if (IsComplete()) _int_ended = 1;
        return $"3|{_int_ended}|{_name}|{_description}|{_amount}|{_current_iteration}|{_totaliteraction}|{_bonus}";
    }
    
    public override int RecordEvent()
    {
        if (IsComplete()) return 0;
        int myreturn = 0;
        if (_current_iteration < _totaliteraction)
        {
            myreturn = _amount;
            _current_iteration++;
            if (_current_iteration >= _totaliteraction)
            {
                myreturn += _bonus;
            }
        }
        return myreturn;
    }

}