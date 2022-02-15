using Data.EF.Context;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Data.EF.Repository
{
    public class UserRepositoryEF : BaseRepositoryEF<UserEF>, IUserRepositoryEF
    {
        private readonly DbSet<UserEF> _dataset;

        public UserRepositoryEF(MyContext context) : base(context)
        {
            _dataset = _context.Set<UserEF>();
        }

        public async Task<UserEF> FindByLogin(string email, string password)
        {
            return await _dataset.FirstOrDefaultAsync(x => x.Email == email && x.Password == password);
        }
    }
}
