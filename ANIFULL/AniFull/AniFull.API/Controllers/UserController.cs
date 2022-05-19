using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AniFull.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AniFull.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly UserContext _db;
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger, UserContext db)
        {
            _logger = logger;
            _db = db;
        }
        // Get all users from DB
        [HttpGet]
        public async Task<ActionResult<List<User>>> ShowAllUsers()
        {
            var users = await _db.Users.ToListAsync();
            return Ok(users);
        }
        // Filter users by login
        [HttpGet("{login}")]
        public async Task<ActionResult<List<User>>> GetUserByLogin(string login)
        {
            var user = await _db.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Login!.ToLower() == login.ToLower());
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<List<User>>> AppendNewUser(User user)
        {
            _db.Users.Add(user);
            await _db.SaveChangesAsync();
            return Ok(user);
        }
        
        [HttpPut("{id}")]
        public async Task<ActionResult<List<User>>> ChangeUserData([FromBody] User user, [FromRoute] int id)
        {
            var userTemplate = _db.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            user.Id = id;
            _db.Update(user);
            await _db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<User>>> DeleteUserFromDb(int id)
        {
            var user = await _db.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            if (user == null) return NotFound();
            _db.Users.Remove(user!);
            await _db.SaveChangesAsync();
            return Ok();
        }
    }
}
