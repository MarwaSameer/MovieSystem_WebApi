using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieSystem.Application.Feature.Rates.Commands.Models;
using MovieSystem.Application.Feature.Rates.Queries.Models;

namespace MovieSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatesController : ControllerBase
    {

        private readonly IMediator _mediator;

        public RatesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetAllRates")]
        public async Task<IActionResult> GetAllRates()
        {
            var result = await _mediator.Send(new GetRateListQuery());
            return Ok(result);
        }
        [HttpGet("GetRatesByMovieId")]
        public async Task<IActionResult> GetRatesByMovieId([FromQuery] GetRatesByMovieIdQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("GetRatesByUserId")]
        public async Task<IActionResult> GetRatesByUserId([FromQuery] GetRatesByUserIdQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("GetRateByUserAndMovieIds")]
        public async Task<IActionResult> GetRateByUserAndMovieIds([FromQuery] GetRateByUserAndMovieIdsQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("GetRateById")]//{movieId}
        public async Task<IActionResult> GetRateById([FromQuery] GetRateByIdQuery query)
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
        public async Task<IActionResult> AddRate(AddRateCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRate(UpdateRateCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteRate(DeleteRateCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
