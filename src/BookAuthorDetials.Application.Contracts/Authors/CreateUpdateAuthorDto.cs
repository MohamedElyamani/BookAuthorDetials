using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookAuthorDetials.Authors
{
    public class CreateUpdateAuthorDto
    {
        [Required]
        public string AuthorName { get; set; }
        [Required]
        public int NationalityId { get; set; }
    }
}
