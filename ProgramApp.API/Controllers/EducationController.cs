using Microsoft.AspNetCore.Mvc;
using ProgramApp.API.DBContext;
using ProgramApp.Database.Domain;
using ProgramApp.Database.Models;

namespace ProgramApp.API.Controllers
{
    public class EducationController : Controller
    {
        private readonly int _programId;
        private readonly ProgramAppDBContext _context;

        public EducationController(int programId,ProgramAppDBContext context)
        {
            _programId = programId;
            _context = context;
        }
        public List<EducationDomain> GetAllEducationDetails()
        {
            var obj = _context.users.FirstOrDefault(x => x.ProgramId == _programId).Educations.EducationInfo.ToList();
            return obj;
        }
        [HttpPost]
        public string AddAEducation()
        {
            return "Redirected To Form";
        }
        [HttpPost]
        public string AddAEducation(EducationDomain education)
        {
            _context.users.FirstOrDefault(x => x.ProgramId == _programId).Educations.EducationInfo.Add(education);
            _context.SaveChanges();
            return "Education Added Successfully";
        }
        [HttpPut]
        public string EditASingleEducation(int educationId, EducationDomain education)
        {
            var obj=_context.users.FirstOrDefault(x => x.ProgramId == _programId).Educations.EducationInfo.FirstOrDefault(x=>x.Id==educationId);
            obj.School = education.School;
            obj.Degree = education.Degree;
            obj.CourseName= education.CourseName;
            obj.Location= education.Location;
            obj.StartDate= education.StartDate;
            obj.EndDate= education.EndDate;
            obj.IsCurrentStudy = education.IsCurrentStudy;
            _context.SaveChanges();
            return "Edit Education With Id ";
        }
        [HttpDelete]
        public string DeleteAEducation(int educationId)
        {
            var obj = _context.users.FirstOrDefault(x => x.ProgramId == _programId).Educations.EducationInfo.FirstOrDefault(x => x.Id == educationId);
            _context.users.FirstOrDefault(x => x.ProgramId == _programId).Educations.EducationInfo.Remove(obj);
            _context.SaveChanges();
            return "Delete A Question With Id";
        }
    }
}
