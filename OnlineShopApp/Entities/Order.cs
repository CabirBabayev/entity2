using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineShopApp.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public int TotalAmount { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public List<OrderItem> OrderItems { get; set; } = null!;
        public Coupon Coupon { get; set; } = null!;
        public int CouponId { get; set; }
    }
}