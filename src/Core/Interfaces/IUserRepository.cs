using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserModel>> GetSelectUsers();

        Task<UserModel> GetUserById(int id);
    }
}
