using IDiscounterStrat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounter
{
    class TenProductDiscount : IDiscountStrat

    {
        public double ApplyDiscount(List<Product> products)
        {
            double discount = 0.00;
            if (products.Count >= 10)
            {
                discount += 1;
            }
            return discount;
        }
    }
}
