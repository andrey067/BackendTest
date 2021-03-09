using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendTest.Books;
using BackendTest.Books.Repository;

namespace BackendTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BibliotecaController : ControllerBase
    {
        private readonly ILogger<BibliotecaController> _logger;
        private readonly IBookRepository _bookRepository;

        public BibliotecaController(ILogger<BibliotecaController> logger, IBookRepository bookRepository)
        {
            _logger = logger;
            _bookRepository = bookRepository;
           
        }
        // GET:
        [HttpGet]
        public  IEnumerable<Book> Getlivros()
        {

            return  _bookRepository.ObterTodosLivrosAsync();

        }

        [HttpGet("GetById/{id}")]
        public  IEnumerable<Book> GetNomeLivros(int id)
        {
            var biblioteca = _bookRepository.ObterTodosLivrosAsync();

            return biblioteca.Where(x=> x.Id == id);
        }

        [HttpGet("GetByNome/{nome}")]
        public  IEnumerable<string> GetNomeLivros(string nome)
        {

           
            var biblioteca = _bookRepository.ObterNomesAsync(nome);

            return biblioteca;
        }

        [HttpGet("GetByAutor/{author}")]
        public  IEnumerable<string> GetAutorLivros(string author)
        {

           
            var biblioteca = _bookRepository.ObterAutorAsync(author);

            return biblioteca;
        }


        [HttpGet("GetbyBuscaTotal/{genres}")]
        public  List<string> GetGeneroLivros(string genres)
        {


            var biblioteca = _bookRepository.BuscaTotal(genres);

            return biblioteca;
        }



    }
}
