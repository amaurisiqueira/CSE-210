public class SimpleGoal : Goal
{
    private bool _complete;
 
    public override bool IsComplete()
    {
        return _complete;
    }
    public SimpleGoal(string name, string description, int amount , bool complete=false) : base(name, description, amount)
    {
        _complete = complete;
    }


    public override string GetStringToFormated()
    {
        int _int_ended = 0;
        if (IsComplete()) _int_ended = 1;
        return $"1|{_int_ended}|{_name}|{_description}|{_amount}";
    }

 
    public override int RecordEvent()
    {
        if (IsComplete()) return 0;
        _complete = true;
        return _amount;
    }
}