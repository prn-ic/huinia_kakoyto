using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AniFull.API.Models
{
    public class SupportsContext: DbContext
    {
        public SupportsContext(DbContextOptions<SupportsContext> options): base(options) { }
        public DbSet<Support> Supports => Set<Support>();
    }

    public class Support
    {
        [Key] public int Id { get; set; }
        public int UserId { get; set; }
        public string? Message { get; set; }
    }
}
