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
        public async Task<IActionResult> Index()
        {
            var item = await _product.GetProduct();
            return View(item);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _product.GetProductId(id);
            return View(item);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int id)
        {
            await _product.DeleteProduct(id);
            return RedirectToAction("Index", "Product");
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            if (ModelState.IsValid)
            {
                await _product.InsertProduct(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }
        public async Task<IActionResult> Details(int id)
        {
            var item = await _product.ProductDetails(id);
            return View(item);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var item = await _product.GetProductId(id);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                await _product.UpdateProduct(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

    }
}
