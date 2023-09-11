using GTR_Assignment.EF.Model;
using Microsoft.AspNetCore.Identity;

namespace GTR_Assignment.Interfaces
{
    public interface IUserRepo: IRepo<User>
    {
        Task<User?> Login(string username, string password);
    }
}
