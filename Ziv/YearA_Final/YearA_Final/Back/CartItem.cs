using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CartItem
{
    public string Name { get; set; }
    public double Price { get; set; }
    public bool Cool { get; set; }
    public int Quantity { get; set; }
    public string ExpiryDate { get; set; }
    private List<CartItem> cartItems = new List<CartItem>();
}

