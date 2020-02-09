<Query Kind="Program" />

void Main() {
 List < BlogPost > posts = new List < BlogPost > () {
  new BlogPost() {
    Id = 1,
     Comments = new List < Comment > () {
      new Comment() {
        Id = 1,
         Content = "It's really great!",
       },
       new Comment() {
        Id = 2,
         Content = "Cool post!"
       }
     }
   },
   new BlogPost() {
    Id = 2,
     Comments = new List < Comment > () {
      new Comment() {
        Id = 3,
         Content = "I don't think you're right",
       },
       new Comment() {
        Id = 4,
         Content = "This post is a complete nonsense"
       }
     }
   }
 };
 
var commentsWithIds = posts.SelectMany(p => p.Comments, (post, comment) => new { PostId = post.Id,
CommentContent = comment.Content });

commentsWithIds.Dump();

}

// Define other methods and classes here
public class BlogPost {
 public int Id {
  get;
  set;
 }
 public string Content {
  get;
  set;
 }
 public List < Comment > Comments {
  get;
  set;
 }
}

public class Comment {
 public int Id {
  get;
  set;
 }
 public string Content {
  get;
  set;
 }
}