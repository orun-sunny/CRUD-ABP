using Acme.Bookshop.Books;
using AutoMapper;

namespace Acme.Bookshop;

public class BookshopApplicationAutoMapperProfile : Profile
{
    public BookshopApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
