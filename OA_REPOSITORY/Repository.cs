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
        public void Insert(T entity)
        {
            entities.Add(entity);
            context.SaveChanges();
        }
        #endregion

        #region Update
        public void Update(T entity)
        {
            entities.Update(entity);
            context.SaveChanges();
        }
        #endregion

        #region Delete
        public void Delete(T entity)
        {
            entities.Remove(entity);
            context.SaveChanges();
        }
        #endregion

        #region Details
        public T Details(int id)
        {
            return GetId(id);
        }
        #endregion

        #region GetAll
        public IEnumerable<T> GetAll()
        {
            return entities.ToList();
        }
        #endregion

        #region GetId
        public T GetId(int id)
        {
            return entities.SingleOrDefault(x => x.Id == id);
        }
        #endregion

        #region SaveChanges
        public void SaveChanges()
        {
            context.SaveChanges();
        }
        #endregion
    }
}
