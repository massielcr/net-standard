using Newtonsoft.Json;
using System.IO;

namespace WiredBrainCoffee.Storage
{
    public class CoffeeMachineStateSaver
    {
        private string _fileName = "machine.json";

        public void Save(CoffeeMachineState state)
        {
            var json = JsonConvert.SerializeObject(state);
            File.WriteAllText(_fileName, json);
        }

        public CoffeeMachineState Load()
        {
            if (File.Exists(_fileName))
            {
                var json = File.ReadAllText(_fileName);
                return JsonConvert.DeserializeObject<CoffeeMachineState>(json);
            }

            return new CoffeeMachineState();
        }
    }
}
