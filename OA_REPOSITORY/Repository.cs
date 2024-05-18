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
        private readonly MyDbContext context;
        private readonly DbSet<T> entities;

        public Repository(MyDbContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public void Insert(T entity)
        {
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            entities.Update(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            entities.Remove(entity);
            context.SaveChanges();
        }

        public T Details(int id)
        {
            return GetId(id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.ToList();
        }

        public T GetId(int id)
        {
            return entities.SingleOrDefault(x => x.Id == id);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
