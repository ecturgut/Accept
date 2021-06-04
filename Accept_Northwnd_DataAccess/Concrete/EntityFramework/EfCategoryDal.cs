using Accept.Core.DataAccess.EntityFramework;
using Accept.Northwnd.DataAccess.Absctract;
using Accept_Northwnd_Entities.Concrete;

namespace Accept.Northwnd.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EFEntityRepositoryBase<Category, NorthwndContext>,ICategoryDal
    {

    }
}
