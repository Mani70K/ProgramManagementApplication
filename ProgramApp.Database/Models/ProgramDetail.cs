using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramApp.Database.Models
{
    public class ProgramDetail
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name ="Program Title")]
        public string ProgramTitle { get; set; }
        [Display(Name = "Summary of the Program")]
        public string ProgramSummary { get; set; }

        [Required]
        [Display(Name = "Program Description")]
        public string ProgramDescription { get; set; }

        [NotMapped]
        [Display(Name = "Key Skills Required for this program")]
        public List<string> KeySkills { get; set; } = new List<string>();

        [Display(Name = "Program Benefits")]
        public string ProgramBenefits { get; set; }
        [Display(Name = "Application Criteria")]
        public string ApplicationCriteria { get; set; }
        [Required]
        [Display(Name = "Program type")]
        public string ProgramType { get; set; }

        [Display(Name = "Program start")]
        public DateTime ProgramStart { get; set; }
        [Required]
        [Display(Name = "Application open")]
        public DateTime ApplicationOpen { get; set; }
        [Required]
        [Display(Name = "Application close")]
        public DateTime ApplicationClose { get; set; }
        [Display(Name = "Duration")]
        public string Duration { get; set; }
        [Required]
        [Display(Name = "Program location")]
        public string ProgramLocation { get; set; }
        [Display(Name = "Min qualifications")]
        public string MinQualifications { get; set; }
        [Display(Name = "Max number of application")]
        public int MaxNumberOfApplication { get; set; }
        [Display(Name = "Upload cover image")]
        public string CoverImageURL { get; set; }
    }
}
