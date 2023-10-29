public class Activity:Json
{
        protected int _duration;
        protected Log log;
        public Activity(String file): base(file) 
        {
                log = new Log("mylog.dat");
                _duration = 0;
                //  jsonInstance = new(file);
                //   MsgWithSpinner("testing my spinner:");
                //   Console.WriteLine("");
                //   MsgWithCountdown("testing my countdown:");
                //   GetDurationOfActivity();
        }
        protected void MsgWithSpinner(string msg, int time = 5, bool newline = true)
        {
                List<string> spinnner = new List<string>();
                spinnner.Add("|");
                spinnner.Add("/");
                spinnner.Add("-");
                spinnner.Add("\\");
                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(time);
                DateTime currentTime = DateTime.Now;
                if (newline) Console.WriteLine(msg);
                else Console.Write(msg);
                int iteration = 0;
                while (currentTime < futureTime)
                {
                        Console.Write(spinnner[iteration]);
                        Thread.Sleep(500);
                        Console.Write("\b \b");
                        iteration++;
                        if (iteration > 3) iteration = 0;
                        currentTime = DateTime.Now;
                }
        }
        protected void MsgWithCountdown(string msg, int time = 5)
        {
                int countdown = time;
                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(time);
                DateTime currentTime = DateTime.Now;
                Console.Write(msg);

                while (currentTime < futureTime)
                {
                        Console.Write(countdown--);
                        Thread.Sleep(1000);
                        Console.Write("\b \b");
                        currentTime = DateTime.Now;
                }
        }
                protected int GetDurationOfActivity()
        {
                Console.Clear();
                int duration = 0;
                Console.WriteLine(ShowWelcomeMessage());
                Console.WriteLine("");
                Console.WriteLine(ShowDescriptionOfActivity());
                Console.WriteLine("");
                Console.Write(ShowHowLongTime());
                while (true)
                {
                        bool failure = int.TryParse(Console.ReadLine().Trim(), out duration);
                        if (failure && duration > 0) break;
                }
                return duration;
        }
        protected string ShowGetReady()
        {
                return  GetReady();
        }
        protected string ShowWellDone()
        {
                return GetWellDone();
        }
        protected string ShowWelcomeMessage()
        {
                return GetWelcomeMessage();
        }
        protected string ShowActivityName()
        {
                return GetActivityName();
        }
        protected string ShowDescriptionOfActivity()
        {
                return GetDescriptionOfActivity();
        }
        protected string ShowHowLongTime()
        {
                return GetHowLongTime();
        }
        protected string ShowMessageToPressKey()
        {
                return GetMessageToPressKey();
        }
        protected string ShowMessageNowPonderOnEach()
        {
                return GetMessageNowPonderOnEach();
        }
        protected string ShowRandomPrompt()
        {
                return GetRandomPrompt();
        }
        protected string ShowReflectPrompt()
        {
                return GetReflectPrompt();
        }
        protected string ShowBreatheIn()
        {
                return GetBreatheIn();
        }
        protected string ShowBreatheOut()
        {
                return GetBreatheOut();
        }
        protected string ShowYouHaveCompleted()
        {
                return GetYouHaveCompleted();
        }
}


