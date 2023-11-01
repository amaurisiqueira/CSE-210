public class BreathingActivity : Activity
{
    public BreathingActivity(string myparams) : base(myparams)
    {
        _duration = 0;
    }
    public void Play()
    {
        _duration = GetDurationOfActivity();
        // Console.WriteLine("BreathingActivity -> duration:" + _duration);
        Console.Clear();
        MsgWithSpinner(ShowGetReady());
        log.WriteLogActivity("--------------------------------------------------");
        log.WriteLogActivity("Start Activity " + ShowActivityName());
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        Random rn = new();
        Console.WriteLine("");
        Console.WriteLine("");
        while (currentTime < futureTime)
        {
            //log register
            log.WriteLogActivity(ShowBreatheIn());
            MsgWithCountdown(ShowBreatheIn(), rn.Next(4, 6));
            Console.WriteLine("");
            //log register
            log.WriteLogActivity(ShowBreatheOut());
            MsgWithCountdown(ShowBreatheOut(), rn.Next(4, 6));
            Console.WriteLine("");
            Console.WriteLine("");
            currentTime = DateTime.Now;
        }
        string tmp_duration = ShowYouHaveCompleted().Replace("{_duration}", _duration.ToString());
        log.WriteLogActivity(tmp_duration);
        log.WriteLogActivity("End Activity " + ShowActivityName());
        MsgWithSpinner(ShowWellDone());
        Console.WriteLine("");
        Console.WriteLine("");
        MsgWithSpinner(tmp_duration);

    }
    protected string ShowBreatheIn()
    {
        string tmp = "";
        try
        {
            if (_jsonObs.breathe_in.ToString().Length > 0)
            {
                tmp = _jsonObs.breathe_in.ToString();
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
    protected string ShowBreatheOut()
    {
        string tmp = "";
        try
        {
            if (_jsonObs.breathe_out.ToString().Length > 0)
            {
                tmp = _jsonObs.breathe_out.ToString();
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