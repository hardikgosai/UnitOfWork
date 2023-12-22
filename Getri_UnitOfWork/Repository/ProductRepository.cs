using Getri_UnitOfWork.EntityFramework;
using Getri_UnitOfWork.Models;

namespace Getri_UnitOfWork.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ProductRepository(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public void AddProduct(Product product)
        {
            dbContext.Product.Add(product);
        }

        public bool DeleteProduct(int productId)
        {
            var isDeleted = false;
            var product = GetProduct(productId);
            if (product != null)
            {
                dbContext.Product.Remove(product);
                isDeleted = true;
            }
            
            return isDeleted;
        }

        public Product GetProduct(int productId)
        {
            return dbContext.Product.Find(productId);
        }

        public IEnumerable<Product> GetProducts()
        {
            return dbContext.Product.ToList();
        }

        public void UpdateProduct(Product product)
        {
            var productToUpdate = dbContext.Product.Find(product.ProductId);
            if (productToUpdate != null)
            {
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.ProductPrice = product.ProductPrice;
                productToUpdate.ProductDesc = product.ProductDesc;
                productToUpdate.ProductCategory = product.ProductCategory;
                dbContext.Product.Update(productToUpdate);
            }
        }
    }
}
