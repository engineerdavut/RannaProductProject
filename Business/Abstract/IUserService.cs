using RannaProductProject.Entity;

namespace RannaProductProject.Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetById(int id);
        User GetByUsernameAndPassword(string userName, string password);
        void Create(User user);
        void Update(int id,User user);
        void Delete(int id);

    }
}
