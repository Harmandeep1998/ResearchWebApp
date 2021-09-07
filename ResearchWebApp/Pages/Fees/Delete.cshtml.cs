using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ResearchWebApp.BusinessLayer;
using ResearchWebApp.Data;

namespace ResearchWebApp.Pages.Fees
{
    public class DeleteModel : PageModel
    {
        private readonly ResearchWebApp.Data.ResearchDBContext _context;

        public DeleteModel(ResearchWebApp.Data.ResearchDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Fee Fee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Fee = await _context.Fees
                .Include(f => f.Paper).FirstOrDefaultAsync(m => m.Id == id);

            if (Fee == null)
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

            Fee = await _context.Fees.FindAsync(id);

            if (Fee != null)
            {
                _context.Fees.Remove(Fee);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
