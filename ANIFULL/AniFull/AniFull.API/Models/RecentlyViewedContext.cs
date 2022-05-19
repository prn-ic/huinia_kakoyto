using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AniFull.API.Models
{
    public class RecentlyViewedContext: DbContext
    {
        public RecentlyViewedContext(DbContextOptions<RecentlyViewedContext> options): base(options) { }
        public DbSet<RecentlyView> RecentlyViews => Set<RecentlyView>();
    }

    public class RecentlyView
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int VideoId { get; set; }
        public DateTime? LastViewed { get; set; }
        public int Series { get; set; }
    }
}
