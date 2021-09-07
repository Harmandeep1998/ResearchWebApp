using Microsoft.EntityFrameworkCore;
using ResearchWebApp.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchWebApp.Data
{
    public class ResearchDBContext : DbContext
    {
        public ResearchDBContext(DbContextOptions<ResearchDBContext> options)
            : base(options)
        {
        }

        public DbSet<Paper> Papers { get; set; }

        public DbSet<Issue> Issues { get; set; }

        public DbSet<Fee> Fees { get; set; }

        public DbSet<EditorialBoard> EditorialBoards { get; set; }
    }
}
