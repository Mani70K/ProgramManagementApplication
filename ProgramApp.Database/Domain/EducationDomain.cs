using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramApp.Database.Domain
{
    public class EducationDomain
    {
        [Key]
        public int Id { get; set; }

        public string School { get; set; }
        public string Degree { get; set; }
        public string CourseName { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public bool IsCurrentStudy { get; set; }

    }
}
