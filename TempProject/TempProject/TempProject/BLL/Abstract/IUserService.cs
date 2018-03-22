using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TempProject.Data.DTO;

namespace TempProject.BLL.Abstract
{
    public interface IUserService
    {
        Task<UserDTO> GetUserByIdAsync(int id);
        Task<UserDTO> CreateUserAsync(UserDTO user);
        Task RemoveUserAsync(int id);
        Task UpdateUserAsync(UserDTO user);
    }
}
