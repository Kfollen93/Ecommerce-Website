using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreDotNetCoreAPI.Data;
using StoreDotNetCoreAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreDotNetCoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _db;
        public ProductsController(StoreContext dbContext) => _db = dbContext;

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProductsAsync() => await _db.Products.ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductAsync(int id)
        {
            var product = await _db.Products.FindAsync(id);
            if (product == null) return NotFound();
            return product;
        }
    }
}
