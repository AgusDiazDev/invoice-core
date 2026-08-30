using FacturacionApp.Api.Models;
using FacturacionApp.Api.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace FacturacionApp.Api.Services{
    public class ProductService : IProductService{

        private readonly IProductRepository _productRepository;

        public ProductService (IProductRepository ProductRepository){

            _productRepository = ProductRepository;
        
        }
        
        public async Task<IReadOnlyList<Product>>GetAllProductsAsync(){
            return await _productRepository.GetAllAsync();
        }

        public async Task<Product?> GetProductByIdAsync(int id){

            return await _productRepository.GetByIdAsync(id);

        }

        public async Task AddProductAsync(Product product){
            if(product.name == null){
                throw new ArgumentNullException("El nombre del producto no puede ser nulo");
            }
            await _productRepository.AddAsync(product);
        }

        public async Task UpdateProductAsync(Product product){
            var existingProduct = await _productRepository.GetByIdAsync(product.id);
            if(existingProduct == null){
                throw new Exception("El producto no existe.");
            }else{
                await _productRepository.UpdateAsync(product);
            }

        }

        public async Task DeleteProductAsync(int id){
            var existingProduct = await _productRepository.GetByIdAsync(id);
            if(existingProduct != null){
                await _productRepository.DeleteAsync(id);
                Console.WriteLine("Producto eliminado con exito");
            }else{
                throw new Exception("Producto no encontrado");
            }
        }
    }
}