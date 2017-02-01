using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.T2Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            FillCart();
        }

        static void FillCart()
        {
            List<ShoppingCart> cart = new List<ShoppingCart>();

            cart.Add(new Product { Name = "Coca-cola", Price = 1.59 });
            cart.Add(new Product { Name = "Old Pascas rum", Price = 24.99 });
            cart.Add(new Product { Name = "Cabbage", Price = 1.25 });

            Console.WriteLine("Products in cart");
            Console.WriteLine("-------------------------------------");
            foreach (var item in cart)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
        }
    }
}
