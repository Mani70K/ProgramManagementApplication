using ProgramApp.Templates.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramApp.Templates.Implementation.QuestionTemplate
{
    public class DateQuestionTemplate : IQuestionTemplate
    {
        [Key]
        public int Id { get; set; }
        public string QuestionType  { get ; set ; }
        public string QuestionText  { get ; set ; }

        public DateTime Answer { get; set; }
    }
}
