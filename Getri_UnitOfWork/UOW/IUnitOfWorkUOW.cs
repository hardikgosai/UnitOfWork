using Getri_UnitOfWork.Repository;

namespace Getri_UnitOfWork.UOW
{
    public interface IUnitOfWorkUOW
    {
        IUserRepository User { get; }

        IProductRepository Product { get; }

        int Complete();

        void Dispose();
    }
}
