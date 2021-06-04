using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopBridge.Model;
using ShopBridgeService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopBridge.Controllers
{
    [Route("api/[controller]")]    
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices productServices;
        public ProductController(IProductServices productServices)
        {
            this.productServices = productServices;
        }

        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> Get()
        {
            return await this.productServices.GetAll();
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Get(Guid id)
        {
            if (id == Guid.Empty)
                throw new ArgumentNullException(nameof(id));

            var product = await this.productServices.Get(id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Product>> Put(Guid id, Product product)
        {
            if (id == Guid.Empty)
                throw new ArgumentNullException(nameof(id));

            if (id != product.Id)
            {
                return BadRequest();
            }            

            return await this.productServices.Update(product);          
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<Product>> Post(Product product)
        {            
            await this.productServices.Add(product);
            return CreatedAtAction("Get", new { id = product.Id }, product);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> Delete(Guid id)
        {
            if (id == Guid.Empty)
                throw new ArgumentNullException(nameof(id));

            var product = await this.productServices.Delete(id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }

    }
}
