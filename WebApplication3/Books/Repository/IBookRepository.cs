using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendTest.Books.Repository
{
    public interface IBookRepository
    {

        Task<IEnumerable<Book>> ObterTodosLivrosAsync();

        Task<List<string>> ObterNomesAsync(string nome);

        Task<List<string>> ObterAutorAsync(string author);


        Task<List<string>> BuscaTotal(string genres);

    }
}
