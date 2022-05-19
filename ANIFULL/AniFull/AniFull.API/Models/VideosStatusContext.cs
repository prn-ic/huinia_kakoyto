using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AniFull.API.Models
{
    public class VideosStatusContext: DbContext
    {
        public VideosStatusContext(DbContextOptions<VideosStatusContext> options): base(options) { }
        public DbSet<VideoStatus> VideoStatuses => Set<VideoStatus>();
    }

    public class VideoStatus
    {
        [Key] public int Id { get; set; }
        public int VideoId { get; set; }
        public int StatusId { get; set; }
    }
}
