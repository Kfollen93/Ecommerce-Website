namespace StoreDotNetCoreAPI.DTOs
{
    public class BasketItemDTO
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public long Price { get; set; }
        public string PictureUrl { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public int Quantity { get; set; }
    }
}