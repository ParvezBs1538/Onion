using OA_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_SERVICE
{
    public interface IProductService
    {
        Task InsertProduct(Product entity);
        Task UpdateProduct(Product entity);
        Task DeleteProduct(int Id);
        Task SaveChanges();
        Task<IEnumerable<Product>> GetProduct();
        Task<Product> GetProductId(int id);
        Task<Product> ProductDetails(int id);
    }
}
