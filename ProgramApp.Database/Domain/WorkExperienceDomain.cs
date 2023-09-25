using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramApp.Database.Domain
{
    public class WorkExperienceDomain
    {
        [Key]
        public int Id { get; set; }

        public string Company { get; set; }
        public string Title { get; set; }
        public string Locattion { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public bool IsCurrentCompany { get; set; }
    }
}
