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
        public async Task Insert(T entity)
        {
            await entities.AddAsync(entity);
            await context.SaveChangesAsync();
        }
        #endregion

        #region Update
        public async Task Update(T entity)
        {
            entities.Update(entity);
            await context.SaveChangesAsync();
        }
        #endregion

        #region Delete
        public async Task Delete(T entity)
        {
            entities.Remove(entity);
            await context.SaveChangesAsync();
        }
        #endregion

        #region Details
        public async Task<T> Details(int id)
        {
            return await GetById(id);
        }
        #endregion

        #region GetAll
        public async Task<IEnumerable<T>> GetAll()
        {
            return await entities.ToListAsync();
        }
        #endregion

        #region GetId
        public async Task<T> GetById(int id)
        {
            return await entities.SingleOrDefaultAsync(x => x.Id == id);
        }
        #endregion

        #region SaveChanges
        public async Task SaveChanges()
        {
            await context.SaveChangesAsync();
        }
        #endregion
    }
}
