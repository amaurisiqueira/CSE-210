public class NegativeGoals : Goal
{
    public NegativeGoals(string name, string description, int amount) : base(name, description, amount)
    {
    }
    public override string GetStringToFormated()
    {
        return $"4|0|{_name}|{_description}|{_amount}";
    }
    public override int RecordEvent()
    {
        if (_amount > 0) return -1 * _amount;
        return _amount;
    }
}
