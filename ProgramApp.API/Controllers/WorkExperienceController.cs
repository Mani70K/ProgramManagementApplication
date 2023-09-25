using Microsoft.AspNetCore.Mvc;
using ProgramApp.API.DBContext;
using ProgramApp.Database.Domain;
using ProgramApp.Database.Entity.Implementation.MandatoryVisibleEntity;
using ProgramApp.Database.Models;

namespace ProgramApp.API.Controllers
{
    public class WorkExperienceController : Controller
    {
        private readonly int _programId;
        private readonly ProgramAppDBContext _context;

        public WorkExperienceController(int programId,ProgramAppDBContext context)
        {
            _programId = programId;
            _context = context;
        }
        public List<WorkExperienceDomain> GetAllExperiences()
        {
            var obj = _context.users.FirstOrDefault(x => x.ProgramId == _programId).WorkExperiences.WorkExperienceInfo.ToList();
            return obj;

        }
        [HttpPost]
        public string AddExperience()
        {
            return "Redirected To Form";
        }
        [HttpPost]
        public string AddExperience(WorkExperienceDomain workExperience)
        {
            _context.users.FirstOrDefault(x => x.ProgramId == _programId).WorkExperiences.WorkExperienceInfo.Add(workExperience);
            _context.SaveChanges();
            return "Experience Added Successfully";
        }
        [HttpPut]
        public string EditExperience(int experienceId, WorkExperienceDomain workExperience)
        {
            var obj = _context.users.FirstOrDefault(x => x.ProgramId == _programId).WorkExperiences.WorkExperienceInfo.FirstOrDefault(x=>x.Id==experienceId);
            obj.Company=workExperience.Company;
            obj.Title=workExperience.Title;
            obj.Locattion=workExperience.Locattion;
            obj.StartDate=workExperience.StartDate;
            obj.EndDate=workExperience.EndDate;
            obj.IsCurrentCompany=workExperience.IsCurrentCompany;
            _context.SaveChanges();
            return "Edit Experience With Id ";
        }
        [HttpDelete]
        public string DeleteExperience(int experienceId)
        {
            var obj = _context.users.FirstOrDefault(x => x.ProgramId == _programId).WorkExperiences.WorkExperienceInfo.FirstOrDefault(x => x.Id == experienceId);
            _context.users.FirstOrDefault(x => x.ProgramId == _programId).WorkExperiences.WorkExperienceInfo.Remove(obj);
            _context.SaveChanges();
            return "Delete A Experiece With Id";
        }
    }
}
