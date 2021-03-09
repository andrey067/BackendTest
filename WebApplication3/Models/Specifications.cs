using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackendTest.Books
{
    public class Specifications
    {
        [JsonProperty("Originally published")]
        public string Originallypublished { get; private set; }

        [JsonProperty("Author")]
        public string Author { get; private set; }


        [JsonProperty("Page count")]
        public int Pagecount { get; private set; }


        [JsonProperty("Illustrator")]
        public object Illustrator { get; private set; }


        [JsonProperty("Genres")]
        public object Genres { get; private set; }

    }
}
