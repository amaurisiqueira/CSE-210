public class ReflectingActivity : Activity
{
    public ReflectingActivity(string myparams) : base(myparams)
    {
        _duration = 0;
    }
    protected string ShowMessageNowPonderOnEach()
    {
        string tmp = "";
        try
        {
            if (_jsonObs.now_ponder_on_each.ToString().Length > 0)
            {
                tmp = _jsonObs.now_ponder_on_each.ToString();
            };
            if (tmp.Length == 0)
            {
                tmp = "The key is empty !";
            }
        }
        catch (System.Exception)
        {
            tmp = "Invalid key name !";
        }
        return tmp;
    }
    public void Play()
    {
        Random rn = new();
        _duration = GetDurationOfActivity();
        // Console.WriteLine(" duration:" + _duration);
        Console.Clear();
        MsgWithSpinner(ShowGetReady());
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
        MsgWithSpinner(ShowWellDone());
        Console.WriteLine("");
        Console.WriteLine("");
        MsgWithSpinner(ShowYouHaveCompleted().Replace("{_duration}", _duration.ToString()));
    }
    protected string ShowReflectPrompt()
    {
        string tmp = "";
        try
        {
            string[] promptArray = _jsonObs.reflect_prompt.ToObject<string[]>();
            if (promptArray.Length > 0)
            {
                Random rnd = new();
                tmp = promptArray[rnd.Next(1, promptArray.Length) - 1].ToString().Trim();
                if (tmp.Length == 0)
                {
                    tmp = "The key is empty !";
                }
            }
            else
            {
                tmp = "Invalid file name !";
            };
        }
        catch (System.Exception) { tmp = "Invalid key name !"; }
        return tmp;
    }
    protected string ShowMessageToPressKey()
    {
        string tmp = "";
        try
        {
            if (_jsonObs.message_to_press_key.ToString().Length > 0)
            {
                tmp = _jsonObs.message_to_press_key.ToString();
            };
            if (tmp.Length == 0)
            {
                tmp = "The key is empty !";
            }
        }
        catch (System.Exception)
        {
            tmp = "Invalid key name !";
        }
        return tmp;
    }
}