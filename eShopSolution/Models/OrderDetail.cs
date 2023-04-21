namespace eShopSolution.Api.Models
{
    public class OrderDetail
    {
        public int OrderId { set; get; }
        public int ProductId { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }

        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
