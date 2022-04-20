using ServicesLayer.DTOs.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interface
{
    interface IBookService
    {
        public interface IBookService
        {
            Task<List<BookListDto>> GetAllAsync();
        }
    }
}
