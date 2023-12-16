using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieSystem.Application.Feature.Movies.Commands.Models;
using MovieSystem.Application.Feature.Movies.Queries.Models;

namespace MovieSystem.WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        #region CTOR
        private readonly IMediator _mediator;

        public MoviesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        #endregion

        [HttpGet("GetAllMovies")]
        public async Task<IActionResult> GetAllMovies()
        {
            var result = await _mediator.Send(new GetMovieListQuery());
            return Ok(result);
        }

        [HttpGet("GetAllFreeMovies")]
        public async Task<IActionResult> GetAllFreeMovies()
        {
            var result = await _mediator.Send(new GetAllFreeMoviesQuery());
            return Ok(result);
        }

        [HttpGet("GetAllPaidMovies")]
        public async Task<IActionResult> GetAllPaidMovies()
        {
            var result = await _mediator.Send(new GetAllPaidMoviesQuery());
            return Ok(result);
        }

        [HttpGet("GetMovieById")]//{movieId}
        public async Task<IActionResult> GetMovieById([FromQuery] GetMovieByIdQuery query)
        {
            var result = await _mediator.Send(query);
            if (result == null)
            {
                // Handle not found
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost("AddMovie")]
        public async Task<IActionResult> AddMovie([FromForm] AddMovieCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut("UpdateMovie")]
        public async Task<IActionResult> UpdateMovie(UpdateMovieCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("RemoveMovie")]
        public async Task<IActionResult> RemoveMovie(DeleteMovieCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
