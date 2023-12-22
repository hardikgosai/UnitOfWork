using Getri_UnitOfWork.Models;

namespace Getri_UnitOfWork.Repository
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        bool DeleteProduct(int productId);
        IEnumerable<Product> GetProducts();
        Product GetProduct(int productId);
    }
}
