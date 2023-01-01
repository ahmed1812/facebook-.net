namespace Facebook.Models
{
    public class UserPostViewModel
    {

        public UserInfo MyInfo { get; set; }
        public List<Post> UserPosts { get; set; }
        public List<Comment> comments { get; set; }
    }
}
