using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BackendTest.Books.Repository
{
    public class BookRepository : IBookRepository
    {

        private string texto = File.ReadAllText(@"D:\EntrevistaTeste MilTec\WebApplication3\WebApplication3\Books\books.json");

        public async Task<IEnumerable<Book>> ObterTodosLivrosAsync()
        {

            var biblioteca = JsonConvert.DeserializeObject<List<Book>>(texto);

            return biblioteca;

        }


        public async Task<List<string>> ObterNomesAsync(string nome)
        {

            var biblioteca = JsonConvert.DeserializeObject<List<Book>>(texto);

            List<string> livros = new List<string>();

            foreach (Book livro in biblioteca)
            {

                if (livro.Name.Contains(nome))
                {
                    livros.Add(livro.Name);
                    return livros;
                }
            }

            livros.Add("Livro não encontrado");
            return livros;

        }

        public async Task<List<string>> ObterAutorAsync(string author)
        {

            var biblioteca = JsonConvert.DeserializeObject<List<Book>>(texto);
            //var a =  biblioteca.FindAll(c => c.specifications.Author);

            List<string> autores = new List<string>();

            foreach (Book livro in biblioteca)
            {
                if (livro.specifications.Author.Contains(author))
                {
                    autores.Add(livro.specifications.Author);
                    return autores;
                }
            }
            autores.Add("Autor não encontrado");
            return autores;

        }
        public async Task<List<string>> BuscaTotal(string texto)
        {

            var biblioteca = JsonConvert.DeserializeObject<List<Book>>(texto);

            biblioteca.Contains(texto);
            
            
            
            
            
            //List<string> ListaGeneros = new List<string>();

            //foreach (Book livro in biblioteca)
            //{
            //    if (livro.specifications.Genres.)
            //    {
            //        var genero = ListaGeneros.Find(x => x.Contains(genres));
            //        return genero;
            //    }
            //    else
            //    {
            //        var genero = "Genero não encontrado";
            //        return genero;
            //    }
            //}


            //ListaGeneros.Add(livro.specifications.Genres.ToString());


        }



    }
}
