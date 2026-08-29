using Microsoft.EntityFrameworkCore;
using FacturacionApp.Api.Models;

namespace FacturacionApp.Api.Data
{
    public class BillingDbContext : DbContext
    {
        public BillingDbContext(DbContextOptions<BillingDbContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<ProductPrice> ProductsPrice { get; set; }
        public DbSet<PriceList> PriceLists { get; set; }
    }
}