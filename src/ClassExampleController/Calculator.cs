namespace ClassExampleController
{
    using ClassExampleController.Interfaces;

    /// <summary>
    /// Implements <see cref="ICalculator"/>.
    /// </summary>
    public class Calculator : ICalculator
    {
        /// <inheritdoc/>
        public int Add(int input1, int input2)
        {
            return input1 + input2;
        }

        /// <inheritdoc/>
        public int Divide(int input1, int input2)
        {
            if (input2 == 0)
            {
                return -1;
            }

            return input1 / input2;
        }

        /// <inheritdoc/>
        public int Multiply(int input1, int input2)
        {
            return input1 * input2;
        }

        /// <inheritdoc/>
        public int Subtract(int input1, int input2)
        {
            return input1 - input2;
        }
    }
}
