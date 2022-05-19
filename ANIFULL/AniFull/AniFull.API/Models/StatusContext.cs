using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AniFull.API.Models
{
    public class StatusContext: DbContext
    {
        public StatusContext(DbContextOptions<StatusContext> options): base(options) { }
        public DbSet<Status> Statuses => Set<Status>();
    }

    public class Status
    {
        [Key] public int Id { get; set; }
        public int Viewed { get; set; }
        public int Looking { get; set; }
        public int InPlan { get; set; }
        public int Postponned { get; set; }
        public int Abandoned { get; set; }
    }
}
