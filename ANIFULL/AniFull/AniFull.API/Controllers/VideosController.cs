using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AniFull.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AniFull.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VideosController : Controller
    {
        private readonly VideosContext _db;
        private readonly ILogger<VideosController> _logger;

        public VideosController(ILogger<VideosController> logger, VideosContext db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Video>>> ShowAllVideos()
        {
            var videos = await _db.Videos.ToListAsync();
            return Ok(videos);
        }

        [HttpGet("{title}")]
        public async Task<ActionResult<List<Video>>> FilterByTitle(string title)
        {
            var video = await _db.Videos.AsNoTracking().FirstOrDefaultAsync(x => x.TitleAnime == title);
            return Ok(video);
        }

        [HttpPost]
        public async Task<ActionResult<List<Video>>> AppendNewVideo(Video video)
        {
            _db.Videos.Add(video);
            await _db.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Video>>> ChangeVideo([FromBody] Video video, [FromRoute] int id)
        {
            var videoTemp = _db.Videos.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            video.Id = id;
            _db.Update(video);
            await _db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Video>>> DeleteVideoFromDb([FromBody] Video video, [FromRoute] int id)
        {
            var videoTemp = _db.Videos.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            video.Id = id;
            _db.Remove(video);
            await _db.SaveChangesAsync();
            return Ok();
        }
    }
}
