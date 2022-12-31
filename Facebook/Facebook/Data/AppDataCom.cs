using Facebook.Models;

namespace Facebook.Data
{
    public class AppDataCom
    {
        public IEnumerable<Comment> DataCom(IEnumerable<Comment> CommentList) 
        {
            CommentList = new List<Comment>()
            {
                new Comment { Id = 1, Body = "Comment 1", PostId = 1, CreateAt = DateTime.Now, UserId = 3},
                new Comment { Id = 2, Body = "Comment 2", PostId = 1, CreateAt = DateTime.Now, UserId = 1},
                new Comment { Id = 3, Body = "Comment 3", PostId = 1, CreateAt = DateTime.Now, UserId = 2},

                new Comment { Id = 4, Body = "Comment 1", PostId = 2, CreateAt = DateTime.Now, UserId = 2},
                new Comment { Id = 5, Body = "Comment 2", PostId = 2, CreateAt = DateTime.Now, UserId = 3},
                new Comment { Id = 6, Body = "Comment 3", PostId = 2, CreateAt = DateTime.Now, UserId = 1},

                new Comment { Id = 7, Body = "Comment 1", PostId = 3, CreateAt =DateTime.Now, UserId = 1},
                new Comment { Id = 8, Body = "Comment 2", PostId = 3, CreateAt = DateTime.Now, UserId = 2},
                new Comment { Id = 9, Body = "Comment 3", PostId = 3, CreateAt = DateTime.Now, UserId = 3},
            };
            return CommentList.ToList();
        }
        
    }
}
