// video.cs
using System;
using System.Collections.Generic;

public class Video
{
  private string               videoTitle;
  private string               videoAuthor;
  private int                  videoLengthInSeconds;
  private List<Comment>        commentList = new List<Comment>();

  public Video(string titleName, string creatorName, int lengthSeconds)
  {
    videoTitle            = titleName;
    videoAuthor           = creatorName;
    videoLengthInSeconds  = lengthSeconds;
  }

  public void AddComment(Comment feedback)
  {
    commentList.Add(feedback);
  }

  public int GetCommentCount()
  {
    return commentList.Count;
  }

  public void DisplayVideoDetails()
  {
    Console.WriteLine($"\nTitle: {videoTitle}");
    Console.WriteLine($"Author: {videoAuthor}");
    Console.WriteLine($"Length: {videoLengthInSeconds} seconds ({videoLengthInSeconds/60:D2}:{videoLengthInSeconds%60:D2})");
    Console.WriteLine($"Number of Comments: {GetCommentCount()}");
    Console.WriteLine("Comments:");
    foreach (var comment in commentList)
    {
      comment.DisplayComment();
    }
  }
}
