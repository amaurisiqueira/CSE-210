public class Log
{
    private string _filename;
    public Log(string file)
    {
        _filename = file;

    }
    public void ListLogActivity()
    {
        Console.WriteLine("Log register");
        Console.WriteLine("******************************************************************");
        if (File.Exists(_filename))
        {
            using (StreamReader r = new StreamReader(_filename))
            {
                while (!r.EndOfStream)
                {
                    Console.WriteLine(r.ReadLine());
                }
            }
        }
        Console.WriteLine("******************************************************************");
        Console.WriteLine("EOF");
    }
    public void WriteLogActivity(string register)
    {
        using (StreamWriter buffer = new StreamWriter(_filename, true))
        {
            buffer.WriteLine($"{DateTime.Now.ToString()} {register}");
        }
    }

}