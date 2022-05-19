using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AniFull.API.Models
{
    public class CommentariesContext: DbContext
    {
        public CommentariesContext(DbContextOptions<CommentariesContext> options): base(options) { }
        public DbSet<Comment> Commentaries => Set<Comment>();
    }

    public class Comment
    {
        [Key] public int Id { get; set; }
        public int UserId { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
    }
}
