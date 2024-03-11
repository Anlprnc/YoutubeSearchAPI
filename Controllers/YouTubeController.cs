using Microsoft.AspNetCore.Mvc;
using YoutubeAPI.Core.IServices;

namespace YoutubeAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class YouTubeController : ControllerBase
    {
        private readonly IYoutubeClientService _youtubeClientService;

        public YouTubeController(IYoutubeClientService youtubeClientService)
        {
            _youtubeClientService = youtubeClientService;
        }

        [HttpGet]
        [Route("search")]
        public async Task<IActionResult> Search([FromQuery] string q, [FromQuery] int maxResult = 50)
        {
            var result = await _youtubeClientService.SearchAsync(q, maxResult);
            return Ok(result);
        }

        [HttpGet]
        [Route("channel({id})")]
        public async Task<IActionResult> SearchChannel([FromRoute] string id, [FromQuery] int maxResult = 50)
        {
            var result = await _youtubeClientService.SearchChannelAsync(id, maxResult);
            return Ok(result);
        }
    }
}