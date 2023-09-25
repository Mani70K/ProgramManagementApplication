using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramApp.Database.Entity.Interface
{
    public interface IInternalVisibleEntity:IVisibleEntity
    {
        public bool IsInternal { get; set; }
    }
}
