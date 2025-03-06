using ClassExampleModel.Abstractions;
using System;

namespace ClassExampleModel
{
    /// <summary>
    /// Model representation for a student.
    /// </summary>
    /// <seealso cref="ClassExampleModel.Abstractions.Person" />
    public class Student : Person
    {
        /// <summary>
        /// Gets or sets the student identifier.
        /// </summary>
        /// <value>
        /// The student identifier.
        /// </value>
        public int StudentId { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        public Student()
        {
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"{this.Name},{this.LastName},{this.Age},{this.StudentId}\n";
        }
    }
}
