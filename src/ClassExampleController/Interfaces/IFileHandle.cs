using ClassExampleModel.Abstractions;

namespace ClassExampleController.Interfaces
{
    /// <summary>
    /// Interface for handle file operations.
    /// </summary>
    public interface IFileHandle
    {
        /// <summary>
        /// Reads the people.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>
        /// the list of people in the file provided.
        /// </returns>
        public List<Person> ReadPeople(string fileName);

        /// <summary>
        /// Writes the people.
        /// </summary>
        /// <param name="people">The people.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>
        /// true if success.
        /// false if fail.
        /// </returns>
        public bool WritePeople(List<Person> people, string fileName);
    }
}
