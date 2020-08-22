using System;
using System.Threading;

namespace Inheritance_Example
{
  class VideoPost : Post
  {
    // member fields
    protected bool isPlaying = false;
    protected int currDuration = 0;
    Timer timer;

    // Properties
    protected string VideoURL { get; set; }
    protected int Length { get; set; }

    public VideoPost() { }

    public VideoPost(string title, string sendByUserName, string videoURL, bool isPublic, int length)
    {
      // Inheritance
      this.ID = GetNextID();
      this.Title = title;
      this.SendByUsername = sendByUserName;
      this.IsPublic = isPublic;

      // member of ImagePost, not Post
      this.VideoURL = videoURL;
      this.Length = length;
    }

    public void Play()
    {
      if (!isPlaying)
      {
        isPlaying = true;
        Console.WriteLine("Playing");
        timer = new Timer(TimerCallback, null, 0, 1000);
      }
    }

    private void TimerCallback(Object o)
    {
      if (currDuration < Length)
      {
        currDuration++;
        Console.WriteLine($"Video at {currDuration}s");
        GC.Collect();
      }
      else{
        Stop();
      }
    }

    public void Stop()
    {
      if (isPlaying)
      {
        isPlaying = false;
        Console.WriteLine($"Stopped at {currDuration}");
        currDuration = 0;
        timer.Dispose();
      } 
    }

    public override string ToString()
    {
      return String.Format($"{this.ID} - {this.Title} - {this.VideoURL} - {this.Length} - by {this.SendByUsername}");
    }
  }
}
