using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ResearchWebApp.BusinessLayer;
using ResearchWebApp.Data;

namespace ResearchWebApp.Pages.Issues
{
    public class IndexModel : PageModel
    {
        private readonly ResearchWebApp.Data.ResearchDBContext _context;

        public IndexModel(ResearchWebApp.Data.ResearchDBContext context)
        {
            _context = context;
        }

        public IList<Issue> Issue { get;set; }

        public async Task OnGetAsync()
        {
            Issue = await _context.Issues
                .Include(i => i.Paper).ToListAsync();
        }
    }
}
