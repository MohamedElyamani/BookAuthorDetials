
using BookAuthorDetials.Authors;
using BookAuthorDetials.Books;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace BookAuthorDetials.Books
{
    public class BookAppService :
     CrudAppService<
         Book, //The Book entity
         BookDto, //Used to show books
         Guid, //Primary key of the book entity
         PagedAndSortedResultRequestDto, //Used for paging/sorting
         CreateUpdateBookDto>, //Used to create/update a book
     IBookAppService //implement the IBookAppService
    {
        private readonly IRepository<Author, Guid> _authorRepository;
        public BookAppService(IRepository<Book, Guid> repository, IRepository<Author, Guid> authorRepository)
            : base(repository)
        {
            _authorRepository = authorRepository;
        }
        
        public async Task<PagedResultDto<BookDto>> GetBookByAuthoIdAsync(Guid authoId)
        {
            var queryable = await Repository.GetQueryableAsync();

            //Prepare a query to join books and authors
            var query = from book in queryable
                        join author in await _authorRepository.GetQueryableAsync() on book.AuthorId equals author.Id
                        select new { book, author };

            //Execute the query and get a list
            var queryResult = await AsyncExecuter.ToListAsync(query);
            var bookAuthorDtos = queryResult.Select(b =>
            {
                var bookAuthorDto = ObjectMapper.Map<Book, BookDto>(b.book);
                bookAuthorDto.AuthorName = b.author.AuthorName;
                return bookAuthorDto;
            }).ToList();

            var totalCount = bookAuthorDtos.Count; // await _addTypeRepository.GetCountAsync();

            return new PagedResultDto<BookDto>(
                totalCount,
                bookAuthorDtos
            );
        }

    }
}
