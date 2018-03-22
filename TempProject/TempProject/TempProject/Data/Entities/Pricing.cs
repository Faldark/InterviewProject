using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TempProject.Data.Entities
{
    public class Pricing : BaseEntity
    {
        public int Price { get; set; }
        
    }
}
