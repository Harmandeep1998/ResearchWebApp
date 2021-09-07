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
    public class IndexModel : PageModel
    {
        private readonly ResearchWebApp.Data.ResearchDBContext _context;

        public IndexModel(ResearchWebApp.Data.ResearchDBContext context)
        {
            _context = context;
        }

        public IList<EditorialBoard> EditorialBoard { get;set; }

        public async Task OnGetAsync()
        {
            EditorialBoard = await _context.EditorialBoards.ToListAsync();
        }
    }
}
