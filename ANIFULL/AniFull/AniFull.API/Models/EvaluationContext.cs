using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AniFull.API.Models
{
    public class EvaluationContext: DbContext
    {
        public EvaluationContext(DbContextOptions<EvaluationContext> options): base(options) { }
        public DbSet<Evaluation> Evaluations => Set<Evaluation>();
    }

    public class Evaluation
    {
        [Key] public int Id { get; set; }
        public int VideoId { get; set; }
        public int UserId { get; set; }
        public int Score { get; set; }
    }
}
