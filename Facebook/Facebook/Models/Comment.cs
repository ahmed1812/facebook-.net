using System.ComponentModel.DataAnnotations;

namespace Facebook.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Body { get; set; }
        public int UserId { get; set; }
        public UserInfo ComUser { get; set; }
        public int PostId { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
