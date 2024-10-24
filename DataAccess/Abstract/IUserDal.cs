using RannaProductProject.Core.DataAccess;
using RannaProductProject.Entity;

namespace RannaProductProject.DataAccess.Abstract
{
    public interface IUserDal : IRepository<User>
    {
        User GetByUsernameAndPassword(string userName, string password);
    }
}
