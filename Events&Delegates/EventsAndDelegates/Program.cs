using System;

namespace EventsAndDelegates
{
  class Program
  {
    static void Main(string[] args)
    {
      var file = new File() { Title = "File 1" };
      var downloadHelper = new DownloadHelper(); // publisher
      var unpackService = new UnpackService(); // receiver
      var notificationService = new NotificationService(); //receiver

      downloadHelper.FileDownloaded += unpackService.OnFileDownloading;
      downloadHelper.FileDownloaded += notificationService.OnFileDownloading;

      downloadHelper.Download(file);
    }
  }

  public class UnpackService
  {
    public void OnFileDownloading(object source, FileEventArgs e)
    {
      Console.WriteLine("UnpackerService: Unpacking the file..." + e.File.Title);
    }
  }

  public class NotificationService
  {
    public void OnFileDownloading(object source, FileEventArgs e)
    {
      Console.WriteLine("Notifying: Notifyibg user that download is done..." + e.File.Title);
    }
  }
}
