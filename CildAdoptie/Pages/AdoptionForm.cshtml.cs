using CildAdoptie.Models;
using CildAdoptie.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CildAdoptie.Pages
{
    public class AdoptionFormModel : PageModel
    {
        [BindProperty]
        public AdoptionRequest AdoptionRequest {  get; set; }
        private readonly IChildRepository _childRepository;

        public AdoptionFormModel(IChildRepository childRepository)
        {
            _childRepository = childRepository;

        }

        public void OnGet()
        {
        }
        public IActionResult OnPost(Guid id)
        {
            AdoptionRequest.ChildId = id;
            AdoptionRequest.Id = Guid.NewGuid();
            if (ModelState.IsValid)
            {
                _childRepository.Add(AdoptionRequest);
                return Page();
            }
            return Page();

        }

    }
}
