public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> comments  ;
    public Video(string tit, string aut, int len)
    {
        comments = new List<Comment>();
        _title = tit;
        _author = aut;
        _length = len;
    }
    public void AddCommentary(string username, string comment)
    {
        Comment mycommentary = new Comment(username, comment);
        comments.Add(mycommentary);
    }
    public int GetTotalCommentaries(){
        return comments.Count;
    }
    public List<Comment> GetCommentary()
    {
        return comments;
    }
    public string GetTitle(){ return _title;}
    public string GetAuthor(){ return _author;}
    public int GetLength(){return _length;}
}