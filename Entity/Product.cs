using RannaProductProject.Core.Entity;

namespace RannaProductProject.Entity
{
    public class Product: IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Stock { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Image { get; set; }
    }
}
