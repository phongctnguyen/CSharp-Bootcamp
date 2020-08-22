using System;

namespace Inheritance_Example
{
  // ImagePost derives from Post and adds a property (imageUrll) and two constructors
  class ImagePost : Post
  {
    public string ImageURL { get; set; }

    public ImagePost() { }

    public ImagePost(string title, string sendByUserName, string imageURL, bool isPublic)
    {
      // Inheritance
      this.ID = GetNextID();
      this.Title = title;
      this.SendByUsername = sendByUserName;
      this.IsPublic = isPublic;

      // member of ImagePost, not Post
      this.ImageURL = imageURL;
    }

    public override string ToString()
    {
      return String.Format($"{this.ID} - {this.Title} - {this.ImageURL} - by {this.SendByUsername}");
    }
  }
}
