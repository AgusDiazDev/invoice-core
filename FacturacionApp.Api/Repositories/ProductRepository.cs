using FacturacionApp.Api.Models;


namespace FacturacionApp.Api.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(FacturacionDbContext context) : base(context)
        {
        }
    }
}