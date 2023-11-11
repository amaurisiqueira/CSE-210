public class CheckListGoal : Goal
{
    private bool _complete;
    public CheckListGoal(string name, string description, int amount) : base(name, description, amount)
    {
        _complete = false;
    }

}