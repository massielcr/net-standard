using WiredBrainCoffee.Storage;

namespace WiredBrainCoffee.Simulators
{
    public class CoffeeMachine
    {
        private CoffeeMachineStateSaver _coffeeMachineStateSaver;
        public int CounterCappuccino { get; private set; }

        public CoffeeMachine()
        {
            _coffeeMachineStateSaver = new CoffeeMachineStateSaver();
            var state = _coffeeMachineStateSaver.Load();
            CounterCappuccino = state.CounterCappuccino;
        }                

        public void MakeCappuccino()
        {
            CounterCappuccino++;
            _coffeeMachineStateSaver.Save(new CoffeeMachineState { CounterCappuccino = CounterCappuccino});
        }
    }
}
