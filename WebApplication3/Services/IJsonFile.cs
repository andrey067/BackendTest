using BackendTest.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendTestMilTec.Repository
{
    public interface IJsonFile
    {
        List<Book> Query();

    }
}
