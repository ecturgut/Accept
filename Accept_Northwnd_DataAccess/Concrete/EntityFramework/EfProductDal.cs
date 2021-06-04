using Accept.Core.DataAccess.EntityFramework;
using Accept.Northwnd.DataAccess.Absctract;
using Accept_Northwnd_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accept.Northwnd.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EFEntityRepositoryBase<Product, NorthwndContext>, IProductDal
    {

    }
}
