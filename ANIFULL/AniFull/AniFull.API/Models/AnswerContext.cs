using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AniFull.API.Models
{
    public class AnswerContext: DbContext
    {
        public AnswerContext(DbContextOptions<AnswerContext> options): base(options) { }
        public DbSet<Answer> Answers => Set<Answer>();
    }

    public class Answer
    {
        [Key] public int Id { get; set; }
        public int CommentId { get; set; }
        public int UserRequestId { get; set; }
        public int UserResponseId { get; set; }
        public string? Commentaries { get; set; }
    }
}
