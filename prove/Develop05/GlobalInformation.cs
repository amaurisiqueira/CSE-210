public class GlobalInformation
{
    private int _totalscore;
    private List<Goal> _allgoals;

    public GlobalInformation()
    {
        _totalscore = 0;
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

}