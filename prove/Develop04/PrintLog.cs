public class PrintLog : Activity
{
    public PrintLog(string myparams) : base(myparams)
    {
        
    }
    public void Play()
    {
        Console.Clear();
        Log printLog = new Log("mylog.dat");
        printLog.ListLogActivity();
        MsgWithSpinner( ShowWellDone());
    }
}