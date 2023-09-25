using ProgramApp.Templates.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramApp.Database.Domain
{
    public class StageDomain
    {
        [Key]
        public int Id { get; set; }

        public string StageName { get; set; }
        [NotMapped]
        public IStageTemplate StageType { get; set; }
        public bool IsTheStageVisible { get; set; }
    }
}
