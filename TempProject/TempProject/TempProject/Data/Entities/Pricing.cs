using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TempProject.Data.Entities.Abstract;

namespace TempProject.Data.Entities
{
    public class Pricing : BaseEntity<int>
    {
        public int Price { get; set; }

        public User User { get; set; }
    }
}
