using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AniFull.API.Models
{
    public class PreviewContext: DbContext
    {
        public PreviewContext(DbContextOptions<PreviewContext> options): base(options) { }
        public DbSet<Preview> Previews => Set<Preview>();
    }

    public class Preview
    {
        [Key] public int Id { get; set; }
        public int AnimeId { get; set; }
        public int CommentId { get; set; }
        public int StatusId{ get; set; }
        public string? Country { get; set; }
        public string? Author { get; set; }
        public string? Duration { get; set; }
        public string? Producer { get; set; }
        public int Series { get; set; }
        public int Season { get; set; }
        public int Bookmarks { get; set; }
        public DateTime? Year { get; set; }
        public int AgeLimit { get; set; }
    }
}
