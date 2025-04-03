using ClassExampleController;
using ClassExampleController.FileHandle;

namespace ClassExampleControllerTest
{
    /// <summary>
    /// Integration test for <see cref="DataAccessManager"/> and its relatives process.
    /// </summary>
    [TestClass]
    public class DataAccessManagerIntegrationTest
    {
        private readonly string FilePath = Path.Combine(Directory.GetCurrentDirectory(), "test.csv");

        /// <summary>
        /// Cleanups this instance.
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists(this.FilePath))
            {
                File.Delete(this.FilePath);
            }
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            if (File.Exists(this.FilePath))
            {
                File.Delete(this.FilePath);
            }
        }

        /// <summary>
        /// Should generate file and people.
        /// </summary>
        [TestMethod]
        public void ShouldGenerateFileAndPeople()
        {
            // Arrange
            var fileHandler = new FileHandler();
            var dataManagerAccess = new DataAccessManager(fileHandler);

            // Act
            var result = dataManagerAccess.GenerateFileAndPeople(10, this.FilePath);

            // Assert
            Assert.IsTrue(File.Exists(this.FilePath));
            var fileContent = File.ReadAllLines(this.FilePath);
            Assert.AreEqual(11, fileContent.Length);
            Assert.AreEqual(result[0].ToString().Replace("\n", string.Empty), fileContent[1]);
        }
    }
}
