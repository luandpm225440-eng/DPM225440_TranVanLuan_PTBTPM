using DPM225440_TranVanLuan_Pattern11_Flyweight;
using System;
using System.Collections.Generic;
namespace Flyweight.Structural
{
    /// <summary>
    /// Flyweight Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Arbitrary extrinsic state
            int extrinsicstate = 22;
            FlyweightFactory factory = new FlyweightFactory();
            // Work with different flyweight instances
            DPM225440_TranVanLuan_Pattern11_Flyweight.Flyweight fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicstate);
            DPM225440_TranVanLuan_Pattern11_Flyweight.Flyweight fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);
            DPM225440_TranVanLuan_Pattern11_Flyweight.Flyweight fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);
            UnsharedConcreteFlyweight fu = new
                UnsharedConcreteFlyweight();
            fu.Operation(--extrinsicstate);
            // Wait for user
            Console.ReadKey();
        }
    }

}