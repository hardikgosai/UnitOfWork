using Getri_UnitOfWork.DTO;
using Getri_UnitOfWork.Models;
using Getri_UnitOfWork.UOW;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Getri_UnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProductController : ControllerBase
    {
        private readonly IUnitOfWorkUOW unitOfWork;

        public UserProductController(IUnitOfWorkUOW _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        [HttpPost("CreateUserProduct")]
        public int Create(UserProductDTO userProductDTO)
        {
            User user = new User
            {
                UserName = userProductDTO.UserName,
                UserEmail = userProductDTO.UserEmail,
                UserContactNo = userProductDTO.UserContactNo,
                UserAddress = userProductDTO.UserAddress
            };

            Product product = new Product
            {
                ProductName = userProductDTO.ProductName,
                ProductDesc = userProductDTO.ProductDesc,
                ProductPrice = userProductDTO.ProductPrice,
                ProductCategory = userProductDTO.ProductCategory,                
                User = user
            };

            //unitOfWork.User.AddUser(user);
            unitOfWork.Product.AddProduct(product);
            unitOfWork.Complete();
            unitOfWork.Dispose();
            return 1;
        }

        [HttpPost("CreateProductForUser")]
        public int CreateProductForUser(CreateProductForUserDTO createProductForUserDTO)
        {
            Product product = new Product
            {
                ProductName = createProductForUserDTO.ProductName,
                ProductDesc = createProductForUserDTO.ProductDesc,
                ProductPrice = createProductForUserDTO.ProductPrice,
                ProductCategory = createProductForUserDTO.ProductCategory,
                User = unitOfWork.User.GetUser(createProductForUserDTO.UserId)
            };

            unitOfWork.Product.AddProduct(product);
            unitOfWork.Complete();
            unitOfWork.Dispose();
            
            return 1;
        }        
    }
}
