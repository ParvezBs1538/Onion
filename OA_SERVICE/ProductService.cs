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
        public async Task DeleteProduct(int id)
        {
            Product pro = await GetProductId(id);
            await db.DeleteT(pro);
            //db.SaveChanges();
        }

        public async Task<Product> ProductDetails(int id)
        {
            //return db.GetById(id);
            return await GetProductId(id);
        }

        public async Task<IEnumerable<Product>> GetProduct()
        {
            return await db.GetAllT();
        }

        public async Task<Product> GetProductId(int id)
        {
            return await db.GetByIdT(id);
        }

        public async Task InsertProduct(Product entity)
        {
            await db.InsertT(entity);
        }

        public async Task SaveChanges()
        {
            await db.SaveChangesT();
        }

        public async Task UpdateProduct(Product entity)
        {
            await db.UpdateT(entity);
        }
    }
}
