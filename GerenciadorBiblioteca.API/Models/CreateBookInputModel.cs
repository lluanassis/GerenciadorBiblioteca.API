using GerenciadorBiblioteca.Core.Entities;

namespace GerenciadorBiblioteca.API.Models
{
    public class CreateBookInputModel
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int AnoPublicacao { get; set; }

        public Book ToEntity() => new(Titulo, Autor, ISBN, AnoPublicacao); 
    }
}
