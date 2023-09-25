using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProgramApp.API.DBContext;
using ProgramApp.Database.Models;

namespace ProgramApp.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProgramController : Controller
    {
        private readonly ProgramAppDBContext _context;

        public ProgramController(ProgramAppDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public List<ProgramDetail> GetAllProgramDetails()
        {
            var list=_context.programs.ToList();
            return list;
        }
        [HttpGet]
        public ProgramDetail GetAProgramDetail(int programId)
        {
            var obj = _context.programs.FirstOrDefault(x=>x.Id==programId);
            return obj;
        }
        [HttpPost]
        public string AddProgram()
        {
            return "Redirected To Form";
        }
        [HttpPost]
        public bool AddProgram(ProgramDetail programDetail)
        {
            if (ModelState.IsValid)
            {
                _context.programs.Add(programDetail);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        [HttpPut]
        public bool EditASingleProgram(int programId,ProgramDetail program)
        {
            if(ModelState.IsValid)
            {
                    var obj=_context.programs.Where(x=>x.Id == programId).FirstOrDefault();
                    obj.ProgramTitle = program.ProgramTitle;
                    obj.ProgramSummary = program.ProgramSummary;
                    obj.ProgramBenefits=program.ProgramBenefits;
                    obj.ProgramDescription=program.ProgramDescription;
                    obj.KeySkills=program.KeySkills;
                    obj.ApplicationCriteria=program.ApplicationCriteria;
                    obj.ProgramType=program.ProgramType;
                    obj.ProgramStart=program.ProgramStart;
                    obj.ApplicationOpen=program.ApplicationOpen;
                    obj.ApplicationClose=program.ApplicationClose;
                    obj.Duration=program.Duration;
                    obj.ProgramLocation=program.ProgramLocation;
                    obj.MinQualifications=program.MinQualifications;
                    obj.MaxNumberOfApplication = program.MaxNumberOfApplication;
                    obj.CoverImageURL=program.CoverImageURL;

                _context.SaveChanges();
                return true;
                   
                
            }
            return false;
        }
        [HttpDelete]
        public bool DeleteAProgram(int programId)
        {
            var obj = _context.programs.Where(x => x.Id == programId).FirstOrDefault();
            _context.programs.Remove(obj);
            _context.SaveChanges();
            return true;
        }
    }
}
