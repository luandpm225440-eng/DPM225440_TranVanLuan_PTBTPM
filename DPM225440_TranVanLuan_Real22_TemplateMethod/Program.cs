using System;
using System.Collections.Generic;
using DPM225440_TranVanLuan_Real22_TemplateMethod;
namespace Template.RealWorld
{
    /// <summary>
    /// Template Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            DataAccessor categories = new Categories();
            categories.Run(5);
            DataAccessor products = new Products();
            products.Run(3);
            // Wait for user
            Console.ReadKey();
        }
    }
}