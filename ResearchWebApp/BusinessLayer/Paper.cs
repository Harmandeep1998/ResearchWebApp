using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchWebApp.BusinessLayer
{
    public class Paper
    {
        // Represent Paper ID 
        public int Id { get; set; }

        // Represent Paper Name
        public string PaperName { get; set; }

        // Represent ISSN
        public string ISSN { get; set; }
    }
}
