using ShopBridge.Model;
using ShopBridgeRepository;
using ShopBridgeRepository.Impl;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopBridgeService
{
    public class ProductServices :IProductServices
    {
        private readonly ProductRepository productRepository;

        public ProductServices(ProductRepository productRepository)        
        {
            this.productRepository = productRepository;
        }
        public async Task<Product> Add(Product product)
        {
            return await this.productRepository.Add(product);
        }
        
        public async Task<List<Product>> GetAll()
        {
            return await this.productRepository.GetAll();
        }

        public async Task<Product> Get(Guid id)
        {
            var product = await this.productRepository.Get(id);           
            return product;
        }

        public async Task<Product> Update(Product product)
        {            
           return await this.productRepository.Update(product);            
        }

        public async Task<Product> Delete(Guid id)
        {
            var product = await this.productRepository.Delete(id);
            
            return product;
        }

    }
}
