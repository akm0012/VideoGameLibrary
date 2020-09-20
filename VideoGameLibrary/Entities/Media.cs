using System.ComponentModel.DataAnnotations;

namespace VideoGameLibrary.Entities
{
    public class Media
    {
        [Key]
        public int MediaId { get; set; }

        public int GameId { get; set; }
        
        public string GamePosterUrl { get; set; }
        
        public string GameTrailerUrl { get; set; }
    }
}