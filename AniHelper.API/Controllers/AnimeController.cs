using AniHelper.Application.Commands;
using AniHelper.Application.Queries;
using AniHelper.Application.Responses;
using AniHelper.Core.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AniHelper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AnimeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IReadOnlyList<Anime>> Get()
        {
            return await _mediator.Send(new GetAllAnimeQuery());
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<AnimeResponse>> CreateAnime([FromBody] CreateAnimeCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
