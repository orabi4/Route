using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IOrderProcessor
    {
       public void ProcessOrder();
       public decimal CalculateDiscount(decimal orderAmount);
    }
}
