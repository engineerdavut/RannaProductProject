using RannaProductProject.Business.Abstract;
using RannaProductProject.DataAccess.Abstract;
using RannaProductProject.Entity;
namespace RannaProductProject.Business.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserDal _userDal;

        public UserService(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }
        public User GetByUsernameAndPassword(string userName, string password)
        {
            return _userDal.GetByUsernameAndPassword(userName, password);
        }

        public User GetById(int id)
        {
            return _userDal.Get(u => u.Id == id);
        }

        public void Create(User user)
        {
            _userDal.Add(user);
        }

        public void Update(int id,User user)
        {
            _userDal.Update(id,user);
        }

        public void Delete(int id)
        {
            _userDal.Delete(id);
        }
    }
}
