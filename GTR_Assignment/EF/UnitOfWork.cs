using GTR_Assignment.DTOs;
using GTR_Assignment.Interfaces;
using GTR_Assignment.Repos;

namespace GTR_Assignment.EF
{
    public class UnitOfWork : IUnitofWork, IDisposable
    {
        private readonly GtrContext _context;
        private readonly HttpClient _http;

        public UnitOfWork(GtrContext context, IHttpClientFactory httpClientFactory)
        {
            _context = context;
            _http = httpClientFactory.CreateClient("HttpClient");
            Users = new UserRepo(_context);
            ProductCarts = new ProductCartRepo(_context);
            Products = new ProductRepo(_context, _http);
        }
        public IUserRepo Users { get; private set; }

        public IProductCartRepo ProductCarts { get; private set; }

        public IProductRepo Products { get; private set; }

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
