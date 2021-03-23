﻿using dio_coruse_api.Controllers.Models.Users;
using Microsoft.AspNetCore.Mvc;

namespace dio_coruse_api.Controllers
{
    [Route("api/v1/user")]
    [ApiController]
    
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        public IActionResult Login(LoginViewModelInput loginViewModelInput)
        {
            return Ok(loginViewModelInput);
        }
        
        [HttpPost]
        [Route("register")]
        public IActionResult Register(RegisterViewModelInput 
            registerViewModelInput)
        {
            return Created("",registerViewModelInput);
        }
    }
}