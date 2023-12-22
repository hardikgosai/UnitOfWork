using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Getri_UnitOfWork.Models
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> entityBuilder)
        {
            entityBuilder.HasKey(t => t.UserId);
            entityBuilder.Property(t => t.UserName).IsRequired();
            entityBuilder.Property(t => t.UserName).HasMaxLength(50);
            entityBuilder.Property(t => t.UserEmail).IsRequired();            
            entityBuilder.Property(t => t.UserContactNo).IsRequired();
            entityBuilder.Property(t => t.UserContactNo).HasMaxLength(15);
            entityBuilder.Property(t => t.UserAddress).IsRequired();
            entityBuilder.Property(t => t.UserAddress).HasMaxLength(50);
            //entityBuilder.HasMany(t => t.Products).WithOne(t => t.User).HasForeignKey(t => t.UserId);
        }
    }
}
