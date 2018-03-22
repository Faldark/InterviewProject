using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TempProject.BLL.Abstract;
using TempProject.Data.Abstract;
using TempProject.Data.DTO;
using TempProject.Data.Entities;

namespace TempProject.BLL.Services
{
    public class UserService: IUserService
    {
        private IUnitOfWorkFactory _factory;
        public UserService(IUnitOfWorkFactory factory)
        {
            _factory = factory;
        }

        public async Task<UserDTO> GetUserByIdAsync(int id)
        {
            var unitOfWork = _factory.CreateUnitOfWork();
            var entity = await unitOfWork.UserRepository.Query.FirstOrDefaultAsync(e => e.Id == id);
            return new UserDTO
            {
                Id = entity.Id,
                Email = entity.Email,
                Password = entity.Password
            };
        }
        public async Task<UserDTO> CreateUserAsync(UserDTO user)
        {
            var unitOfWork = _factory.CreateUnitOfWork();

            var entity = new User
            {
                Email = user.Email,
                Password = user.Password
            };
            unitOfWork.UserRepository.Create(entity);
            await unitOfWork.SaveAsync();
            user.Id = entity.Id;
    

            return user;
        }
        public async Task RemoveUserAsync(int id)
        {
            var unitOfWork = _factory.CreateUnitOfWork();
            await unitOfWork.UserRepository.DeleteByIdAsync(id);
            await unitOfWork.SaveAsync();
            return;
        }
        public async Task UpdateUserAsync(UserDTO user)
        {
            var unitOfWork = _factory.CreateUnitOfWork();
            var entity = new User
            {
                Id = user.Id,
                Email = user.Email,
                Password = user.Password
            };
            unitOfWork.UserRepository.Update(entity);
            await unitOfWork.SaveAsync();
            
        }
    }
}
