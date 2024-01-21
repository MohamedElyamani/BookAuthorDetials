using BookAuthorDetials.Authors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace BookAuthorDetials.Web.Pages.BookAndAuhtorDet
{
    public class AuthorDisplyModel : BookAuthorDetialsPageModel
    {
        [BindProperty]
        public CreateUpdateAuthorDto authorDto { get; set; }
        private readonly IAuthorAppService _authorAppService;

        public AuthorDisplyModel(IAuthorAppService authorAppService)
        {
            _authorAppService = authorAppService;
        }

        public void OnGet()
        {
            authorDto = new CreateUpdateAuthorDto();
        }
        public async Task<IActionResult> OnPostAsync() 
        {
            await _authorAppService.CreateAsync(authorDto);
            return NoContent();
        }
    }
}
