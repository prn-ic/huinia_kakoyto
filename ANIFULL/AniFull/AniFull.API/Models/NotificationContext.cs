using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using AniFull.API.Models;

namespace AniFull.API.Models
{
    public class NotificationContext : DbContext
    {
        public NotificationContext(DbContextOptions<NotificationContext> options) : base(options) { }
        public DbSet<Notification> Notifications => Set<Notification>();
    }

    public class Notification
    {
        [Key] public int Id { get; set; }
        public int UserId { get; set; }
        public int Count { get; set; }

    }
}
