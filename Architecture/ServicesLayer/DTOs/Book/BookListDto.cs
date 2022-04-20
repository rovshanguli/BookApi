using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.DTOs.Book
{
    class BookListDto
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int Page { get; set; }
    }
}
