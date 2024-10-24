using RannaProductProject.DataAccess.Abstract;
namespace RannaProductProject.Utilities
{
    // IUnitOfWork.cs
    public interface IUnitOfWork : IDisposable
    {
        IProductDal Products { get; }
        int Complete();
    }
}
