using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discounter;

namespace IDiscounterStrat
{
    interface IDiscountStrat
    {
        double ApplyDiscount(List<Product> products);
    }
}