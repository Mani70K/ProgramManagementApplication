using ProgramApp.Templates.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramApp.Templates.Implementation.QuestionTemplate
{
    public class MultipleChoiceQuestionTemplate : IQuestionTemplate
    {
        public int Id { get; set; }
        public string QuestionType { get; set; }

        public string QuestionText { get; set; }

        public List<string> Choice { get; set; } 

        public bool IsOtherEnable { get; set; }

        public int MaxChoiceAllowed { get; set; }

        public List<String> Answer { get; set; }
    }

}
