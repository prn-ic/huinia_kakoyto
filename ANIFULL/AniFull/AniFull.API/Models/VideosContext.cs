using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AniFull.API.Models
{
    public class VideosContext: DbContext
    {
        public VideosContext(DbContextOptions<VideosContext> options): base(options) { }
        public DbSet<Video> Videos => Set<Video>();
    }
    
    public class Video
    {
        [Key] public int Id { get; set; }
        public int AnimeId { get; set; }
        public string? Logo { get; set; }
        public string? TitleAnime { get; set; }
        public string? VideoURI { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
    }
}
