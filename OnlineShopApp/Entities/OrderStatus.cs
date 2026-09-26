using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopApp.Entities
{
    public enum OrderStatus
    {
        Pending,
        Paid,
        Shipped,
        Delivered,
        Cancelled
    }
}