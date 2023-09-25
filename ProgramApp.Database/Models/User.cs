using ProgramApp.Database.Domain;
using ProgramApp.Database.Entity.Implementation.InternalVisibleEntity;
using ProgramApp.Database.Entity.Implementation.MandatoryVisibleEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramApp.Database.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public int ProgramId { get; set; }
        [ForeignKey("ProgramId")]
        public virtual ProgramDetail ProgramDetail { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Email")]
        public string EmailId { get; set; }
        [Display(Name = "Phone")]
        public PhoneNumberEntity PhoneNumber { get; set; }
        [Display(Name = "Nationality")]
        public NationalityEntity Nationality { get; set; }
        [Display(Name = "Current Residence")]
        public ResidenceEntity CurrentResidence { get; set; }
        [Display(Name = "ID Number")]
        public IDEntity IdNumber { get; set; }
        [Display(Name = "Gender")]
        public GenderEntity Gender { get; set; }
        [Display(Name = "Date of Birth")]
        public DOBEntity DOB { get; set; }
        public List<QuestionDomain> Questions { get; set; }
        public EducationEntity Educations { get; set; }
        public WorkExperienceEntity WorkExperiences { get; set; }
        public ResumeEntity Resume { get; set; }
    }
}
