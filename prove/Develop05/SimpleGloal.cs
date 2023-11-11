public class SimpleGoal : Goal
{
    private bool _complete;
    public SimpleGoal(string name, string description, int amount) : base(name, description, amount)
    {
        _complete = false;
    }

}