using GTR_Assignment.EF;
using GTR_Assignment.EF.Model;
using GTR_Assignment.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GTR_Assignment.Repos
{
    public class ProductCartRepo : BaseRepo<ProductCart>, IProductCartRepo
    {
        public ProductCartRepo(GtrContext context) : base(context)
        {
        }

        public Task<List<ProductCart?>> GetByUserId(int userId)
        {
            try
            {
                var productCart = (from x in _context.ProductCarts where x.UserId == userId select x).ToListAsync();
                if (productCart != null)
                {
                    return productCart;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /*public Task<double> GetTotalPrice(int userId)
        {
            try
            {
                _context.ProductCarts.Where(x => x.UserId == userId).Include(x => x.Product).Load();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }*/
    }
}
