using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace BookAuthorDetials.Authors
{
    public class Author : FullAuditedAggregateRoot<Guid>
    {

        public string AuthorName { get; set; }
        public int NationalityId { get; set; }
    }
}
