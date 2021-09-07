using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ResearchWebApp.BusinessLayer;
using ResearchWebApp.Data;

namespace ResearchWebApp.Pages.Papers
{
    public class CreateModel : PageModel
    {
        private readonly ResearchWebApp.Data.ResearchDBContext _context;

        public CreateModel(ResearchWebApp.Data.ResearchDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Paper Paper { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Papers.Add(Paper);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
