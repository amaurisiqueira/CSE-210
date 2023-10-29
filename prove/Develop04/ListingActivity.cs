public class ListingActivity : Activity
{
    List<string> listBegin = new();
    public ListingActivity(string myparams) : base(myparams)
    {
        _duration = 0;
    }
    public void Play()
    {
        Random rn = new();
        _duration = GetDurationOfActivity();
        // Console.WriteLine(" duration:" + _duration);
        Console.Clear();
        MsgWithSpinner(ShowGetReady());
        string tmp_prompt = ShowRandomPrompt() ;
        Console.WriteLine("");
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"-- {tmp_prompt} ---");
        //Console.WriteLine(ShowMessageToPressKey());
        MsgWithCountdown("You may begin in:", rn.Next(4, 6));
        Console.WriteLine("");
        log.WriteLogActivity("--------------------------------------------------");
        log.WriteLogActivity("Start Activity " + ShowActivityName());
        log.WriteLogActivity("The list of responses to the following prompt:");
        log.WriteLogActivity($"-- {tmp_prompt} ---");
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        // Console.Clear();
        while (currentTime < futureTime)
        {
            //    MsgWithSpinner($">{ShowReflectPrompt()}", 15, false);
            Console.Write(">");
            string tmpinput = Console.ReadLine().Trim();
            if (tmpinput.Count() > 0)
            {
                listBegin.Add(tmpinput);
                log.WriteLogActivity(">" + tmpinput);
            }
            currentTime = DateTime.Now;
        }
        string tmp_string_listed = $"You listed {listBegin.Count()} items!";
        string tmp_duration = ShowYouHaveCompleted().Replace("{_duration}", _duration.ToString());
        log.WriteLogActivity(tmp_string_listed);
        log.WriteLogActivity(tmp_duration);
        log.WriteLogActivity("End Activity " + ShowActivityName());
        Console.WriteLine(tmp_string_listed);
        Console.WriteLine("");
        Console.WriteLine("");
        MsgWithSpinner( ShowWellDone());
        Console.WriteLine("");
        Console.WriteLine("");
        MsgWithSpinner(tmp_duration);
    }
}