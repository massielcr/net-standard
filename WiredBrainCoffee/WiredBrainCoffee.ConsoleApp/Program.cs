using System;
using WiredBrainCoffee.Simulators;

namespace WiredBrainCoffee.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var coffeeMachine = new CoffeeMachine();

            coffeeMachine.MakeCappuccino();
            Console.WriteLine($"Counter Cappuccino: {coffeeMachine.CounterCappuccino}");

            coffeeMachine.ShowStoredState();

            Console.ReadLine();
        }
    }
}
