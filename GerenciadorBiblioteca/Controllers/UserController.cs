using System.Reflection;
using GerenciadorBiblioteca.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorBiblioteca.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        //POST api/users/
        [HttpPost]
        public IActionResult Post(CreateUserInputModel user)
        {
            return Ok();
        }

    }
}
