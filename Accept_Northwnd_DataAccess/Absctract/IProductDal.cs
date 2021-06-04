using Accept.Core.DataAccess;
using Accept_Northwnd_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accept.Northwnd.DataAccess.Absctract
{
    public interface IProductDal : IEntityRepository<Product>
    {

    }
}
