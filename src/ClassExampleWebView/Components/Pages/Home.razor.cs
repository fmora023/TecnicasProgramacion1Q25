using ClassExampleController.Interfaces;
using ClassExampleController;
using ClassExampleWebView.Components.Models;
using Microsoft.AspNetCore.Components;

namespace ClassExampleWebView.Components.Pages
{
    public partial class Home
    {
        [Inject]
        private NavigationManager NavigationManager { get; set; } = default!;

        internal CalculatorModel CalculatorModel = new CalculatorModel();

        internal ICalculator Calculator = new Calculator();

        private void Add()
        {
            CalculatorModel.Result = Calculator.Add(CalculatorModel.Value1, CalculatorModel.Value2);
            this.StateHasChanged();
        }

        private void OpenData()
        {
            NavigationManager.NavigateTo("/filehandler");
        }
    }
}
