using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TempProject.Data.Entities.Abstract;

namespace TempProject.Data.DTO
{
    public class WorkAbilitiesDTO 
    {
        public int Id { get; set; }
        public string Abilities { get; set; }

        public int UserId { get; set; }
    }
}
