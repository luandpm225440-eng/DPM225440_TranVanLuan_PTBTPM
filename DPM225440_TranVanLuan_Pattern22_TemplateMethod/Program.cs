using System;
using DPM225440_TranVanLuan_Pattern22_TemplateMethod;
namespace Template.Structural
{
    /// <summary>
    /// Template Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            AbstractClass aA = new ConcreteClassA();
            aA.TemplateMethod();
            AbstractClass aB = new ConcreteClassB();
            aB.TemplateMethod();
            // Wait for user
            Console.ReadKey();
        }
    }
}