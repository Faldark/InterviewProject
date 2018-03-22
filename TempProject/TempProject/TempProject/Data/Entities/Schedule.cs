using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TempProject.Data.Entities
{
    public class Schedule : BaseEntity
    {
        public string ScheduledTime { get; set; }
        

    }
}
