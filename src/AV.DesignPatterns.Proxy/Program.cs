using AV.DesignPatterns.Proxy.Services;

namespace AV.DesignPatterns.Proxy;

public static class Program
{
    private static void Main()
    {
        var client = new ProxyService(new Service());

        while (true)
        {
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine(DateTime.Now);

            var orders = client.GetOrders();

            foreach (var order in orders)
            {
                var status = client.GetStatuses().First(x => x.Key == order.StatusId).Value;
                Console.WriteLine($"{order.Name}\t\t{status}");
            }
        }
    }
}

