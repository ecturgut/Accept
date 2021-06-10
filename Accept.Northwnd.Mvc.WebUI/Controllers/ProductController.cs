using Accept.Business.Abstract;
using Accept.Northwnd.Mvc.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accept.Northwnd.Mvc.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public ActionResult Index()
        {
            var products = _productService.GetAll();

            ProductListViewModel model = new ProductListViewModel
            {
                Products = products
            };

            return View(model);
        }
    }
}
