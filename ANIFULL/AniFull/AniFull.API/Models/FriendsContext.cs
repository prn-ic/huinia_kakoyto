using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AniFull.API.Models
{
    public class FriendsContext: DbContext
    {
        public FriendsContext(DbContextOptions<FriendsContext> options): base(options) { }
        public DbSet<Friend> Friends => Set<Friend>();
    }

    public class Friend
    {
        [Key] public int Id { get; set; }
        public int User1 { get; set; }
        public int User2 { get; set; }
    }
}
