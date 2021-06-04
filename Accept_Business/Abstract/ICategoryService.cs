using Accept_Northwnd_Entities.Concrete;
using System.Collections.Generic;

namespace Accept.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
