using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRepositoryEF<T> where T : BaseEF
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(int id);

        Task<T> Create(T item); 

        Task<T> Update(T item);

        Task<bool> Delete(int id);  

        Task<bool> Exists(int id);
    }
}
