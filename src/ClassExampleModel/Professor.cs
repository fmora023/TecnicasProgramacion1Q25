using ClassExampleModel.Abstractions;

namespace ClassExampleModel
{
    /// <summary>
    /// Model representation for a professor.
    /// </summary>
    /// <seealso cref="ClassExampleModel.Abstractions.Person" />
    public class Professor : Person
    {
        /// <summary>
        /// Gets or sets the courses.
        /// </summary>
        /// <value>
        /// The courses.
        /// </value>
        public List<string> Courses { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Professor"/> class.
        /// </summary>
        public Professor()
        {
            Courses = new List<string>();
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"{{person.Name}},{{person.LastName}},{{person.Age}},{string.Join(",", this.Courses)}\n";
        }
    }
}
