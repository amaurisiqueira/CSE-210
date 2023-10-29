public class ReflectingActivity : Activity
{
    public ReflectingActivity(string myparams) : base(myparams)
    {
        _duration = 0;
    }
    public void Play()
    {
        Random rn = new();
        _duration = GetDurationOfActivity();
       // Console.WriteLine(" duration:" + _duration);
        Console.Clear();
        MsgWithSpinner( ShowGetReady());
        Console.WriteLine("");
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"-- {ShowRandomPrompt()} ---");
        Console.WriteLine("");
        Console.WriteLine(ShowMessageToPressKey());
        Console.ReadLine();
        Console.WriteLine("");
        MsgWithCountdown(ShowMessageNowPonderOnEach(), rn.Next(4, 6));
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        Console.Clear();
        while (currentTime < futureTime)
        {
            MsgWithSpinner($">{ShowReflectPrompt()}", 15, false);
            Console.WriteLine("");
            currentTime = DateTime.Now;
        }
        Console.WriteLine("");
        MsgWithSpinner( ShowWellDone());
        Console.WriteLine("");
        Console.WriteLine("");
        MsgWithSpinner(ShowYouHaveCompleted().Replace("{_duration}", _duration.ToString ()));
    }



}