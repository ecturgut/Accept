using Accept_Northwnd_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accept.Northwnd.Mvc.WebUI.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; internal set; }
    }
}
