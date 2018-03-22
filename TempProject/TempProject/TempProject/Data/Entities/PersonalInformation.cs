using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TempProject.Data.Enums;

namespace TempProject.Data.Entities
{
    public class PersonalInformation : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DetaOfBirth { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        


    }
}
