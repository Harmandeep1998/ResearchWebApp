using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchWebApp.BusinessLayer
{
    public class Issue
    {
        // Represent Issue ID
        public int Id { get; set; }

        // Represnt Month Name
        public string MonthName { get; set; }

        // Represnt Year
        public int Year { get; set; }

        // Represnt Volume
        public int Volume { get; set; }

        // Represnt Issue No
        public int IssueNo { get; set; }

        // Represent Issue Title
        public string Title { get; set; }

        // Represent Issue Authors
        public string Authors { get; set; }

        // Represent Page No
        public string PageNo { get; set; }

        // Represent Paper ID
        public int PaperID { get; set; }

        public Paper Paper { get; set; }
    }
}
