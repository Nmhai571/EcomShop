using eShopSolution.Api.Contracts.Enums;

namespace eShopSolution.Api.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipEmail { get; set; }
        public string ShipPhoneNumber { get; set; }

        public Guid UserId { get; set; }
        public OrderStatus Status { set; get; }

        public List<OrderDetail> OrderDetails { get; set; }

        public AppUser AppUser { get; set; }
    }
}
