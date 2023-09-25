using Microsoft.AspNetCore.Mvc;
using ProgramApp.API.DBContext;
using ProgramApp.Database.Models;

namespace ProgramApp.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UserController : Controller
    {
        int _programId;
        private readonly ProgramAppDBContext _context;

        public UserController(int programId,ProgramAppDBContext context)
        {
            _programId = programId;
            _context = context;
        }
        [HttpGet]
        public List<User> GetAllUserDetails()
        {
            var list=_context.users.Where(x=>x.ProgramId==_programId).ToList();
            return list;
        }
        [HttpPost]
        public string AddUser()
        {
            return "Redirected To Form";
        }
        [HttpPost]
        public bool AddUser(User user)
        {
            if (ModelState.IsValid)
            {
                _context.users.Add(user);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        [HttpPut]
        public bool EditASingleUser(int userId, User user)
        {
            if (ModelState.IsValid)
            {
                var obj=_context.users.Where(x=>x.Id==userId && x.ProgramId==_programId).FirstOrDefault();
                obj.FirstName= user.FirstName;
                obj.LastName= user.LastName;
                obj.Educations = user.Educations;
                obj.EmailId= user.EmailId;
                obj.PhoneNumber= user.PhoneNumber;
                obj.Resume=user.Resume;
                obj.CurrentResidence=user.CurrentResidence;
                obj.Questions=user.Questions;
                obj.Nationality=user.Nationality;
                obj.IdNumber= user.IdNumber;
                obj.Gender=user.Gender;
                obj.WorkExperiences=user.WorkExperiences;
                obj.DOB=user.DOB;

                _context.SaveChanges();
                return true;
            }
            return false;
        }
        [HttpDelete]
        public bool DeleteAUser(int userId)
        {
            var obj = _context.users.Where(x => x.Id == userId && x.ProgramId == _programId).FirstOrDefault();
            _context.users.Remove(obj); 
            _context.SaveChanges();
            return true;

        }
    }
}
