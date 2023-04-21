using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Api.Contracts.Enums
{
    public enum OrderStatus
    {
        InProgress,
        Confirmed,
        Shipping,
        Success,
        Canceled
    }
}
