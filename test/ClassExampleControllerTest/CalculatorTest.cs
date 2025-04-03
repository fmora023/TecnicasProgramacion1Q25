using ClassExampleController;

namespace ClassExampleControllerTest
{
    /// <summary>
    /// Test for <see cref="Calculator"/>.
    /// </summary>
    [TestClass]
    public class CalculatorTest
    {
        /// <summary>
        /// Test the Adds method of the calculator.
        /// </summary>
        [TestMethod]
        public void AddTest()
        {
            // Arrange
            var calculator = new Calculator();
            var input1 = 7;
            var input2 = 15;

            // Act
            var result = calculator.Add(input1, input2);

            // Assert
            Assert.AreEqual(22, result);
        }

        /// <summary>
        /// Test the Divide method of the calculator.
        /// </summary>
        [TestMethod]
        public void DivideTest()
        {
            // Arrange
            var calculator = new Calculator();
            var input1 = 10;
            var input2 = 2;

            // Act
            var result = calculator.Divide(input1, input2);

            // Assert
            Assert.AreEqual(5, result);
        }

        /// <summary>
        /// Divides the by zero test.
        /// </summary>
        [TestMethod]
        //[ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZeroTest()
        {
            // Arrange
            var calculator = new Calculator();
            var input1 = 10;
            var input2 = 0;

            // Act in case throws exception.
            // Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(input1, input2));

            // Act
            var result = calculator.Divide(input1, input2);

            // Assert
            Assert.AreEqual(-1, result);
        }

        /// <summary>
        /// Test the power operation.
        /// </summary>
        [TestMethod]
        public void PowTest()
        {
            // Arrange
            var calculator = new Calculator();
            var input1 = 2;
            var input2 = 3;

            // Act
            var result = calculator.Pow(input1, input2);

            // Assert
            Assert.AreEqual(8, result);
        }

        /// <summary>
        /// Test the mult operation.
        /// </summary>
        [TestMethod]
        public void MultTest()
        {
            // Arrange 
            var calculator = new Calculator();
            var input1 = 5;
            var input2 = 5;

            // Act
            var result = calculator.Multiply(input1, input2);

            // Assert
            Assert.AreEqual(25, result);
        }

        /// <summary>
        /// Test the subtract operation.
        /// </summary>
        [TestMethod]
        public void SubtractTest()
        {
            // Arrange 
            var calculator = new Calculator();
            var input1 = 10;
            var input2 = 5;

            // Act
            var result = calculator.Subtract(input1, input2);

            // Assert
            Assert.AreEqual(5, result);
        }
    }
}
