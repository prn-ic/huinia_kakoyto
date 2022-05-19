using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AniFull.API.Models
{
    public class ViewingDynamicContext: DbContext
    {
        public ViewingDynamicContext(DbContextOptions<ViewingDynamicContext> options): base(options) { }
        public DbSet<ViewingDynamic> ViewingDynamics => Set<ViewingDynamic>(); 
    }

    public class ViewingDynamic
    {
        [Key] public int Id { get; set; }
        public int UserId { get; set; }
        public int Series { get; set; }
        public DateTime? LastWatched { get; set; }
    }
}
