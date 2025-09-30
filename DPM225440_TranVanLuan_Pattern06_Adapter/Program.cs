using DPM225440_TranVanLuan_Pattern06_Adapter;
using System;
namespace Adapter.Structural
{
    /// <summary>
    /// Adapter Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create adapter and place a request
            Target target = new DPM225440_TranVanLuan_Pattern06_Adapter.Adapter();
            target.Request();
            // Wait for user
            Console.ReadKey();
        }
    }
}