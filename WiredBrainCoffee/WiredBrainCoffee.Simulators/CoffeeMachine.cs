using System;
using WiredBrainCoffee.Storage;

namespace WiredBrainCoffee.Simulators
{
    public class CoffeeMachine
    {
        public int CounterCappuccino { get; private set; }

        private CoffeeMachineStateSaver _coffeeMachineStateSaver;        

        public CoffeeMachine()
        {
            _coffeeMachineStateSaver = new CoffeeMachineStateSaver();
            CounterCappuccino = _coffeeMachineStateSaver.Load().CounterCappuccino;
        }

        public void MakeCappuccino()
        {
            CounterCappuccino++;
            Console.WriteLine($"Counter Cappuccino: {CounterCappuccino}");
            _coffeeMachineStateSaver.Save(new CoffeeMachineState { CounterCappuccino = CounterCappuccino});
        }
    }
}
