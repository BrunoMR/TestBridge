using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicStore.Domain;

namespace MusicStore.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IAlbumService _albumService;

        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        // GET: api/Album
        [HttpGet]
        public async Task<IEnumerable<Album>> Get()
        {
            return await _albumService.GetAll();
        }

        // GET: api/Album/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Album>> Get(int id)
        {
            var album = await _albumService.Get(id);
            
            return (ActionResult<Album>) album ?? NotFound();
        }

        // PUT: api/Album/2
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Album album)
        {
            if (id != album.Id)
            {
                return BadRequest();
            }

            _albumService.Update(album);

            return NoContent();
        }

        // POST: api/Album
        [HttpPost]
        public async Task<ActionResult<Album>> Post(Album album)
        {
            await _albumService.Insert(album);

            return CreatedAtAction("Get", new { id = album.Id }, album);
        }

        // DELETE: api/Album/2
        [HttpDelete("{id}")]
        public async Task<ActionResult<Album>> Delete(int id)
        {
            var album = await _albumService.Get(id);
            if (album == null)
            {
                return NotFound();
            }

            await _albumService.Delete(album);
            
            return album;
        }
    }
}
