using System.Collections.Generic;
using System.Threading.Tasks;

namespace MusicStore.Domain
{
    public interface IAlbumService
    {
        Task<IEnumerable<Album>> GetAll();

        Task<Album> Get(int id);

        Task Update(Album album);

        Task Insert(Album album);

        Task Delete(Album album);
    }
}