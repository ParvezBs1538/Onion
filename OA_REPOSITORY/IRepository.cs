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
        Task InsertT(T entity);
        Task UpdateT(T entity);
        Task DeleteT(T entity);
        Task SaveChangesT();
        Task<IEnumerable<T>> GetAllT();
        Task<T> GetByIdT(int id);
        Task<T> DetailsT(int id);
    }
}
