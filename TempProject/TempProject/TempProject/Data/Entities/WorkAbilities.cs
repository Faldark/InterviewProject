using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TempProject.Data.Entities.Abstract;

namespace TempProject.Data.Entities
{
    public class WorkAbilities : BaseEntity<int>
    {
        public string Abilities { get; set; }

        public User User { get; set; }
    }
}
