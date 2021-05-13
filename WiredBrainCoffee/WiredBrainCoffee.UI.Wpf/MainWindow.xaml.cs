using System.Windows;
using WiredBrainCoffee.Simulators;

namespace WiredBrainCoffee.UI.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CoffeeMachine coffeeMachine;
        public MainWindow()
        {
            InitializeComponent();
            coffeeMachine = new CoffeeMachine();
            txtCappuccinoCounter.Text = coffeeMachine.CounterCappuccino.ToString();
        }

        private void ButtonMakeCappuccinoClick(object sender, RoutedEventArgs e)
        {
            coffeeMachine.MakeCappuccino();
            txtCappuccinoCounter.Text = coffeeMachine.CounterCappuccino.ToString();
        }
    }
}
