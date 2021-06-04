using Accept.Business.Abstract;
using Accept.Northwnd.DataAccess.Absctract;
using Accept_Northwnd_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accept.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategoryId(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryId == categoryId);
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(new Product {ProductId = productId });
        }

    }
}
