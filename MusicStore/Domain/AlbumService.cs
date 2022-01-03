using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicStore.Data;

namespace MusicStore.Domain
{
    public class AlbumService : IAlbumService
    {
        private readonly AlbumContext _context;

        public AlbumService(AlbumContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Album>> GetAll()
        {
            return await _context.Albums.ToListAsync();
        }

        public async Task<Album> Get(int id)
        {
            var album = await _context.Albums.FindAsync(id);
            
            return album;
        }

        public async Task Update(Album album)
        {
            _context.Entry(album).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Insert(Album album)
        {
            _context.Albums.Add(album);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Album album)
        {
            _context.Albums.Remove(album);
            await _context.SaveChangesAsync();
        }
    }
}
