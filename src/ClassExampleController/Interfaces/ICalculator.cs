namespace ClassExampleController.Interfaces
{
    /// <summary>
    /// Template for calculator.
    /// </summary>
    public interface ICalculator
    {
        /// <summary>
        /// Adds the specified input1.
        /// </summary>
        /// <param name="input1">input1.</param>
        /// <param name="input2">The input2.</param>
        /// <returns></returns>
        int Add(int input1, int input2);

        /// <summary>
        /// Subtracts the specified input1.
        /// </summary>
        /// <param name="input1">The input1.</param>
        /// <param name="input2">The input2.</param>
        /// <returns></returns>
        int Subtract(int input1, int input2);

        /// <summary>
        /// Multiplies the specified input1.
        /// </summary>
        /// <param name="input1">The input1.</param>
        /// <param name="input2">The input2.</param>
        /// <returns></returns>
        int Multiply(int input1, int input2);

        /// <summary>
        /// Pows the specified input1.
        /// </summary>
        /// <param name="input1">The input1.</param>
        /// <param name="input2">The input2.</param>
        /// <returns></returns>
        double Pow(int input1, int input2);

        /// <summary>
        /// Divides the specified input1.
        /// </summary>
        /// <param name="input1">The input1.</param>
        /// <param name="input2">The input2.</param>
        /// <returns>
        ///    returns -1 if divide by zero.
        ///    returns the result of division.
        /// </returns>
        int Divide(int input1, int input2);
    }
}
