using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TempProject.Data.Entities.Abstract;
namespace TempProject.Data.Entities
{
    public class About : BaseEntity<int>
    {
        public string AboutMe { get; set; }
        
        public User User { get; set; }
        
    }
}
