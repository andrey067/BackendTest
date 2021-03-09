using BackendTest.Books;
using BackendTestMilTec.Repository;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;


namespace WebApplication3.DataBase
{
    public class JsonFile : IJsonFile
    {

        public List<Book> Query()
        {
            var caminho = File.ReadAllText(@"./DataBase/books.json");
            var jsonBook = JsonConvert.DeserializeObject<List<Book>>(caminho);

            return jsonBook;
        }


    }
}
