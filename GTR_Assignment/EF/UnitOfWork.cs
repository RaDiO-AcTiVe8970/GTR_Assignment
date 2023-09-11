using GTR_Assignment.Interfaces;
using GTR_Assignment.Repos;

namespace GTR_Assignment.EF
{
    public class UnitOfWork : IUnitofWork, IDisposable
    {
        private readonly GtrContext _context;

        public UnitOfWork(GtrContext context)
        {
            _context = context;
            Users = new UserRepo(_context);
        }
        public IUserRepo Users { get; }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
