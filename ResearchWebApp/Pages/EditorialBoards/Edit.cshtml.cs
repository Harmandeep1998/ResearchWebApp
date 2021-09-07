using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ResearchWebApp.BusinessLayer;
using ResearchWebApp.Data;

namespace ResearchWebApp.Pages.EditorialBoards
{
    public class EditModel : PageModel
    {
        private readonly ResearchWebApp.Data.ResearchDBContext _context;

        public EditModel(ResearchWebApp.Data.ResearchDBContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(EditorialBoard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EditorialBoardExists(EditorialBoard.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EditorialBoardExists(int id)
        {
            return _context.EditorialBoards.Any(e => e.Id == id);
        }
    }
}
