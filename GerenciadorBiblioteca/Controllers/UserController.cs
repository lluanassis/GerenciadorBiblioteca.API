using System.Reflection;
using GerenciadorBiblioteca.API.Entities;
using GerenciadorBiblioteca.API.Models;
using GerenciadorBiblioteca.API.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorBiblioteca.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly GerenciadorBibliotecaDbContext _context;
        public UserController(GerenciadorBibliotecaDbContext context)
        {
            _context = context;
        }

        //POST api/users/
        [HttpPost]
        public IActionResult Post(CreateUserInputModel model)
        {
            var user = new User(model.Nome, model.Email);

            _context.Users.Add(user);
            _context.SaveChanges();

            return Ok();
        }


        ////GET api/users/return
        //[HttpGet]
        //public IActionResult GetAll()
        //{

        //    var user = _context.Loans
        //        .Where(p => !p.IsDeleted).ToList();

        //    var model = user.Select(UserViewModel.FromEntity)
        //                     .ToList();

        //    return Ok(model);
        //}
    }
}
