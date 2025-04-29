using GerenciadorBiblioteca.Application.Models;
using GerenciadorBiblioteca.Infrastructure.Persistence;

namespace GerenciadorBiblioteca.Application.Services
{
    public class BookService : IBookService
    {
        private readonly GerenciadorBibliotecaDbContext _context;

        public BookService(GerenciadorBibliotecaDbContext context)
        {
            _context = context;
        }

        public ResultViewModel Delete(int id)
        {

            var book = _context.Books
                .SingleOrDefault(p => p.Id == id);

            if (book is null)
            {
                return ResultViewModel.Error("Livro não existe");
            }

            book.SetAsDeleted();
            _context.Books.Update(book);
            _context.SaveChanges();

            return ResultViewModel.Success();
        }

        public ResultViewModel<List<BookViewModel>> GetAll()
        {
            var books = _context.Books
               .Where(p => !p.IsDeleted).ToList();

            var model = books.Select(BookViewModel.FromEntity)
                             .ToList();

            return ResultViewModel<List<BookViewModel>>.Success(model);
        }

        public ResultViewModel<BookViewModel> GetById(int id)
        {
            var book = _context.Books
                .Where(p => !p.IsDeleted)
                .SingleOrDefault(p => p.Id == id);

            if(book is null)
            {
                return ResultViewModel<BookViewModel>.Error("Livro não existe");
            }

            var model = BookViewModel.FromEntity(book);

            return ResultViewModel<BookViewModel>.Success(model);

        }

        public ResultViewModel<int> Post(CreateBookInputModel model)
        {
            var book = model.ToEntity();

            _context.Books.Add(book);
            _context.SaveChanges();

            return ResultViewModel<int>.Success(book.Id);

        }
    }
}
