using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace BookAuthorDetials.Books
{
    public  class BookDto : AuditedEntityDto<Guid>
    {
        public string BookName { get; set; }
        public BookType BookType { get; set; }
        public Guid AuthorId { get; set; }
        public string AuthorName { get; set; }
    }
}
