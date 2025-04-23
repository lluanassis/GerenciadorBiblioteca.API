using System.Reflection;
using GerenciadorBiblioteca.API.Models;
using GerenciadorBiblioteca.API.Persistence;
using GerenciadorBiblioteca.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorBiblioteca.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BookController : ControllerBase
    {
        private readonly GerenciadorBibliotecaDbContext _context;

        public BookController(GerenciadorBibliotecaDbContext context)
        {
            _context = context;
        }

        //POST api/books
        [HttpPost]
        public IActionResult Post(CreateBookInputModel model)
        {
            var book = model.ToEntity();

            _context.Books.Add(book);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new {id = 1}, model);
        }

        //GET api/books
        [HttpGet]
        public IActionResult GetAll()
        {
            var books = _context.Books
                .Where(p => !p.IsDeleted).ToList();

            var model = books.Select(BookViewModel.FromEntity)
                             .ToList();

            return Ok(model);
        }

        //GET api/books/1234
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var book = _context.Books
                .Where(p => !p.IsDeleted)
                .SingleOrDefault(p=> p.Id == id);

            var model = BookViewModel.FromEntity(book);

            return Ok(model);
        }

        //DELETE api/books/1234
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book = _context.Books
                .SingleOrDefault(p => p.Id == id);

            if(book is null)
            {
                return NotFound();
            }

            book.SetAsDeleted();
            //context.Books.Update(project);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
