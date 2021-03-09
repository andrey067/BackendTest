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
        public List<Book> Getlivros()
        {

            return  _bookRepository.BuscarLivros();

        }

        //[HttpGet("GetById/{id}")]
        //public async Task<IEnumerable<Book>> GetNomeLivros(int id)
        //{
        //    var biblioteca = await _bookRepository.ObterTodosLivrosAsync();

        //    return biblioteca.Where(x=> x.Id == id);
        //}

        //[HttpGet("GetByNome/{nome}")]
        //public async Task<IEnumerable<string>> GetNomeLivros(string nome)
        //{

           
        //    var biblioteca = await _bookRepository.ObterNomesAsync(nome);

        //    return biblioteca;
        //}

        //[HttpGet("GetByAutor/{author}")]
        //public async Task<IEnumerable<string>> GetAutorLivros(string author)
        //{

           
        //    var biblioteca = await _bookRepository.ObterAutorAsync(author);

        //    return biblioteca;
        //}


        //[HttpGet("GetbyBuscaTotal/{texto}")]
        //public async Task<string> GetGeneroLivros(string texto)
        //{


        //    var biblioteca = await _bookRepository.BuscaTotal(texto);

        //    return biblioteca;
        //}



    }
}
