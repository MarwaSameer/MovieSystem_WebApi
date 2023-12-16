using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieSystem.Application.Feature.Categories.Commands.Models;
using MovieSystem.Application.Feature.Categories.Queries.Models;

namespace MovieSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("GetAllCategories")]
        public async Task<IActionResult> GetAllCategories()
        {
            var result = await _mediator.Send(new GetCategoryListQuery());
            return Ok(result);
        }

        [HttpGet("GetCategoryById")]//{movieId}
        public async Task<IActionResult> GetCategoryById([FromQuery] GetCategoryByIdQuery query)
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
        public async Task<IActionResult> AddCategory(AddCategoryCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(DeleteCategoryCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
