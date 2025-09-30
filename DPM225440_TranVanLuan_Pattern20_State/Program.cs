using System;
namespace State.Structural
{
    /// <summary>
    /// State Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Setup context in a state
            var context = new DPM225440_TranVanLuan_Pattern20_State.Context(new DPM225440_TranVanLuan_Pattern20_State.ConcreteStateA());
            // Issue requests, which toggles state
            context.Request();
            context.Request();
            context.Request();
            context.Request();
            // Wait for user
            Console.ReadKey();
        }
    }
}