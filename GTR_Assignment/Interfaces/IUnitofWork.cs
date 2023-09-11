using GTR_Assignment.EF.Model;

namespace GTR_Assignment.Interfaces
{
    public interface IUnitofWork: IDisposable
    {
        IUserRepo Users { get; }
        Task CompleteAsync();
    }
}
