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
        void InsertProduct(Product entity);
        void UpdateProduct(Product entity);
        void DeleteProduct(int Id);
        void SaveChanges();
        IEnumerable<Product> GetProduct();
        Product GetProductId(int id);
        Product ProductDetails(int id);
    }
}
