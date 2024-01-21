using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace BookAuthorDetials.Nationalities
{
    public class Nationality : AuditedAggregateRoot<int>
    {
        public string NationalityTitle { get; set; }
    }
}
