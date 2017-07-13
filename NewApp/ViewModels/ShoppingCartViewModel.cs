using System.Collections.Generic;
using NewApp.Models;

namespace NewApp.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}