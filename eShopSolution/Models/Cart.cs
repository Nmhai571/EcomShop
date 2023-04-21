using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Api.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quatity { get; set; }
        public decimal Price { get; set; }

        public Guid UserId { get; set; }
        public DateTime DateCreated { get; set; }

        public Product Product { get; set; }

        public AppUser AppUser { get; set; }
    }
}
