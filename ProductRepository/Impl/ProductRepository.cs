using ShopBridge.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBridgeRepository.Impl
{
    public class ProductRepository : Repository<Product, ApplicationDbContext>
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {

        }
        // We can add new methods specific to the product repository here in the future
    }
}
