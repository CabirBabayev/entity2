using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace OnlineShopApp.Entities
{
    public class Coupon
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(30)]
        public string Code { get; set; } = null!;
        [Required]
        public decimal DiscountPercentage { get; set; }
        [Required]
        public DateTime ExpiresAt { get; set; }
        public bool IsActive { get; set; }
        public List<Order> Orders { get; set; } = null!;
    }
}