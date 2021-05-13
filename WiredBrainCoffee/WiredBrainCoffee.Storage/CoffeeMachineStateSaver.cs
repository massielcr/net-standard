using Newtonsoft.Json;
using System.IO;
using System.Windows;

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

        //only for WPF
        public void ShowStoredJson()
        {
            var json = File.Exists(_fileName) ? File.ReadAllText(_fileName) : "<empty>";
            var window = new Window
            {
                Title = "Stored JSON",
                Content = json,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                FontSize = 20,
                Width = 300,
                Height = 300
            };

            window.Show();
        }
    }
}
