using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product("Bag of Chips", 2.99),
                new Product("Bag of Chips", 2.99),
                new Product("Bag of Chips", 2.99),
                new Product("Bag of Chips", 2.99),
                new Product("Bunch of Bananas", 2.50),
                new Product("Bunch of Bananas", 2.50),
                new Product("Bunch of Bananas", 2.50),
                new Product("Coffee", 4.50),
                new Product("Coffee", 4.50),
                new Product("Coffee", 4.50)
            };

            Order order = new Order();
            order.Add(products);

            Console.WriteLine("The price for the order is: " + order.GetTotalPrice());
            Console.WriteLine("Discount recieved: " + order.Discount);
            Console.ReadLine();
        }
    }
}
