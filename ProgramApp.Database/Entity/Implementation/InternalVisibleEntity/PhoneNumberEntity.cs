using ProgramApp.Database.Entity.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramApp.Database.Entity.Implementation.InternalVisibleEntity
{
    public class PhoneNumberEntity : IInternalVisibleEntity
    {
        [Key]
        public int Id { get; set; }
        public bool IsInternal {get;set;}
        public bool IsVisible {get;set;}
        public string PhoneNumberInfo { get; set; }
    }
}
