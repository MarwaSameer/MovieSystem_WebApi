using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieSystem.Application.Feature.Categories.Commands.Models;
using MovieSystem.Application.Feature.Likes.Commands.Models;
using MovieSystem.Application.Feature.Likes.Queries.Models;

namespace MovieSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikesController : ControllerBase
    {
        #region CTOR
        private readonly IMediator _mediator;

        public LikesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        #endregion

        [HttpGet("GetAllLikes")]
        public async Task<IActionResult> GetAllLikes()
        {
            var result = await _mediator.Send(new GetLikeListQuery());
            return Ok(result);
        }

        [HttpGet("GetLikeById")]//{LikeId}
        public async Task<IActionResult> GetLikeById([FromQuery] GetLikeByIdQuery query)
        {
            var result = await _mediator.Send(query);
            if (result == null)
            {
                // Handle not found
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddLike(AddLikeCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateLike(UpdateLikeCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveLike(DeleteLikeCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }


        [HttpGet("GetLikesByMovieId")]//{LikeId}
        public async Task<IActionResult> GetLikesByMovieId([FromQuery] GetLikesByMovieIdQuery query)
        {
            var result = await _mediator.Send(query);
            if (result == null)
            {
                // Handle not found
                return NotFound();
            }
            return Ok(result);
        }



        [HttpGet("GetLikesByUserId")]//{LikeId}
        public async Task<IActionResult> GetLikesByUserId([FromQuery] GetLikesByUserIdQuery query)
        {
            var result = await _mediator.Send(query);
            if (result == null)
            {
                // Handle not found
                return NotFound();
            }
            return Ok(result);
        }



        [HttpGet("GetLikeByUserAndMovieIds")]//{LikeId}
        public async Task<IActionResult> GetLikeByUserAndMovieIds([FromQuery] GetLikeByUserAndMovieIdsQuery query)
        {
            var result = await _mediator.Send(query);
            if (result == null)
            {
                // Handle not found
                return NotFound();
            }
            return Ok(result);
        }




    }
}
