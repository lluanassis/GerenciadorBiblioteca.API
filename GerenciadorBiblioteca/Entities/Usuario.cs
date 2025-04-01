namespace GerenciadorBiblioteca.API.Entities
{
    public class Usuario : BaseEntity
    {
        public Usuario(string nome, string email) : base()
        {
            Nome = nome;
            Email = email;
        }

        public string Nome { get; private set; }
        public string Email { get; private set; }
    }
}
