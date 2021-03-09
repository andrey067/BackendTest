using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendTest.Books.Repository
{
    public interface IBookRepository
    {

        IEnumerable<Book> ObterTodosLivrosAsync();

        List<string> ObterNomesAsync(string nome);

        List<string> ObterAutorAsync(string author);


        List<string> BuscaTotal(string genres);

    }
}
