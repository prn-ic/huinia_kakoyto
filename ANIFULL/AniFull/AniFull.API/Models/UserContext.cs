using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace AniFull.API.Models
{
    public class UserContext: DbContext
    {
        public UserContext(DbContextOptions<UserContext> options): base(options) { }
        public DbSet<User> Users => Set<User>();
    }

    public class User
    {
        [Key] public int Id { get; set; }
        public string? Login { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Vk { get; set; }
        public string? Telegram { get; set; }
        public string? Description { get; set; }
        public int NotificationId { get; set; }
        public string? Status { get; set; }
    }
}
