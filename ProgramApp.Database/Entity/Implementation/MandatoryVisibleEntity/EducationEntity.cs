using ProgramApp.Database.Domain;
using ProgramApp.Database.Entity.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramApp.Database.Entity.Implementation.MandatoryVisibleEntity
{
    public class EducationEntity : IMandatoryVisibleEntity
    {
        [Key]
        public int Id { get; set; }
        public bool IsMandatory { get ;set ; }
        public bool IsVisible { get ;set ; }

        public List<EducationDomain> EducationInfo { get; set; }
    }
}
