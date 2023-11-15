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
    public virtual bool IsComplete(){
            return false;
    }
    public virtual int RecordEvent(){
        return 0;
    }
    public virtual string GetStringToShow(){
          string ended = " ";
        if (IsComplete()) ended = "X";
        return $"[{ended}] {_name}({_description})";
    }
    public virtual string GetStringToFormated(){
        return "Nothing";
    }
   
}