namespace GerenciadorBiblioteca.Application.Models
{
    public class CreateLoanInputModel
    {
        public int IdUsuario { get; set; }
        public int IdLivro { get; set; }
        public DateTime DataEmprestimo { get; set; }
    }
}
