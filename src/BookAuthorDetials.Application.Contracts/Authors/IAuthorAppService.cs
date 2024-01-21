using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace BookAuthorDetials.Authors
{
    public interface IAuthorAppService :
         ICrudAppService< //Defines CRUD methods
          AuthorDto, //Used to show books
          Guid, //Primary key of the book entity
          PagedAndSortedResultRequestDto, //Used for paging/sorting
          CreateUpdateAuthorDto> //Used to create/update a book
    {

    }
}
