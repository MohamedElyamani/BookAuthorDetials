using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookAuthorDetials.Books
{
    public class CreateUpdateBookDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public BookType Type { get; set; } = BookType.Undefined;
        [Required]
        public Guid AuthorId { get; set; }
    }
}
