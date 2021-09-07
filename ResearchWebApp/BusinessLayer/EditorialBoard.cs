using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchWebApp.BusinessLayer
{
    public class EditorialBoard
    {
        // Represent Editorial Board ID 
        public int Id { get; set; }

        // Represent Person Name
        public string PaperName { get; set; }

        // Represent Title
        public string Title { get; set; }

        // Represent Description
        public string Description { get; set; }
    }
}
