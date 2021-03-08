using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BackendTest.Books
{
    public class  Book
    {

        [JsonProperty("id")]
        public int Id { get;  private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("price")]
        public double Price { get; private set; }

        [JsonProperty("specifications")]
        public Specifications specifications { get; private set; }

        //public string  Request()
        //{
        //    string texto = File.ReadAllText(@"C:\Users\andre\Google Drive (andr3y.lim1@g7suite.me)\Projetos_teste\TesteJson\TesteJson\Books\books.json");
        //    return texto;
        //}


        //public Program buscaPorID(int id)
        //{

        //    var book = new Book();
        //    book.TodosOsLivros();

        //    book.Id.Equals



        //    return
        // }



    }
}
