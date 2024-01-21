using AutoMapper;
using BookAuthorDetials.Books;
using static BookAuthorDetials.Web.Pages.BookAndAuhtorDet.CreateModelModel;

namespace BookAuthorDetials.Web;

public class BookAuthorDetialsWebAutoMapperProfile : Profile
{
    public BookAuthorDetialsWebAutoMapperProfile()
    {
        //Define your object mappings here, for the Web project
        CreateMap<CreateUpdateBookViewMode, CreateUpdateBookDto>();
    }
}
