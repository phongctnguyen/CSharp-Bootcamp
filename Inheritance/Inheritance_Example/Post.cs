using System;

namespace Inheritance_Example
{
  class Post
  {
    private static int currentPostId;

    // properties
    protected int ID { get; set; }
    protected string Title { get; set; }
    protected string SendByUsername { get; set; }
    protected bool IsPublic { get; set; }

    // Default constructor
    public Post()
    {
      ID = 0;
      Title = "My First Post";
      IsPublic = true;
      SendByUsername = "Phong";
    }

    // Instance constructor that has 3 params
    public Post(string title, bool isPublic, string sendByUsername)
    {
      this.ID = GetNextID();
      this.Title = title;
      this.SendByUsername = sendByUsername;
      this.IsPublic = isPublic;
    }

    protected int GetNextID()
    {
      return ++currentPostId;
    }

    public void Update(string title, bool isPublic)
    {
      this.Title = title;
      this.IsPublic = isPublic;
    }

    // Virtual method override of the ToString method that is inherited from System.Object
    public override string ToString()
    {
      return String.Format($"{this.ID} - {this.Title} - by {this.SendByUsername}");
    }
  }
}

