using System;
namespace Proxy.Structural
{
    /// <summary>
    /// Proxy Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create proxy and request a service
            DPM225440_TranVanLuan_Pattern12_Proxy.Proxy proxy = new DPM225440_TranVanLuan_Pattern12_Proxy.Proxy();
            proxy.Request();
            // Wait for user
            Console.ReadKey();
        }
    }

}