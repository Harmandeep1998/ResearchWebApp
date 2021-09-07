using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchWebApp.BusinessLayer
{
    public class Fee
    {
        // Represent Fee ID
        public int Id { get; set; }

        // Represent Amount
        public float Amount { get; set; }

        // Represent Paper ID
        public int PaperID { get; set; }

        public Paper Paper { get; set; }

    }
}
