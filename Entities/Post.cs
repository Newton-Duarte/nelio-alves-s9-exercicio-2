using System.Text;

class Post
{
  public DateTime Date { get; set; }
  public string Title { get; set; }
  public string Content { get; set; }
  public int Likes { get; set; }
  public List<Comment> Comments { get; set; } = new();

  public Post()
  {

  }

  public Post(DateTime date, string title, string content, int likes, List<Comment> comments)
  {
    Date = date;
    Title = title;
    Content = content;
    Likes = likes;
    Comments = comments;
  }

  public override string ToString()
  {
    var comments = new StringBuilder();

    foreach(var comment in Comments)
    {
      comments.AppendLine(comment.Text);
    }

    return $@"
      Date: {Date}
      Title: {Title}
      Content: {Content}
      Likes: {Likes}
      Comments:
      {comments}
    ";
  }

  public void AddComment(Comment comment)
  {
    Comments.Add(comment);
  }

  public void RemoveComment(Comment comment)
  {
    Comments.Remove(comment);
  }
}