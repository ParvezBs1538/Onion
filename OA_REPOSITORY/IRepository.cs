using OA_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_REPOSITORY
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task Insert(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task SaveChanges();
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Details(int id);
    }
}
