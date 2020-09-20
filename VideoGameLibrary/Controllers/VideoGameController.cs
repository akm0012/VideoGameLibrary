using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VideoGameLibrary.Dto;
using VideoGameLibrary.Entities;

namespace VideoGameLibrary.Controllers
{
    [ApiController]
    [Route("VideoGame")]
    public class VideoGameController : ControllerBase
    {
        private static readonly VideoGame[] GameList = new VideoGame[]
        {
            new VideoGame()
            {
                Id = 1,
                Name = "The Legend of Zelda: Ocarina of Time",
                Description = "The Legend of Zelda: Ocarina of Time is an action-adventure game developed and published by Nintendo for the Nintendo 64. It was released in Japan and North America in November 1998, and in PAL regions the following month. Ocarina of Time is the fifth game in The Legend of Zelda series, and the first with 3D graphics. ",
                IsMultiPlayer = false,
                DateReleased = "November 21, 1998",
                DeveloperStudio = "Nintendo"
            }, 
            new VideoGame()
            {
                Id = 2,
                Name = "Cyberpunk 2077",
                Description = "Cyberpunk 2077 is an upcoming role-playing video game developed and published by CD Projekt. It is scheduled to be released for PlayStation 4, Windows, and Xbox One in November 2020, Stadia by the end of the year, and PlayStation 5 and Xbox Series X/S in 2021.",
                IsMultiPlayer = false,
                DateReleased = "November 19, 2020",
                DeveloperStudio = "CD Projekt"
            },
            new VideoGame()
            {
                Id = 3,
                Name = "The Elder Scrolls V: Skyrim",
                Description = "The Elder Scrolls V: Skyrim is an action role-playing video game developed by Bethesda Game Studios and published by Bethesda Softworks",
                IsMultiPlayer = false,
                DateReleased = "November 11, 2011",
                DeveloperStudio = "Bethesda Game Studios"
            },
            new VideoGame()
            {
                Id = 5,
                Name = "GoldenEye 007",
                Description = "GoldenEye 007 is a 1997 first-person shooter developed by Rare and published by Nintendo for the Nintendo 64.",
                IsMultiPlayer = true,
                DateReleased = "August 25, 1997",
                DeveloperStudio = "Rare"
            },
            new VideoGame()
            {
                Id = 7,
                Name = "Borderlands 2",
                Description = "Borderlands 2 is a 2012 first-person shooter video game developed by Gearbox Software and published by 2K Games. Taking place five years following the events of Borderlands, the game is once again set on the planet of Pandora.",
                IsMultiPlayer = true,
                DateReleased = "September 28, 2012",
                DeveloperStudio = "Gearbox Software"
            },
            new VideoGame()
            {
                Id = 11,
                Name = "Call of Duty 4: Modern Warfare",
                Description = "Call of Duty 4: Modern Warfare is a 2007 first-person shooter developed by Infinity Ward and published by Activision. It is the fourth main installment in the Call of Duty series. The game breaks away from the World War II setting of previous entries and is instead set in modern times. Developed for over two years, Modern Warfare was released in November 2007 for the PlayStation 3, Xbox 360, and Microsoft Windows, and was ported to the Nintendo Wii as Call of Duty: Modern Warfare – Reflex Edition in 2009.",
                IsMultiPlayer = true,
                DateReleased = "November 5, 2007",
                DeveloperStudio = "Activision"
            },
            new VideoGame()
            {
                Id = 13,
                Name = "Halo: Combat Evolved",
                Description = "Halo: Combat Evolved is a first-person shooter video game developed by Bungie and published by Microsoft Game Studios. It was released as a launch title for Microsoft's Xbox video game console on November 15, 2001.",
                IsMultiPlayer = true,
                DateReleased = "November 15, 2001",
                DeveloperStudio = "Microsoft"
            },
            new VideoGame()
            {
                Id = 17,
                Name = "Assassin's Creed IV: Black Flag",
                Description = "Assassin's Creed IV: Black Flag is an action-adventure video game developed by Ubisoft Montreal and published by Ubisoft. It is the sixth major installment in the Assassin's Creed series. Its historical timeframe precedes that of Assassin's Creed III, though its modern-day sequences succeed III's own.",
                IsMultiPlayer = false,
                DateReleased = "October 29, 2013",
                DeveloperStudio = "Ubisoft"
            },
            new VideoGame()
            {
                Id = 19,
                Name = "Red Dead Redemption",
                Description = "Red Dead Redemption is a 2010 action-adventure game developed by Rockstar San Diego and published by Rockstar Games. A spiritual successor to 2004's Red Dead Revolver, it is the second game in the Red Dead series.",
                IsMultiPlayer = false,
                DateReleased = "May 18, 2010",
                DeveloperStudio = "Rockstar"
            },
        };
        
