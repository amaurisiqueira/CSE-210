using Newtonsoft.Json;
public class Json
{

    private dynamic _jsonObs;
    public Json(string file)
    {
        if (File.Exists(file))
        {
            using (StreamReader r = new StreamReader(file))
            {
                string json = r.ReadToEnd();
                _jsonObs = JsonConvert.DeserializeObject(json);
            }

        }
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
}