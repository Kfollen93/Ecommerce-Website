using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreDotNetCoreAPI.Data;
using StoreDotNetCoreAPI.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace StoreDotNetCoreAPI.Controllers
{
    public class BasketController : ControllerBase
    {
        private readonly StoreContext _context;
        public BasketController(StoreContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<Basket>> GetBasket()
        {
            var basket = await _context.Baskets
                .Include(i => i.Items)
                .ThenInclude(p => p.Product)
                .FirstOrDefaultAsync(x => x.BuyerId == Request.Cookies["buyerId"]);

            if (basket == null) return NotFound();
            return Ok(basket);
        }

        [HttpPost]
        public async Task<ActionResult> AddItemToBasket(int productId, int quantity)
        {
            // Get Basket
            // Create basket if no basket exists.
            // Get Product
            // add item
            // save changes
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> RemoveItemFromBasket(int productId, int quantity)
        {
            // Get basket
            // remove item or reduce quantity
            // save changes.
            return Ok();
        }
    }
}
