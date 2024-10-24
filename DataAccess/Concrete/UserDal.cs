using RannaProductProject.Core.DataAccess;
using RannaProductProject.Entity;
using RannaProductProject.DataAccess.Abstract;

namespace RannaProductProject.DataAccess.Concrete
{
    public class UserDal : EntityFrameworkBase<User, AppDbContext>, IUserDal
    {
        public UserDal(AppDbContext context) : base(context)
        {
        }
        public User GetByUsernameAndPassword(string userName, string password)
        {
            using (var context = new AppDbContext())
            {
                return context.Users
                              .FirstOrDefault(c => c.UserName == userName && c.Password == password);
            }
        }
    }
}
