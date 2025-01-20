namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order(10,"adel",500);
            Console.WriteLine("Enter the type of order type (online||in-store");
            string OrderType = Console.ReadLine();
            if(OrderType == "online")
            {
                OnlineOrderProcessor onlineOrderProcessor = new OnlineOrderProcessor();
                Console.WriteLine(onlineOrderProcessor.CalculateDiscount(100));
                Console.WriteLine("Order 101 processed for John. Final amount after 10% discount: $90.0");
            }
            else
            {
                InStoreOrderProcessor onlineOrderProcessor = new InStoreOrderProcessor();
                Console.WriteLine(onlineOrderProcessor.CalculateDiscount(100));
                Console.WriteLine("Order 102 processed for Jane. Final amount after 5% discount: $95.0");

            }
             

        }
    }
}
