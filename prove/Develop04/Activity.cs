using Newtonsoft.Json;
public class Activity
{
        protected dynamic _jsonObs;
        protected int _duration;
        protected Log log;
        public Activity(String file)
        {
                log = new Log("mylog.dat");
                _duration = 0;
                if (File.Exists(file))
                {
                        using (StreamReader r = new StreamReader(file))
                        {
                                string json = r.ReadToEnd();
                                _jsonObs = JsonConvert.DeserializeObject(json);
                        }

                }
        }
        protected string ShowDescriptionOfActivity()
        {
                string tmp = "";
                try
                {
                        if (_jsonObs.description.ToString().Length > 0)
                        {
                                tmp = _jsonObs.description.ToString();
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
        protected string ShowHowLongTime()
        {
                string tmp = "";
                try
                {
                        if (_jsonObs.how_long_time.ToString().Length > 0)
                        {
                                tmp = _jsonObs.how_long_time.ToString();
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
                        Thread.Sleep(100);
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
                Console.Write(ShowHowLongTime() + " ");
                while (true)
                {
                        bool failure = int.TryParse(Console.ReadLine().Trim(), out duration);
                        if (failure && duration > 0) break;
                }
                return duration;
        }
        protected string ShowGetReady()
        {
                string tmp = "";
                try
                {
                        if (_jsonObs.get_ready.ToString().Length > 0)
                        {
                                tmp = _jsonObs.get_ready.ToString();
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
        protected string ShowWellDone()
        {
                string tmp = "";
                try
                {
                        if (_jsonObs.well_done.ToString().Length > 0)
                        {
                                tmp = _jsonObs.well_done.ToString();
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
        protected string ShowWelcomeMessage()
        {
                string tmp = "";
                try
                {
                        if (_jsonObs.welcome.ToString().Length > 0 &&
                         _jsonObs.activity_name.ToString().Length > 0
                        )
                        {
                                tmp = _jsonObs.welcome.ToString() + " " + _jsonObs.activity_name.ToString();
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
        protected string ShowActivityName()
        {
                string tmp = "";
                try
                {
                        if (_jsonObs.activity_name.ToString().Length > 0
                        )
                        {
                                tmp = _jsonObs.activity_name.ToString();
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
        protected string ShowYouHaveCompleted()
        {
                string tmp = "";
                try
                {
                        if (_jsonObs.you_have_completed.ToString().Length > 0)
                        {
                                tmp = _jsonObs.you_have_completed.ToString();
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
        protected string ShowRandomPrompt()
        {
                string tmp = "";
                try
                {
                        string[] promptArray = _jsonObs.prompt.ToObject<string[]>();
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
}


