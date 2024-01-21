using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace BookAuthorDetials.Books
{
    public class Book : AuditedAggregateRoot<Guid>
    {
        
        public string BookName { get; set; }
        public BookType BookType { get; set; } 
        public Guid AuthorId { get; set; } 
    }
}
