using GerenciadorBiblioteca.Core.Entities;

namespace GerenciadorBiblioteca.API.Models
{
    public class CreateLoanModel
    {
        public int IdUsuario { get; set; }
        public int IdLivro { get; set; }
        public DateTime DataEmprestimo { get; set; }


        public Loan ToEntity() => new(IdUsuario, IdLivro, DataEmprestimo);
    }
}
