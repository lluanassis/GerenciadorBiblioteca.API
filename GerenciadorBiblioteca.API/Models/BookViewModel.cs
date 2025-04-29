using GerenciadorBiblioteca.Core.Entities;

namespace GerenciadorBiblioteca.API.Models
{
    public class BookViewModel
    {
        public BookViewModel(int id, string titulo, string autor, string iSBN, int anoPublicacao)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            ISBN = iSBN;
            AnoPublicacao = anoPublicacao;
        }

        public int Id { get; private set; }
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public string ISBN { get; private set; }
        public int AnoPublicacao { get; private set; }

        public static BookViewModel FromEntity(Book book)
            => new(book.Id, book.Titulo, book.Autor, book.ISBN, book.AnoPublicacao);
    }
}