        private static readonly Media[] MediaList = new Media[]
        {
            new Media()
            {
                MediaId = 100,
                GameId = 1,
                GamePosterUrl = "https://m.media-amazon.com/images/M/MV5BZjc3MmMzNGItYmEzYy00MWFhLWI0NDQtMWE3Y2Q1NjE1OWRlXkEyXkFqcGdeQXVyNzcyMjAwNTE@._V1_.jpg",
                GameTrailerUrl = "https://www.youtube.com/watch?v=_NElFLzgdUs"
            }, 
            new Media()
            {
                MediaId = 200,
                GameId = 2,
                GamePosterUrl = "https://preview.redd.it/7ykufzphewl31.jpg?width=960&crop=smart&auto=webp&s=3930c1cdcf4cff6d9d9d9c069b1ba537c73f84c4",
                GameTrailerUrl = "https://www.youtube.com/watch?v=ixl31324UxE"
            },
            new Media()
            {
                MediaId = 300,
                GameId = 3,
                GamePosterUrl = "https://vignette.wikia.nocookie.net/elderscrolls/images/c/c5/Skyrim_Cover.png/revision/latest?cb=20160812173034",
                GameTrailerUrl = "https://www.youtube.com/watch?v=JSRtYpNRoN0"
            },
            new Media()
            {
                MediaId = 500,
                GameId = 5,
                GamePosterUrl = "https://upload.wikimedia.org/wikipedia/en/3/36/GoldenEye007box.jpg",
                GameTrailerUrl = "https://www.youtube.com/watch?v=1DzOlX9OLyo"
            },
            new Media()
            {
                MediaId = 700,
                GameId = 7,
                GamePosterUrl = "https://upload.wikimedia.org/wikipedia/en/5/51/Borderlands_2_cover_art.png",
                GameTrailerUrl = "https://www.youtube.com/watch?v=ERe3wZdIAtc&has_verified=1"
            },
            new Media()
            {
                MediaId = 1100,
                GameId = 11,
                GamePosterUrl = "https://upload.wikimedia.org/wikipedia/en/5/5f/Call_of_Duty_4_Modern_Warfare.jpg",
                GameTrailerUrl = "https://www.youtube.com/watch?v=LhuIjNSg7Gg"
            },
            new Media()
            {
                MediaId = 1300,
                GameId = 13,
                GamePosterUrl = "https://e.snmc.io/lk/l/x/abf51eee33cd25050e7b3e1bed53c2a8/6678707",
                GameTrailerUrl = "https://www.youtube.com/watch?v=-4ZUvPfi1bM"
            },
            new Media()
            {
                MediaId = 1700,
                GameId = 17,
                GamePosterUrl = "https://images-na.ssl-images-amazon.com/images/I/91fWpsupeUL.jpg",
                GameTrailerUrl = "https://www.youtube.com/watch?v=fzIwI6O03LI"
            },
            new Media()
            {
                MediaId = 1900,
                GameId = 19,
                GamePosterUrl = "https://m.media-amazon.com/images/M/MV5BZmYwNjk3OWMtODk2Yi00MjA3LTgzYzctODk1NmRhM2M4ZDVjXkEyXkFqcGdeQXVyNjgzMTIxNzE@._V1_.jpg",
                GameTrailerUrl = "https://www.youtube.com/watch?v=PD24MkbHQrc"
            },
        };

        private readonly ILogger<VideoGameController> _logger;

        public VideoGameController(ILogger<VideoGameController> logger)
        {
            _logger = logger;
        }

        [HttpGet("ids")]
        public async Task<ActionResult<IEnumerable<VideoGame>>> Get()
        {
            var ids = GameList.Select(videoGame => videoGame.Id).ToList();
            var gameIds = new IdListDto()
            {
                gameIds = ids
            };
            
            return Ok(gameIds);
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<VideoGame>> GetGame(int id)
        {
            var targetGame = GameList.FirstOrDefault(videoGame => videoGame.Id == id);
            if (targetGame == null)
            {
                return NotFound();
            }
            return Ok(targetGame);
        }
        
        [HttpGet("media/{gameId}")]
        public async Task<ActionResult<Media>> GetGameMedia(int gameId)
        {
            var targetMedia = MediaList.FirstOrDefault(media => media.GameId == gameId);
            if (targetMedia == null)
            {
                return NotFound();
            }
            return Ok(targetMedia);
        }
    }
}