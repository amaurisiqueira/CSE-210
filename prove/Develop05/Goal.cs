public class Goal
{
    protected string _name;
    protected string _description;
    protected int _amount;

    public Goal()
    {
        _name = "";
        _description = "";
        _amount = 0;
    }
    public Goal(string name, string description, int amount)
    {
        _name = name;
        _description = description;
        _amount = amount;
    }
    public bool IsComplete(){
            return false;
    }
    public int RecordEvent(){
        return 0;
    }
    public string GetStringToShow(){
        return "Nothing";
    }
    public string GetStringToSave(){
        return "Nothing";
    }
    public void LoadStringFroSaved(string parameter){
            return ;
    }
}