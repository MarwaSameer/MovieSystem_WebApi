using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieSystem.Application.Feature.UserSubsss.Commands.Models;

namespace MovieSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserSubscriptionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserSubscriptionController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("GetAllUserSubscriptions")]
        public async Task<IActionResult> GetAllUserSubscriptions()
        {
            var result = await _mediator.Send(new Application.Feature.UserSubsss.Queries.Models.GetUserSubscriptionListQuery());
            return Ok(result);
        }

        [HttpGet("GetUserSubscriptionById")]//{LikeId}
        public async Task<IActionResult> GetUserSubscriptionById([FromQuery] Application.Feature.UserSubsss.Queries.Models.GetUserSubscriptionByIdQuery query)
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
        public async Task<IActionResult> AddUserSubscription(AddUserSubscriptionCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUserSubscription(UpdateUserSubscriptionCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveUserSubscription(DeleteUserSubscriptionCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

    }
}
