using System.Collections.Generic;

namespace StoreDotNetCoreAPI.DTOs
{
    public class BasketDTO
    {
        public int Id { get; set; }
        public string BuyerId { get; set; } = string.Empty;
        public List<BasketItemDTO> Items { get; set; } = new List<BasketItemDTO>();
    }
}
