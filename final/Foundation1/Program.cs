using System;

class Program
{
    static List<Video> myVideos;

    public Program()
    {
        myVideos = new List<Video>();
        Video video1 = new Video("Interstellar - Inspired Emotional Cinematic Ambient Music", "Ethereal World Cinematic Music", 3780);
        video1.AddCommentary("@thewayofwatermeditation", "I've tried many long-version Interstellar music, but yours stands out. The authenticity and sincerity in this one, I truly felt.");
        video1.AddCommentary("@Becky12348", "The best version I’ve listened to so far ❤ thank u so much");
        video1.AddCommentary("@PYEWACKET65", "Thank you for sharing!!  This helps me so much when I'm stressing at work :)");
        myVideos.Add(video1);
        Video video2 = new Video("CORAZÓN VALIENTE Braveheart | Full Soundtrack | CORAZÓN VALIENTE Braveheart Best Songs | OST", "MusicTape", 4800);
        video2.AddCommentary("@@mcmarkmarkson7115", "Still one of the greatest movies ever produced");
        video2.AddCommentary("@carmencalzadamendoza3011", "Excelente !!!");
        video2.AddCommentary("@fenixdelcorazon", "WooW...!!! Especial....😊🎧✨🌕");
        myVideos.Add(video2);
        Video video3 = new Video("SQL Full Outer Join Using UNION For MySQL", "Ankit Bansal", 360);
        video3.AddCommentary("@sivasrimakurthi206", "this is 1 comprehensive video about the Window Frames class, it did explain the aggregation logic on windows, Frames etc very well. Loved the content, keep rocking @AnkitBansal 🙂");
        video3.AddCommentary("@aniketraut6864", "Thank you Ankit,  your videos are helping me a lot to learn new things related with sql. keep doing the good work. God bless you.");
        video3.AddCommentary("@ayushishukla2333", "I think UNION will also give same result. So no need to use where condition if we use UNION only, because UNION will remove duplicate. Please correct me if I am wrong.");
        video3.AddCommentary("@karangupta_DE","Hi Ankit, could you kindly make a video and talk about EXISTS and NOT EXISTS.");
        myVideos.Add(video3);



    }

    public void ShowComments()
    {

        bool first = true;
        foreach (Video v in myVideos)
        {
            if (first) first = false;
            else Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Title:" + v.GetTitle());
            Console.WriteLine("Length:" + v.GetLength()+" seconds");
            Console.WriteLine("Author:" + v.GetAuthor());
            Console.WriteLine("# commentaries:" + v.GetTotalCommentaries() );
            Console.WriteLine("Commentaries:");
            int secuenceComentary=0;
            foreach (Comment c in v.GetCommentary())
            {
                Console.WriteLine( ++secuenceComentary +")" +c.GetUsername() + " Commentary:" + c.GetComment());
            }
             
        }

    }

    static void Main(string[] args)
    {
        Program p = new Program();
        Console.WriteLine("Foundation 1");
        p.ShowComments();

    }
}