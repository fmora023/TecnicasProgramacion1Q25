using ClassExampleController.Interfaces;
using ClassExampleModel;
using ClassExampleModel.Abstractions;

namespace ClassExampleController.FileHandle
{
    /// <summary>
    /// Implementacion for <see cref="IFileHandle"/> to read csv files.
    /// </summary>
    public class FileHandler : IFileHandle
    {
        /// <summary>
        /// Adds the specified person.
        /// </summary>
        /// <param name="person">The person.</param>
        /// <param name="path">The path.</param>
        public bool Add(Student person, string path)
        {
            var contentCounter = File.ReadAllLines(path).Length;
            File.AppendAllText(path, person.ToString());

            if (contentCounter == File.ReadAllLines(path).Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Reads the people.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>
        /// the list of people in the file provided.
        /// </returns>
        public List<Person> ReadPeople(string fileName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Writes the people.
        /// </summary>
        /// <param name="people">The people.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>
        /// true if success.
        /// false if fail.
        /// </returns>
        public bool WritePeople(List<Person> people, string fileName)
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                File.AppendAllLines(fileName, new List<string> { "Name,LastName,Age" });

                foreach (var person in people)
                {
                    File.AppendAllText(fileName, person.ToString());
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
