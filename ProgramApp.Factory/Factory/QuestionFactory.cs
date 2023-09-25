using ProgramApp.Templates.Implementation.QuestionTemplate;
using ProgramApp.Templates.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramApp.Factory.Factory
{
    public class QuestionFactory
    {
        public static IQuestionTemplate GetQuestionTemplate(string questionType)
        {
            IQuestionTemplate eventTemplate;

            if (questionType == "paragraph")
            {
                eventTemplate = new ParagraphQuestionTemplate();
            }
            else if (questionType == "short answer")
            {
                eventTemplate = new ShortAnswerQuestionTemplate();
            }
            else if (questionType == "yes/no")
            {
                eventTemplate = new YesNoQuestionTemplate();
            }
            else if (questionType == "dropdown")
            {
                eventTemplate = new DropdownQuestionTemplate();
            }
            else if (questionType == "multiple choice")
            {
                eventTemplate = new MultipleChoiceQuestionTemplate();
            }
            else if (questionType == "date")
            {
                eventTemplate = new DateQuestionTemplate();
            }
            else if (questionType == "number")
            {
                eventTemplate = new NumberQuestionTemplate();
            }
            else if (questionType == "file upload")
            {
                eventTemplate = new FileUploadQuestionTemplate();
            }
            else if (questionType == "video question")
            {
                eventTemplate = new VideoQuestionQuestionTemplate();
            }
            else
            {
                eventTemplate = null;
            }
            return eventTemplate;
        }
    }
}
