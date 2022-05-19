using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AniFull.API.Models
{
    public class RequestFriendContext: DbContext
    {
        public RequestFriendContext(DbContextOptions<RequestFriendContext> options): base(options) { }
        public DbSet<Request> Requests => Set<Request>();
    }

    public class Request
    {
        [Key] public int Id { get; set; }
        public int UserRequest { get; set; }
        public int UserResponse { get; set; }
    }
}
