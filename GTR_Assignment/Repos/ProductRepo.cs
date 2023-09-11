using GTR_Assignment.DTOs;
using GTR_Assignment.EF;
using GTR_Assignment.Interfaces;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

namespace GTR_Assignment.Repos
{
    public class ProductRepo : BaseRepo<ProductDTO>, IProductRepo
    {
        private readonly HttpClient _http;
        private List<ProductDTO> _cachedProducts;

        public ProductRepo(GtrContext context, HttpClient http) : base(context)
        {
            _http = http;
        }
        public override async Task<IEnumerable<ProductDTO>> All()
        {
            if (_cachedProducts == null)
            {
                await FetchProductsAsync();
            }

            return _cachedProducts;
        }

        public override async Task<ProductDTO?> GetById(int id)
        {
            if (_cachedProducts == null)
            {
                await FetchProductsAsync();
            }

            return _cachedProducts.FirstOrDefault(x => x.Id == id);
        }
        private async Task FetchProductsAsync()
        {
            var response = await _http.GetAsync("https://www.pqstec.com/InvoiceApps/values/GetProductListAll");
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();
            _cachedProducts = JsonConvert.DeserializeObject<List<ProductDTO>>(result);
        }
    }
}
