using AutoMapper;
using DomainLayer.Entities;
using ServiceLayer.DTOs.Book;


namespace ServiceLayer.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookListDto>().ReverseMap();
            CreateMap<BookCreateDto, Book>().ReverseMap();
            
        }
    }
}
