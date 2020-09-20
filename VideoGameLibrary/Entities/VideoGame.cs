using System.ComponentModel.DataAnnotations;

namespace VideoGameLibrary.Entities
{
    public class VideoGame
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public bool IsMultiPlayer { get; set; }
        
        public string DateReleased { get; set; }

        public string DeveloperStudio { get; set; }
    }
}