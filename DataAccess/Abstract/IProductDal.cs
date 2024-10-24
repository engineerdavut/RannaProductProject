using RannaProductProject.Core.DataAccess;
using RannaProductProject.Entity;

namespace RannaProductProject.DataAccess.Abstract
{
    public interface IProductDal : IRepository<Product>
    {
        //Product GetByUsernameAndPassword(string userName, string password);
    }
}
