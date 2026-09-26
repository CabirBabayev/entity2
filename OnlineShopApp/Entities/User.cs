using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineShopApp.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        [EmailAddress]
        public string Email { get; set; } = null!;
        public string Phone {  get; set; } = null!;
        public DateTime CreatedAt {  get; set; }
        public bool IsActive { get; set; }
        public Address Address { get; set; }
        public List<Order> Orders { get; set; } = null!;
        public List<Review> Reviews { get; set; } = null!;

    }
}