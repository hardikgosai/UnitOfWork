namespace Getri_UnitOfWork.DTO
{
    public class CreateProductForUserDTO
    {
        public int UserId { get; set; }

        public string ProductName { get; set; }

        public string ProductDesc { get; set; }

        public int ProductPrice { get; set; }

        public string ProductCategory { get; set; }
    }
}
