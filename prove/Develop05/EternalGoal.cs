public class EternalGoal : Goal
{
  
     public EternalGoal(string name, string description, int amount) : base(name, description, amount)
     {

     }
     public override string GetStringToFormated()
     {
          return $"2|0|{_name}|{_description}|{_amount}";
     }

     public override int RecordEvent()
     {
          return _amount;
     }
}