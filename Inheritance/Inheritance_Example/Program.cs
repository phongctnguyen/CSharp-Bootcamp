using System;

namespace Inheritance_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for birthday wishes", true, "Ronaldo");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Phong", "image.png", true);
            Console.WriteLine(imagePost1.ToString());

            VideoPost videoPost1 = new VideoPost("Fail Video", "Phong", "www.video.com/fail", true, 10);
            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video");
            Console.ReadKey();
            videoPost1.Stop();
        }
    }
}
