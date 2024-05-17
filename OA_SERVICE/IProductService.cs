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
        void Insert(Product entity);
        void Update(Product entity);
        void Delete(int Id);
        void SaveChanges();
        IEnumerable<Product> GetProduct();
        Product GetProductId(int id);
    }
}
