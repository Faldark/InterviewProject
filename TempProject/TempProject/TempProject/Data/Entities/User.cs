using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempProject.Data.Entities
{
    public class User : BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public About About { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
        public Pricing Pricing { get; set; }
        public Schedule Schedule { get; set; }
        public WorkAbilities WorkAbilities { get; set; }

    }
}
