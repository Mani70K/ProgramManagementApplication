using ProgramApp.Database.Entity.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramApp.Database.Entity.Implementation.MandatoryVisibleEntity
{
    public class ResumeEntity : IMandatoryVisibleEntity
    {
        [Key]
        public int Id { get; set; }
        public bool IsMandatory { get ;set ; }
        public bool IsVisible { get ;set ; }
        public string ResumeURLInfo { get; set; }
    }
}
