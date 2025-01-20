using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class InStoreOrderProcessor : IOrderProcessor
    {
        public decimal CalculateDiscount(decimal orderAmount)
        {
            return orderAmount*0.05m;
        }

        public void ProcessOrder()
        {
            
        }
    }
}
