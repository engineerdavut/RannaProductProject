using RannaProductProject.Utilities;
using RannaProductProject.DataAccess.Concrete;
using RannaProductProject.DataAccess.Abstract;
using RannaProductProject.Core.DataAccess;
namespace RannaProductProject.Utilities
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Products = new ProductDal(_context);
        }

        public IProductDal Products { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
