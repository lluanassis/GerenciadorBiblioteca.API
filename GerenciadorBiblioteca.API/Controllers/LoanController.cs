using System.Reflection;
using GerenciadorBiblioteca.API.Models;
using GerenciadorBiblioteca.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorBiblioteca.Controllers
{
    [ApiController]
    [Route("api/loans")]
    public class LoanController : ControllerBase
    {
        private readonly GerenciadorBibliotecaDbContext _context;
        public LoanController(GerenciadorBibliotecaDbContext context)
        {
            _context = context;
        }
        //POST api/loans/
        [HttpPost]
        public IActionResult Post(CreateLoanModel model)
        {
            var loan = model.ToEntity();

            _context.Loans.Add(loan);
            _context.SaveChanges();

            return Ok();
        }

        //GET api/loans/return
        [HttpGet("return")]
        public IActionResult GetAll()
        {

            var loan = _context.Loans
                .Where(p => !p.IsDeleted).ToList();

            var model = loan.Select(LoanViewModel.FromEntity)
                             .ToList();

            return Ok(model);
        }




    }
}
