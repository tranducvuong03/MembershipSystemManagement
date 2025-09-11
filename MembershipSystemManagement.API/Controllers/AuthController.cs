using MembershipSystemManagement.Repository.Entities;
using MembershipSystemManagement.Repository.IUow;
using MembershipSystemManagement.Service.Models.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MembershipSystemManagement.API.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        public AuthController(IUnitOfWork unitOfWork)
        {
        }

        /*[HttpPost("social-login")]
        public async Task<IActionResult> SocialLogin([FromBody] SocialLoginRequest request)
        {

        }*/
    }
}
