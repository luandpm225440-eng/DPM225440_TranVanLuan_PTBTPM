using System;
using DPM225440_TranVanLuan_Pattern10_Facade;
namespace Facade.Structural
{
    /// <summary>
    /// Facade Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            DPM225440_TranVanLuan_Pattern10_Facade.Facade facade = new DPM225440_TranVanLuan_Pattern10_Facade.Facade();
            facade.MethodA();
            facade.MethodB();
            // Wait for user
            Console.ReadKey();
        }
    }
}