using System.Linq.Expressions;
using System.Security.Principal;

namespace GTR_Assignment.Interfaces
{
    public interface IRepo<T> where T :class
    {
        Task<IEnumerable<T>> All();
        Task<T?> GetById(int id);
        Task<bool> Add(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity);
    }
}
