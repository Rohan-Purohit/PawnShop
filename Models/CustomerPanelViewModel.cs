using System.Collections.Generic;

namespace PawnShop.Models
{
    public class CustomerPanelViewModel
    {
        public User? User { get; set; }
        public IEnumerable<Product>? Products { get; set; }=new List<Product>();
    }
}
