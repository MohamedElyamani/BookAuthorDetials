using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities.Auditing;

namespace BookAuthorDetials.Authors
{
    public class AuthorDto : EntityDto<Guid>
    {
        public string AuthorName { get; set; }
        public int NationalityId { get; set; }
    }
}
