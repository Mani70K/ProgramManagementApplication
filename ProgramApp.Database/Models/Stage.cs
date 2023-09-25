using ProgramApp.Database.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramApp.Database.Models
{
    public class Stage
    {
        [Key]
        public int Id { get; set; }
        public int ProgramId { get; set; }
        [ForeignKey("ProgramId")]
        public virtual ProgramDetail ProgramDetail { get; set; }
        public List<StageDomain> StageList { get; set; }
    }
}
