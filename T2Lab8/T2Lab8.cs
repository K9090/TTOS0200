using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class ShoppingCart
    {
        List<ShoppingCart> cart = new List<ShoppingCart>();
    }

    class Product : ShoppingCart
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            try
            {
                return "\tName of item: " + Name + " and price: " + Price;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
