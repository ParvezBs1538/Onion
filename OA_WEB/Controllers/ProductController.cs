using Microsoft.AspNetCore.Mvc;
using OA_Data;
using OA_SERVICE;

namespace OA_WEB.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _product;
        public ProductController(IProductService product)
        {
            _product = product;
        }
        public IActionResult Index()
        {
            var item = _product.GetProduct();
            return View(item);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var item = _product.GetProductId(id);
            return View(item);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {
            _product.DeleteProduct(id);
            return RedirectToAction("Index", "Product");
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _product.InsertProduct(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }
        public IActionResult Details(int id)
        {
            var item = _product.ProductDetails(id);
            return View(item);
        }
        public IActionResult Edit(int id)
        {
            var item = _product.GetProductId(id);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _product.UpdateProduct(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

    }
}
