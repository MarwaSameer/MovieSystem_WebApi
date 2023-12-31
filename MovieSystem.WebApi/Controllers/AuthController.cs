﻿using Microsoft.AspNetCore.Mvc;
using MoviesSystem.Domain.Entities.Identity;
using MovieSystem.Application.DTOs.Authentication;
using MovieSystem.Application.IServices;

namespace MovieSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        #region CTOR



        private ResponseDto _response;
        private readonly IAuthService _authService;



        public AuthController(IAuthService _authService)
        {



            _response = new ResponseDto();
            this._authService = _authService;
        }
        #endregion
        [HttpPost]
        [Route("seed-roles")]
        public async Task<IActionResult> SeedRoles()
        {
            var seerRoles = await _authService.SeedRolesAsync();

            return Ok(seerRoles);
        }


        // Route -> Register
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.RegisterAsync(model);

            if (!result.IsAuthenticated)
                return BadRequest(result.Message);

            return Ok(result);
        }


        // Route -> Login
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.LoginAsync(model);

            if (!result.IsAuthenticated)
                return BadRequest(result.Message);

            return Ok(result);
        }

        [HttpGet]
        [Route("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.GetAllUsersAsync();



            return Ok(result);
        }
        [HttpDelete]
        [Route("DeleteUser/Id")]
        public async Task<IActionResult> DeleteUser([FromRoute] string Id)
        {


            await _authService.DeleteUserAsync(Id);



            return Ok();
        }

        [HttpGet]
        [Route("GetUserById")]
        public async Task<IActionResult> GetUserById([FromQuery] string Id)
        {


            var result = await _authService.GetUserByIdAsync(Id);



            return Ok(result);
        }
        [HttpPut]
        [Route("UpdateUser")]
        public async Task<IActionResult> UpdateUser([FromBody] User model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.UpdateUserAsync(model);



            return Ok(result);
        }


    }
}
