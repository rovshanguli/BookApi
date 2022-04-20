using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Book
{
    public class BookCreateDto
    {
        [Required]
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int Page { get; set; }
        public int Price { get; set; }
    }
}
