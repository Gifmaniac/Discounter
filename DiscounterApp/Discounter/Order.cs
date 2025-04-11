using IDiscounterStrat;
using System.Collections.Generic;

namespace Discounter
{
    public class Order

    {
        private List<Product> products = new List<Product>();
        private Dictionary<string, int> ThreeForTwoDiscount = new Dictionary<string, int>();
        IDiscountStrat threeForTwo = new ThreeForTwo();
        IDiscountStrat tenProductDiscount = new TenProductDiscount();
        private List<IDiscountStrat> discounts = new List<IDiscountStrat>();


        public IReadOnlyList<Product> Products
        {
            get { return this.products.AsReadOnly(); }
        }

        public double Discount { get; private set; } = 0.0;

        public void Add(Product product)
        {
            this.products.Add(product);
        }

        public void Add(List<Product> products)
        {
            this.products.AddRange(products);
        }

        public double GetTotalPrice()
        {
            double totalPrice = 0.0;

            foreach (Product product in products)
            {
                totalPrice += product.Price;
            }
            discounts.Add(threeForTwo);
            discounts.Add(tenProductDiscount);
            foreach (IDiscountStrat discount in discounts)
            {
                Discount += discount.ApplyDiscount(products);
            }
            totalPrice -= Discount;
            return totalPrice;
        }
    }
}
