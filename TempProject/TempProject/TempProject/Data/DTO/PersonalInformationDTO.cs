using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TempProject.Data.Entities.Abstract;
using TempProject.Data.Enums;

namespace TempProject.Data.DTO
{
    public class PersonalInformationDTO 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DetaOfBirth { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }

        public int UserId { get; set; }

    }
}
