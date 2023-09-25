using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramApp.Templates.Interface
{
    public interface IQuestionTemplate
    {
        public string  QuestionType { get; set; }
        public string  QuestionText { get; set; }
    }
}
