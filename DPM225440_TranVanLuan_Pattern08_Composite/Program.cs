using DPM225440_TranVanLuan_Pattern08_Composite;
using System;
using System.Collections.Generic;
namespace Composite.Structural
{
    /// <summary>
    /// Composite Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a tree structure
            DPM225440_TranVanLuan_Pattern08_Composite.Composite root = new DPM225440_TranVanLuan_Pattern08_Composite.Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));
            DPM225440_TranVanLuan_Pattern08_Composite.Composite comp = new DPM225440_TranVanLuan_Pattern08_Composite.Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));
            root.Add(comp);
            root.Add(new Leaf("Leaf C"));
            // Add and remove a leaf
            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);
            // Recursively display tree
            root.Display(1);
            // Wait for user
            Console.ReadKey();
        }
    }
}