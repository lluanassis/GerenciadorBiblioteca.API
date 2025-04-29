using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorBiblioteca.Application.Models;
using GerenciadorBiblioteca.Core.Entities;

namespace GerenciadorBiblioteca.Application.Services
{
    public interface IBookService
    {
        ResultViewModel<int> Post(CreateBookInputModel model);
        ResultViewModel<List<BookViewModel>> GetAll();
        ResultViewModel<BookViewModel> GetById(int id);
        ResultViewModel Delete(int id);

    }
}
