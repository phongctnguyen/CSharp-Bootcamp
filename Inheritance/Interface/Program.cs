using System;

namespace Interface
{
  public interface INotification
  {
    // Members
    void showNotification();
    string getDate();
  }

  public class Notification : INotification
  {
    private string sender;
    private string message;
    private string date;

    public Notification()
    {
      sender = "Admin";
      message = "Yo, what's up";
      date = " ";
    }

    public Notification(string mySender, string myMessage, string myDate)
    {
      this.sender = mySender;
      this.message = myMessage;
      this.date = myDate;
    }

    public void showNotification()
    {
        Console.WriteLine($"Message {message} was sent by {sender} at {date}");
    }

    public string getDate()
    {
        return date;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Notification n1 = new Notification("Phong", "Hello", "20.08.2020");
      n1.showNotification();
    }
  }
}
