using Microsoft.EntityFrameworkCore;
using OA_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_REPOSITORY
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        #region Fields
        private readonly MyDbContext context;
        private readonly DbSet<T> entities;
        #endregion

        #region Ctor
        public Repository(MyDbContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        #endregion

        #region Insert
        public async Task InsertT(T entity)
        {
            await entities.AddAsync(entity);
            await SaveChangesT();
        }
        #endregion

        #region Update
        public async Task UpdateT(T entity)
        {
            entities.Update(entity);
            await SaveChangesT();
        }
        #endregion

        #region Delete
        public async Task DeleteT(T entity)
        {
            entities.Remove(entity);
            await SaveChangesT();
        }
        #endregion

        #region Details
        public async Task<T> DetailsT(int id)
        {
            return await GetByIdT(id);
        }
        #endregion

        #region GetAll
        public async Task<IEnumerable<T>> GetAllT()
        {
            return await entities.ToListAsync();
        }
        #endregion

        #region GetId
        public async Task<T> GetByIdT(int id)
        {
            return await entities.SingleOrDefaultAsync(x => x.Id == id);
        }
        #endregion

        #region SaveChanges
        public async Task SaveChangesT()
        {
            await context.SaveChangesAsync();
        }
        #endregion
    }
}
