using Microsoft.EntityFrameworkCore;
using ServiceLayer.Data;
using ServiceLayer.Models;

namespace ServiceLayer.Services
{
    public class ProductService
    {
        private readonly ShopContext _context = new();
        public async Task<List<Product>> GetProductsAsync()
            => await _context.Products.ToListAsync();
    }
}
