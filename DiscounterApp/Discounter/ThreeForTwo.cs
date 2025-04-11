using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDiscounterStrat;

namespace Discounter
{
    class ThreeForTwo : IDiscountStrat

    {
        private Dictionary<string, int> ThreeForTwoDiscount = new Dictionary<string, int>();

        public double ApplyDiscount(List<Product> products)
        {
            double Discount = 0.00;
            foreach (Product p in products)
            {
                if (!ThreeForTwoDiscount.ContainsKey(p.Name))
                {
                    ThreeForTwoDiscount[p.Name] = 1;
                }
                else
                {
                    ThreeForTwoDiscount[p.Name]++;
                }
                if (ThreeForTwoDiscount[p.Name] == 3)
                {
                    Discount += p.Price;
                    ThreeForTwoDiscount[p.Name] = 0;
                }
            }
            return Discount;
        }
    }
}
