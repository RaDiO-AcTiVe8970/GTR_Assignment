using GTR_Assignment.EF.Model;

namespace GTR_Assignment.Interfaces
{
    public interface IProductCartRepo : IRepo<ProductCart>
    {
        //Task<double> GetTotalPrice (int userId);
        Task<List<ProductCart?>> GetByUserId(int userId);
        
    }
}
