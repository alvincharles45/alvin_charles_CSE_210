// comment.cs
using System;

public class Comment
{
  private string commenterName;
  private string commentText;

  public Comment(string authorName, string message)
  {
    commenterName = authorName;
    commentText     = message;
  }

  public void DisplayComment()
  {
    Console.WriteLine($"- {commenterName}: {commentText}");
  }
}
