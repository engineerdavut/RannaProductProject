using RannaProductProject.Business.Abstract;
using RannaProductProject.DataAccess.Abstract;
using RannaProductProject.Entity;
using RannaProductProject.Utilities;

namespace RannaProductProject.Business.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitWork;

        public ProductService(IUnitOfWork unitWork)
        {
            _unitWork = unitWork;
        }

        public List<Product> GetAll()
        {
            return _unitWork.Products.GetAll();
        }

        public Product GetById(int id)
        {
            return _unitWork.Products.Get(p => p.Id == id);
        }

        public void Create(Product product)
        {
            product.CreationDate = DateTime.Now;
            _unitWork.Products.Add(product);
            _unitWork.Complete();
        }

        public void Update(int id,Product product)
        {
            product.CreationDate = DateTime.Now;
            _unitWork.Products.Update(id, product);
            _unitWork.Complete();
        }

        public void Delete(int id)
        {
            _unitWork.Products.Delete(id);
            _unitWork.Complete();
        }
    }
}
