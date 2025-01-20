using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Order
    {
       public int OrderId {  get; set; }
        public string CustomerName { get; set; }
      public  decimal OrderAmount {  get; set; }
         

       IOrderProcessor OrderProcessor;
        public Order(int orderid,string customername,decimal Orderamount)
        {
            OrderId= orderid;
            CustomerName= customername;
            OrderAmount= Orderamount;
        }


    }
}
