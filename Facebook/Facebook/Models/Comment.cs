using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Facebook.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string? Body { get; set; }
        public int UserId { get; set; }
        //[ForeignKey("PostId")]
        public int PostId { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
