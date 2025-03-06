namespace ClassExample
{
    using ClassExampleController.Interfaces;

    /// <summary>
    /// Main window of the application.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Form1 : Form
    {
        private readonly ICalculator Calculator;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1" /> class.
        /// </summary>
        /// <param name="calculator">The calculator.</param>
        public Form1(ICalculator calculator)
        {
            InitializeComponent();
            this.Calculator = calculator;
        }

        private void Btn_sumar_Click(object sender, EventArgs e)
        {
            if (this.ValidateInputs(tbx_input1.Text, out var value1) && this.ValidateInputs(tbx_Input2.Text, out var value2))
            {
                tbx_Result.Text = Calculator.Add(value1, value2).ToString();
            }
        }

        private bool ValidateInputs(string input, out int value1)
        {
            var isValidValue1 = int.TryParse(input, out value1);
            if (!isValidValue1)
            {
                MessageBox.Show("Please enter valid inputs");
                tbx_Result.Text = "Por favor valide las entradas";
                return false;
            }
            return true;
        }

        private void btn_restar_Click(object sender, EventArgs e)
        {
            if (this.ValidateInputs(tbx_input1.Text, out var value1) && this.ValidateInputs(tbx_Input2.Text, out var value2))
            {
                tbx_Result.Text = Calculator.Subtract(value1, value2).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.ValidateInputs(tbx_input1.Text, out var value1) && this.ValidateInputs(tbx_Input2.Text, out var value2))
            {
                tbx_Result.Text = Calculator.Multiply(value1, value2).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateInputs(tbx_input1.Text, out var value1) && this.ValidateInputs(tbx_Input2.Text, out var value2))
            {
                var result = Calculator.Divide(value1, value2);
                if (result == -1)
                {
                    MessageBox.Show("No se puede dividir por cero");
                    tbx_Result.Text = "No se puede dividir por cero";
                }
                else
                {
                    tbx_Result.Text = result.ToString();
                }
            }
        }

        private void Btn_FileHandler_Click(object sender, EventArgs e)
        {
            var fileHandler = new FileHandlerForm();
            fileHandler.Show();
        }
    }
}
