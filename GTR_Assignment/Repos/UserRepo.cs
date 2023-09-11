using GTR_Assignment.EF;
using GTR_Assignment.EF.Model;
using GTR_Assignment.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GTR_Assignment.Repos
{
    public class UserRepo : BaseRepo<User>, IUserRepo
    {
        public UserRepo(GtrContext context) : base(context)
        {
        }

        public override async Task<User?> GetById(int id)
        {
            try
            {
                return await _context.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
