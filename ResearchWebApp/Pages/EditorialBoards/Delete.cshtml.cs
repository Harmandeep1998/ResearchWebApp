using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ResearchWebApp.BusinessLayer;
using ResearchWebApp.Data;

namespace ResearchWebApp.Pages.EditorialBoards
{
    public class DeleteModel : PageModel
    {
        private readonly ResearchWebApp.Data.ResearchDBContext _context;

        public DeleteModel(ResearchWebApp.Data.ResearchDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public EditorialBoard EditorialBoard { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EditorialBoard = await _context.EditorialBoards.FirstOrDefaultAsync(m => m.Id == id);

            if (EditorialBoard == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EditorialBoard = await _context.EditorialBoards.FindAsync(id);

            if (EditorialBoard != null)
            {
                _context.EditorialBoards.Remove(EditorialBoard);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
