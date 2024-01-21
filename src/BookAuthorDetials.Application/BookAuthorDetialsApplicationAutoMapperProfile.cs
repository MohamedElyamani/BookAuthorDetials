using AutoMapper;
using BookAuthorDetials.Authors;
using BookAuthorDetials.Books;

namespace BookAuthorDetials;

public class BookAuthorDetialsApplicationAutoMapperProfile : Profile
{
    public BookAuthorDetialsApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        CreateMap<Author, AuthorDto>();
        CreateMap<CreateUpdateAuthorDto, AuthorDto>();
    }
}
