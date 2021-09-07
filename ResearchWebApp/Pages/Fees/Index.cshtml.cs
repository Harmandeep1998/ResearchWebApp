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
    public class IndexModel : PageModel
    {
        private readonly ResearchWebApp.Data.ResearchDBContext _context;

        public IndexModel(ResearchWebApp.Data.ResearchDBContext context)
        {
            _context = context;
        }

        public IList<Fee> Fee { get;set; }

        public async Task OnGetAsync()
        {
            Fee = await _context.Fees
                .Include(f => f.Paper).ToListAsync();
        }
    }
}
