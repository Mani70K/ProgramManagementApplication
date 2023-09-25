using Microsoft.AspNetCore.Mvc;
using ProgramApp.API.DBContext;
using ProgramApp.Database.Models;

namespace ProgramApp.API.Controllers
{
    public class StageController : Controller
    {
        int _programId;
        private readonly ProgramAppDBContext _context;

        public StageController(int programId,ProgramAppDBContext context)
        {
            _programId = programId;
            _context = context;
        }

        [HttpGet]
        public List<Stage> GetAllStageList()
        {
            var obj = _context.stages.Where(x => x.ProgramId == _programId).ToList();
            return obj;
        }
        [HttpPost]
        public string AddStage()
        {
            return "Redirected To Form";
        }
        [HttpPost]
        public bool AddStage(Stage stage)
        {
            if (ModelState.IsValid)
            {
                _context.stages.Add(stage);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        [HttpPut]
        public bool EditASingleStage(int stageId, Stage stage)
        {
            if (ModelState.IsValid)
            {
                var obj = _context.stages.FirstOrDefault(x => x.Id == stageId && x.ProgramId==_programId);

                obj.StageList = stage.StageList;
                _context.SaveChanges();
                return true;

            }
            return false;
        }
        [HttpDelete]
        public bool DeleteAStage(int stageId)
        {
            var obj = _context.stages.FirstOrDefault(x => x.Id == stageId && x.ProgramId == _programId);

            _context.stages.Remove(obj);
            _context.SaveChanges();
            return true;
        }
    }
}
