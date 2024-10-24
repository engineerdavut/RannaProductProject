using RannaProductProject.Core.DataAccess;
using RannaProductProject.Entity;
using RannaProductProject.DataAccess.Abstract;

namespace RannaProductProject.DataAccess.Concrete
{
    public class ProductDal : EntityFrameworkBase<Product, AppDbContext>, IProductDal
    {
        public ProductDal(AppDbContext context) : base(context)
        {
        }
    }
}
