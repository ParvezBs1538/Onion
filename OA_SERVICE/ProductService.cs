using OA_Data;
using OA_REPOSITORY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_SERVICE
{
    public class ProductService : IProductService
    {
        private IRepository<Product> db;
        public ProductService(IRepository<Product> _db)
        {
            db = _db;
        }
        public void Delete(int id)
        {
            Product pro = GetProductId(id);
            db.Delete(pro);
            db.SaveChanges();
        }

        public IEnumerable<Product> GetProduct()
        {
            return db.GetAll();
        }

        public Product GetProductId(int id)
        {
            return db.GetId(id);
        }

        public void Insert(Product entity)
        {
            db.Insert(entity);
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }

        public void Update(Product entity)
        {
            db.SaveChanges();
        }
    }
}
