using System.ComponentModel.DataAnnotations.Schema;

namespace MusicStore.Domain
{
    [Table("Album")]
    public class Album
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ArtistName { get; set; }

        public AlbumType Type { get; set; }

        public int Stock { get; set; }
    }

    public enum AlbumType
    {
        CD,
        Vinyl
    }
}