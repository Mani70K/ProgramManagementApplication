using ProgramApp.Templates.Implementation.StageTemplate;
using ProgramApp.Templates.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramApp.Factory.Factory
{
    public class StageTypeFactory
    {
        public IStageTemplate GetStageTypeTemplate(string stageTypeSelected)
        {
            IStageTemplate obj = null;
            if (stageTypeSelected == "Shortlisting")
            {
                obj = new ShortlistingStageTemplate();
            }
            else if (stageTypeSelected == "Video_Interview")
            {
                obj = new VideoInterviewStageTemplate();
            }
            else if (stageTypeSelected == "Placement")
            {
                obj = new PlacementStageTemplate();
            }
            else
            {
                obj = null;
            }

            return obj;
        }
    }
}
