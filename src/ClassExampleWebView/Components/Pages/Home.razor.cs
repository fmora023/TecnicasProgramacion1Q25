using ClassExampleController.Interfaces;
using ClassExampleController;
using ClassExampleWebView.Components.Models;

namespace ClassExampleWebView.Components.Pages
{
    public partial class Home
    {
        internal CalculatorModel CalculatorModel = new CalculatorModel();

        internal ICalculator Calculator = new Calculator();

        private void Add()
        {
            CalculatorModel.Result = Calculator.Add(CalculatorModel.Value1, CalculatorModel.Value2);
            this.StateHasChanged();
        }
    }
}
