using BookAuthorDetials.Books;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System;
using System.Threading.Tasks;

namespace BookAuthorDetials.Web.Pages.BookAndAuhtorDet
{
    public class CreateModelModel : BookAuthorDetialsPageModel
    {
        [BindProperty]
        public CreateUpdateBookViewMode bookDto { get; set; }
        private  readonly IBookAppService _bookAppService;

        public CreateModelModel(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }

        public void OnGet()
        {
            bookDto = new CreateUpdateBookViewMode();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            await _bookAppService.CreateAsync(ObjectMapper.Map<CreateUpdateBookViewMode , CreateUpdateBookDto>(bookDto));
            return NoContent();
        }
        public class CreateUpdateBookViewMode
        {

            [Required]
            [StringLength(128)]
            public string Name { get; set; } = string.Empty;

            [Required]
            public BookType Type { get; set; } = BookType.Undefined;
            [HiddenInput]
            public Guid AuthorId { get; set; }
        }

    }
}
