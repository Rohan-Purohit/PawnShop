using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PawnShop.Models;

public partial class User
{
    public int UserId { get; set; }
    
    [Required]
    [StringLength(100)]
    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public string Role { get; set; } = null!;

    public DateTime? DateJoined { get; set; }

    public DateTime? LastLogin { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public virtual ShoppingCart? ShoppingCart { get; set; }

    public virtual Wishlist? Wishlist { get; set; }
}
