using ClassExampleController;
using ClassExampleController.Interfaces;
using ClassExampleModel;
using ClassExampleModel.Abstractions;
using Moq;

namespace ClassExampleControllerTest
{
    /// <summary>
    /// Test for <see cref="DataAccessManager"/>.
    /// </summary>
    [TestClass]
    public class DataAccessManagerTest
    {
        /// <summary>
        /// Should add the element.
        /// </summary>
        [TestMethod]
        public void ShouldAddElement()
        {
            // Arrange
            var fileHandler = new Mock<IFileHandle>();
            fileHandler.Setup(x => x.Add(It.IsAny<Student>(), It.IsAny<string>()))
                .Returns(true);

            var dataManagerAccess = new DataAccessManager(fileHandler.Object);

            // Act
            var result = dataManagerAccess.Add(new Student(), "test.csv");

            // Assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Should not add a professor.
        /// </summary>
        [TestMethod]
        public void ShouldNotAddProfessor()
        {
            // Arrange
            var fileHandler = new Mock<IFileHandle>();
            fileHandler.Setup(x => x.Add(It.IsAny<Professor>(), It.IsAny<string>()))
                .Returns(false);

            var dataManagerAccess = new DataAccessManager(fileHandler.Object);

            // Act
            var result = dataManagerAccess.Add(new Student(), "test.csv");

            // Assert
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Should generate people.
        /// </summary>
        [TestMethod]
        public void ShouldGeneratePeople()
        {
            // Arrange
            var fileHandler = new Mock<IFileHandle>();
            var dataManagerAccess = new DataAccessManager(fileHandler.Object);
            var peopleRequired = 10;

            // Act
            var result = dataManagerAccess.GeneratePeople(peopleRequired);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(peopleRequired, result.Count);
        }

        /// <summary>
        /// Should generate file and people.
        /// </summary>
        [TestMethod]
        public void ShouldGenerateFileAndPeople()
        {
            // Arrange
            var fileHandler = new Mock<IFileHandle>();
            fileHandler.Setup(x => x.WritePeople(It.IsAny<List<Person>>(), It.IsAny<string>()))
                .Returns(true);
            var dataManagerAccess = new DataAccessManager(fileHandler.Object);

            // Act
            var result = dataManagerAccess.GenerateFileAndPeople(10, "test.csv");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(10, result.Count);
        }

        /// <summary>
        /// Should not generate file and people.
        /// </summary>
        [TestMethod]
        public void ShouldNotGenerateFileAndPeople()
        {
            // Arrange
            var fileHandler = new Mock<IFileHandle>();
            fileHandler.Setup(x => x.WritePeople(It.IsAny<List<Person>>(), It.IsAny<string>()))
                .Returns(false);
            var dataManagerAccess = new DataAccessManager(fileHandler.Object);

            // Act
            var result = dataManagerAccess.GenerateFileAndPeople(10, "test.csv");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }
    }
}
