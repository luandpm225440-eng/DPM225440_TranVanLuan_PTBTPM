using System;
using System.Collections.Generic;
using DPM225440_TranVanLuan_Pattern02_Builder;
namespace DoFactory.GangOfFour.Builder.Structural
{
    /// <summary>
    /// MainApp startup class for Structural
    /// Builder Design Pattern.
    /// </summary>
    public class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Main()
        {
            // Create director and builders
            Director director = new Director();
            DPM225440_TranVanLuan_Pattern02_Builder.Builder b1 = new ConcreteBuilder1();
            DPM225440_TranVanLuan_Pattern02_Builder.Builder b2 = new ConcreteBuilder2();
            // Construct two products
            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();
            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();
            // Wait for user
            Console.ReadKey();
        }
    }
}