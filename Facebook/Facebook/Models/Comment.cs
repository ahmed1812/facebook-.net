using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Facebook.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string? Body { get; set; }
        [NotMapped]
        public UserInfo? UserId { get; set; }
        [NotMapped]
        public Post PostId { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
