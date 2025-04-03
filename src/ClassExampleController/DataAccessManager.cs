using ClassExampleController.Interfaces;
using ClassExampleModel;
using ClassExampleModel.Abstractions;

namespace ClassExampleController
{
    /// <summary>
    /// Class in charge of managing the data access.
    /// </summary>
    public class DataAccessManager
    {
        private readonly IFileHandle fileHandler;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataAccessManager"/> class.
        /// </summary>
        /// <param name="fileHandler">The file handler.</param>
        public DataAccessManager(IFileHandle fileHandler)
        {
            this.fileHandler = fileHandler;
        }

        /// <summary>
        /// Adds the specified person.
        /// </summary>
        /// <param name="person">The person.</param>
        /// <param name="path">The path.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool Add(Student person, string path)
        {
            return this.fileHandler.Add(person, path);
        }

        /// <summary>
        /// Generates the file and people.
        /// </summary>
        /// <param name="peopleRequired">The people required.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <returns></returns>
        public List<Person> GenerateFileAndPeople(int peopleRequired, string fileName)
        {
            var people = this.GeneratePeople(peopleRequired);

            var result = this.fileHandler.WritePeople(people, fileName);
            if (!result)
            {
                return new List<Person>();
            }

            return people;
        }

        /// <summary>
        /// Generates the people.
        /// </summary>
        /// <param name="peopleRequired">The people required.</param>
        /// <returns></returns>
        public List<Person> GeneratePeople(int peopleRequired)
        {
            var result = new List<Person>();
            var names = new List<string> { "John", "Jane", "Alice", "Bob", "Charlie", "Ivania", "Oscar",
                "Juan", "Kevin", "Jose", "Limberth", "Ashly", 
                "Roberto", "Christopher", "Jonathan", "Sharon" };

            var lastNames = new List<string> { "Doe", "Smith", "Johnson", "Brown", "Garcia", "Martinez",
                "Rodriguez", "Miranda", "Arce", "Lopez", "Perez", "Gonzalez", "Ramirez", "Flores", "Torres", "Sanchez" };

            var random = new Random();

            for (int i = 0; i < peopleRequired; i++)
            {
                var role = random.Next(0, 100);
                if (role % 5 != 0)
                {
                    var student = new Student();
                    student.Name = names[random.Next(0, names.Count - 1)];
                    student.LastName = lastNames[random.Next(0, lastNames.Count - 1)];
                    student.Age = random.Next(18, 25);
                    result.Add(student);
                }
                else
                {
                    var professor = new Professor();
                    professor.Name = names[random.Next(0, names.Count - 1)];
                    professor.LastName = lastNames[random.Next(0, lastNames.Count - 1)];
                    professor.Age = random.Next(25, 30);
                    result.Add(professor);
                }
            }

            return result;
        }
    }
}
