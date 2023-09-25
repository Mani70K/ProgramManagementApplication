using Microsoft.AspNetCore.Mvc;
using ProgramApp.API.DBContext;
using ProgramApp.Database.Domain;
using ProgramApp.Database.Models;

namespace ProgramApp.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class QuestionController : Controller
    {
        int _programId;
        private readonly ProgramAppDBContext _context;

        public QuestionController(int programId,ProgramAppDBContext context)
        {
            _programId = programId;
            _context= context;
        }
        [HttpGet]
        public List<QuestionDomain> GetAllQuestionDetails()
        {
            var obj=_context.users.FirstOrDefault(x=>x.ProgramId==_programId).Questions.ToList();
            return obj;
        }
        [HttpPost]
        public string AddAQuestion()
        {
            return "Redirected To Form";
        }
        [HttpPost]
        public bool AddAQuestion(QuestionDomain question)
        {
            if (ModelState.IsValid)
            {
                _context.users.FirstOrDefault(x => x.ProgramId == _programId).Questions.Add(question);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        [HttpPut]
        public bool EditASingleQuestion(int questionId, QuestionDomain question)
        {
            var obj = _context.users.FirstOrDefault(x => x.ProgramId == _programId).Questions.Where(x=>x.Id==questionId).FirstOrDefault();
            obj.QuestionTemplate = question.QuestionTemplate;
            obj.QuestionCategory = question.QuestionCategory;
            _context.SaveChanges();
            return true;
        }
        [HttpDelete]
        public bool DeleteAQuestion(int questionId)
        {
            var obj = _context.users.FirstOrDefault(x => x.ProgramId == _programId).Questions.Where(x => x.Id == questionId).FirstOrDefault();
            _context.users.FirstOrDefault(x => x.ProgramId == _programId).Questions.Remove(obj);
            _context.SaveChanges();
            return true;
        }
    }
}
