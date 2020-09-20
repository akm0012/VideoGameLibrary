using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
                Id = 1
            }, 
            new VideoGame()
            {
                Id = 2
            }, 
        };
        
        private static readonly Media[] MediaList = new Media[]
        {
            new Media()
            {
                MediaId = 100,
                GameId = 1,
            }, 
            new Media()
            {
                MediaId = 200,
                GameId = 2,
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
            return Ok(ids);
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