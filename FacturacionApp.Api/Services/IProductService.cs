using FacturacionApp.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FacturacionApp.Api.Services{

    public interface IProductService{
        Task<IReadOnlyList<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(int id);
    }
}