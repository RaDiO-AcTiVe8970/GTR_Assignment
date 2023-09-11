using GTR_Assignment.EF.Model;

namespace GTR_Assignment.Interfaces
{
    public interface IUnitofWork: IDisposable
    {
        IUserRepo Users { get; }
        IProductCartRepo ProductCarts { get; }
        IProductRepo Products { get; }
        Task CompleteAsync();
    }
}
