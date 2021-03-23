using dio_coruse_api.Controllers.Models.Users;
using dio_coruse_api.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace dio_coruse_api.Controllers
{
    [Route("api/v1/user")]
    [ApiController]
    
    public class UserController : ControllerBase
    {
        /// <summary>
        /// This service allows to authenticate a user registered and active
        /// </summary>
        /// <param name="loginViewModelInput">Login view model</param>
        /// <returns>Return Ok status, user data and token</returns>
        
        [SwaggerResponse(statusCode:200,
            description:"Authentication successful",
            Type = typeof(LoginViewModelInput))]
        
        [SwaggerResponse(statusCode:400,
            description:"Mandatory fields must be filled",
            Type = typeof(ValidateFieldViewModelOutput))]
        
        [SwaggerResponse(statusCode:500,
            description:"Internal error",
            Type = typeof(GenericErrorViewModel))]
        
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