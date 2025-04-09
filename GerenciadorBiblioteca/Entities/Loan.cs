namespace GerenciadorBiblioteca.API.Entities
{
    public class Loan : BaseEntity
    {
        public Loan(int idUsuario, int idLivro, DateTime? dataEmprestimo) : base()
        {
            IdUsuario = idUsuario;
            IdLivro = idLivro;
            DataEmprestimo = dataEmprestimo;
        }

        public int IdUsuario { get; private set; }
        public int IdLivro { get; private set; }
        public DateTime? DataEmprestimo { get; private set; }

        public User Usuario { get; private set; }
        public Book Livro { get; private set; }
    }
}
