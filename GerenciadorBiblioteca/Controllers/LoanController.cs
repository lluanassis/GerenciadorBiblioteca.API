using System.Reflection;
using GerenciadorBiblioteca.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorBiblioteca.Controllers
{
    [ApiController]
    [Route("api/loans")]
    public class LoanController : ControllerBase
    {
        //POST api/loans/
        [HttpPost]
        public IActionResult Post(CreateLoanModel loan)
        {
            return Ok();
        }

        //POST api/loans/return
        [HttpPost("return")]
        public IActionResult Return(ReturnBookLoanModel loan)
        {
            return Ok();
        }




    }
}
