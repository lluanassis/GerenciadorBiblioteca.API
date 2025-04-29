
using GerenciadorBiblioteca.Core.Entities;

namespace GerenciadorBiblioteca.API.Models
{
    public class LoanViewModel
    {
        public LoanViewModel(int id, int idUsuario, int idLivro, DateTime? dataEmprestimo)
        {
            Id = id;
            IdUsuario = idUsuario;
            IdLivro = idLivro;
            DataEmprestimo = dataEmprestimo;
        }

        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdLivro { get; set; }
        public DateTime? DataEmprestimo { get; set; }

        public static LoanViewModel FromEntity(Loan loan) 
            => new(loan.Id, loan.IdUsuario, loan.IdLivro, loan.DataEmprestimo);
    }
}
