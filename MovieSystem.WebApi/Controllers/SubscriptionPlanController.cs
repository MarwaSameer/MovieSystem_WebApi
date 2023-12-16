using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieSystem.Application.Feature.UserSubsss.Commands.Models;
using MovieSystem.Application.Feature.UserSubsss.Queries.Models;

namespace MovieSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionPlanController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SubscriptionPlanController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("GetAllSubscriptionPlans")]
        public async Task<IActionResult> GetAllSubscriptionPlans()
        {
            var result = await _mediator.Send(new GetUserSubscriptionListQuery());
            return Ok(result);
        }

        [HttpGet("GetSubscriptionPlanById")]//{LikeId}
        public async Task<IActionResult> GetSubscriptionPlanById([FromQuery] GetUserSubscriptionByIdQuery query)
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
        public async Task<IActionResult> AddSubscriptionPlan(AddUserSubscriptionCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSubscriptionPlan(UpdateUserSubscriptionCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveSubscriptionPlan(DeleteUserSubscriptionCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

    }
}
