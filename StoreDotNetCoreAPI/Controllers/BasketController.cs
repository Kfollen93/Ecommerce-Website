﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreDotNetCoreAPI.Data;
using StoreDotNetCoreAPI.Entities;
using System;
using System.Threading.Tasks;

namespace StoreDotNetCoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BasketController : ControllerBase
    {
        private readonly StoreContext _context;
        public BasketController(StoreContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<Basket>> GetBasket()
        {
            var basket = await RetrieveBasket();

            if (basket == null) return NotFound();
            return Ok(basket);
        }



        [HttpPost]
        public async Task<ActionResult> AddItemToBasket(int productId, int quantity)
        {
            var basket = await RetrieveBasket();
            if (basket == null) basket = CreateBasket();

            var product = await _context.Products.FindAsync(productId);
            if (product == null) return NotFound();
            basket.AddItem(product, quantity);

            var results = await _context.SaveChangesAsync() > 0;
            if (results) return StatusCode(201);

            return BadRequest(new ProblemDetails { Title = "Problem saving item to basket."});
        }



        [HttpDelete]
        public async Task<ActionResult> RemoveItemFromBasket(int productId, int quantity)
        {
            // Get basket
            // remove item or reduce quantity
            // save changes.
            return Ok();
        }

        private async Task<Basket> RetrieveBasket()
        {
            return await _context.Baskets
                .Include(i => i.Items)
                .ThenInclude(p => p.Product)
                .FirstOrDefaultAsync(x => x.BuyerId == Request.Cookies["buyerId"]);
        }

        private Basket CreateBasket()
        {
            var buyerId = Guid.NewGuid().ToString();
            var cookieOptions = new CookieOptions { IsEssential = true, Expires = DateTime.Now.AddDays(30) };
            Response.Cookies.Append("buyerId", buyerId, cookieOptions);
            var basket = new Basket { BuyerId = buyerId };
            _context.Baskets.Add(basket);
            return basket;
        }
    }
}
