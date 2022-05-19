using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AniFull.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AniFull.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PreviewController : Controller
    {
        private readonly PreviewContext _db;
        private readonly ILogger<PreviewController> _logger;

        public PreviewController(ILogger<PreviewController> logger, PreviewContext db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Preview>>> ShowAllAnimes()
        {
            var animeList = await _db.Previews.ToListAsync();
            return Ok(animeList);
        }

        [HttpGet("{author}")]
        public async Task<ActionResult<List<Preview>>> ShowAnimeByAuthor(string author)
        {
            var animeList = await _db.Previews.Where(x => x.Author!.Contains(author)).ToListAsync();
            return Ok(animeList);
        }

        [HttpPost]
        public async Task<ActionResult<List<Preview>>> CreateNewPreview(Preview newPreview)
        {
            _db.Previews.Add(newPreview);
            await _db.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Preview>>> ChangeDataPreview([FromBody] Preview preview, [FromRoute] int id)
        {
            var previewTemp = _db.Previews.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            preview.Id = id;
            _db.Update(preview);
            await _db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Preview>>> DeletePreview(int id)
        {
            var previewTemp = _db.Previews.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            _db.Remove(previewTemp);
            await _db.SaveChangesAsync();
            return Ok();
        }
    }
}
