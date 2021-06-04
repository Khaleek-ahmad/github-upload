using ShopBridge.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridgeService
{
    public interface IProductServices
    {
        Task<Product> Add(Product product);

        Task<List<Product>> GetAll();
        Task<Product> Get(Guid id);        
        Task<Product> Update(Product entity);
        Task<Product> Delete(Guid id);
    }
}
