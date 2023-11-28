public class Comment
{
    private string _username;
    private string _comment;
    public Comment(string usr, string comm)
    {
        _username = usr;
        _comment = comm;
    }
    public string GetUsername() { return _username; }
    public string GetComment() { return _comment; }
}