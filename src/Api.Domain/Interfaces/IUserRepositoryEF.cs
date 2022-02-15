using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUserRepositoryEF : IRepositoryEF<UserEF>
    {
        Task<UserEF> FindByLogin(string email, string password);
    }
}
