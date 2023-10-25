public class WriteAssignment : Assignment
{
    private string _title;

    public WriteAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public void GetWritingInformation(){
           Console.WriteLine($"{_studentName}-{_topic}");
           Console.WriteLine($"{_title}");
    }

}