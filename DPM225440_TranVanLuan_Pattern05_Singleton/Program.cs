using System;
namespace Singleton.Structural
{
    /// <summary>
    /// Singleton Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Constructor is protected -- cannot use new
            DPM225440_TranVanLuan_Pattern05_Singleton.Singleton s1 = DPM225440_TranVanLuan_Pattern05_Singleton.Singleton.Instance();
            DPM225440_TranVanLuan_Pattern05_Singleton.Singleton s2 = DPM225440_TranVanLuan_Pattern05_Singleton.Singleton.Instance();
            // Test for same instance
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }
            // Wait for user
            Console.ReadKey();
        }
    }
}