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
    }
}
