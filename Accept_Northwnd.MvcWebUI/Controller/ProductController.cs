using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Accept.Northwnd.MvcWebUI.Controller
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
