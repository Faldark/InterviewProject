using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TempProject.Data.Entities.Abstract;

namespace TempProject.Data.DTO
{
    public class UserDTO 
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        

    }
}
