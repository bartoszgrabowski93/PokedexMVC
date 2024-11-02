using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PokedexApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody] UserModel loginModel)
        {
            IActionResult response = Unauthorized();
            var success = AuthenticateUser(loginModel);

            if (success) 
            {
                var tokenString = GenerateJsonWebToken(loginModel);
                response = Ok(new { token =  tokenString });
            }
            return response;
        }

        private object GenerateJsonWebToken(UserModel loginModel)
        {
            throw new NotImplementedException();
        }

        private bool AuthenticateUser(object loginModel)
        {
            throw new NotImplementedException();
        }
    }
}
