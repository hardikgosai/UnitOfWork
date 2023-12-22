using Getri_UnitOfWork.EntityFramework;
using Getri_UnitOfWork.Repository;

namespace Getri_UnitOfWork.UOW
{
    public class UnitOfWorkUOW : IUnitOfWorkUOW
    {
        private readonly ApplicationDbContext dbContext;

        public UnitOfWorkUOW(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;         
        }

        private IUserRepository _user;
        public IUserRepository User
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(dbContext);
                }
                return _user;
            }
        }

        private IProductRepository _product;
        public IProductRepository Product
        {
            get
            {
                if (_product == null)
                {
                    _product = new ProductRepository(dbContext);
                }
                return _product;
            }
        }

        public int Complete()
        {
            return dbContext.SaveChanges();
        }

        public void Dispose()
        {
            dbContext?.Dispose();
        }
    }
}
