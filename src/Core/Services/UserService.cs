using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<UserModel>> GetSelectUsers()
        {
            return await _userRepository.GetSelectUsers();
        }

        public async Task<UserModel> GetUserById(int id)
        {
            return await _userRepository.GetUserById(id);
        }
    }
}
