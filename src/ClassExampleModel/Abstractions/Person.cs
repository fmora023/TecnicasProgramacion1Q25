using System;

namespace ClassExampleModel.Abstractions
{
    /// <summary>
    /// Abstract class for person.
    /// </summary>
    public abstract class Person
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string? LastName { get; set; }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        public int? Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name},{this.LastName},{this.Age}\n";
        }
    }
}
