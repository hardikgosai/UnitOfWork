namespace Getri_UnitOfWork.Models
{
    public class Product
    {
        public long ProductId { get; set; }

        public string ProductName { get; set; } 

        public string ProductDesc { get; set; }

        public int ProductPrice { get; set; }  

        public string ProductCategory { get; set; }

        public User User { get; set; }
    }
}
