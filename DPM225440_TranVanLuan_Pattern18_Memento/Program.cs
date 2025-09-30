﻿using DPM225440_TranVanLuan_Pattern18_Memento;
using System;
namespace Memento.Structural
{
    /// <summary>
    /// Memento Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Originator o = new Originator();
            o.State = "On";
            // Store internal state
            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();
            // Continue changing originator
            o.State = "Off";
            // Restore saved state
            o.SetMemento(c.Memento);
            // Wait for user
            Console.ReadKey();
        }
    }
}