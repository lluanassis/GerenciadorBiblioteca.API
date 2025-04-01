namespace GerenciadorBiblioteca.API.Entities
{
    public class Emprestimo
    {
        public Emprestimo(int idUsuario, int idLivro, DateTime? dataEmprestimo) : base()
        {
            IdUsuario = idUsuario;
            IdLivro = idLivro;
            DataEmprestimo = dataEmprestimo;
        }

        public int IdUsuario { get; private set; }
        public int IdLivro { get; private set; }
        public DateTime? DataEmprestimo { get; private set; }
    }
}
