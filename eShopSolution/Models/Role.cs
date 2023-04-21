using Microsoft.AspNetCore.Identity;

namespace eShopSolution.Api.Models
{
    public class Role : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
