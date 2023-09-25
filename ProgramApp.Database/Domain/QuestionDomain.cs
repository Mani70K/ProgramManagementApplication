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
    public class QuestionDomain
    {
        [Key]
        public int Id { get; set; }

        public string QuestionCategory { get; set; } //Additional, Profile, Personal

        [NotMapped]
        public IQuestionTemplate QuestionTemplate { get; set; }
    }
}
