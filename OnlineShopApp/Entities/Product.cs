using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Text;

namespace OnlineShopApp.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public DateTime CreatedAt {  get; set; }
        public bool IsActive { get; set; }
        public List<OrderItem> OrderItems { get; set; } = null!;
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Review> Reviews { get; set; } = null!;
        public List<ProductTag> ProductTags { get; set; } = null!;
    }
}