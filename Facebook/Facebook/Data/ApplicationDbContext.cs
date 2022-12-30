using Facebook.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Facebook.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Facebook.Models.Comment> Comment { get; set; }

    }
}