var comment1 = new Comment {
  Text = "Oh my gooooood",
};

var comment2 = new Comment {
  Text = "It's happening",
};

var post = new Post {
  Date = DateTime.Now,
  Title = "Post title",
  Content = "Post content",
  Likes = 35,
};

post.AddComment(comment1);
post.AddComment(comment2);

System.Console.WriteLine(post);