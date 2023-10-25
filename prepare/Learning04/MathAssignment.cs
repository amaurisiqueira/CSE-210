public class MathAssignment : Assignment
{
    private string _textbookSeccion;
    private string _problems;
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {

        _textbookSeccion = textbookSection;
        _problems = problems;

    }
    public void GetHomeworksList()
    {
        Console.WriteLine($"{_studentName}-{_topic}");
        Console.WriteLine($"Secction {_textbookSeccion} problems {_problems}");
    }

}