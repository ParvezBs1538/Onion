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
        private readonly MyDbContext _db;
        private readonly DbSet<T> entities;
        public Repository(MyDbContext myDb)
        {
            _db = myDb;
            entities = _db.Set<T>();
        }
        public void Delete(T entity)
        {
            entities.Remove(entity);
            _db.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public T GetId(int id)
        {
            return entities.SingleOrDefault(x => x.Id == id);
        }

        public void Insert(T entity)
        {
            entities.Add(entity);
            _db.SaveChanges();
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        public void Update(T entity)
        {
            _db.SaveChanges();
        }
    }
}
