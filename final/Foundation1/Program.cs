using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videoList = new List<Video>();

        Video video1 = new Video("How to Kill a Mockingbird: a study","DStar Videos",12.23);
        video1.AddComment("killer_whale32","Great video, I really love reading this book");
        video1.AddComment("Ballz0St33l","67 lol");
        video1.AddComment("llamalover9876","I read this book as a kid and loved it. Great Video");
        _videoList.Add(video1);

        Video video2 = new Video("How to find the Secret Easter Egg in Shmemfinder 2016","GamerHourz",30.11);
        video2.AddComment("girlboss88","I Could not find the Easter Egg to save my life. Thanks you so much for the help");
        video2.AddComment("xxx_shadowkiller_xxx","Lame game Easter egg takes too long don't know why you even made the video");
        video2.AddComment("shemfanforever","I used to love playing this game as a kid. I never even knew these eater eggs where there.");
        _videoList.Add(video2);

        Video video3 = new Video("Goodbye to the Prarie: Official Music Video","Knives and Tulips Official",6.50);
        video3.AddComment("tacoguy69","Saw this in concert back in 88, best concert I ever went through");
        video3.AddComment("smokez_weedz","This is a song you can clean a bathroom to");
        video3.AddComment("laura_smith","My dad used to love this song. We would listen to it together and every time I hear it, it reminds me of him. Love you dad");
        _videoList.Add(video3);

        Video video4 = new Video("Legend of Zolba: Wind of the Star Princess Official Teaser Trailer","Nemtembo Offical",3.34);
        video4.AddComment("loud_feels1088","YOOOOOOOOOOOOOOOOO");
        video4.AddComment("cupsOjazz_7","I am so hyped for this game");
        video4.AddComment("polish_tractor420","Looks lame. Nemtembo only releases trash anyways. Won't buy");
        _videoList.Add(video4);

        foreach (Video item in _videoList)
        {
            Console.WriteLine("-------------");
            item.DisplayInfo();
            Console.WriteLine();
            int comments = item.GetCommentNumber();
            Console.WriteLine($"Number of comments on this video: {comments}");
            Console.WriteLine("Comments: \n");

            item.DisplayCommentList();
            Console.WriteLine("-------------");
            Console.WriteLine();
        }
    }
}