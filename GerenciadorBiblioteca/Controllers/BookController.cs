using System.Reflection;
using GerenciadorBiblioteca.API.Models;
using GerenciadorBiblioteca.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorBiblioteca.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BookController : ControllerBase
    {
        private readonly IConfigService _configuration;

        public BookController(IConfigService configuration)
        {
            _configuration = configuration;
        }

        //POST api/books
        [HttpPost]
        public IActionResult Post(CreateBookInputModel model)
        {
            return Ok();
        }

        //GET api/books
        [HttpGet]
        public IActionResult GetAll()
        {
            throw new Exception();
            return Ok();
        }

        //GET api/books/1234
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        //DELETE api/books/1234
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }




    }
}
