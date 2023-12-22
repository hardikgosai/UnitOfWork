using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Getri_UnitOfWork.Models
{
    public class ProductMap
    {
        public ProductMap(EntityTypeBuilder<Product> entityBuilder)
        {
            entityBuilder.HasKey(t => t.ProductId);
            entityBuilder.Property(t => t.ProductName).IsRequired();
            entityBuilder.Property(t => t.ProductName).HasMaxLength(50);
            entityBuilder.Property(t => t.ProductPrice).IsRequired();
            entityBuilder.Property(t => t.ProductCategory).IsRequired();
            //entityBuilder.HasOne(t => t.User).WithMany(t => t.Products).HasForeignKey(t => t.UserId);
        }
    }
}
