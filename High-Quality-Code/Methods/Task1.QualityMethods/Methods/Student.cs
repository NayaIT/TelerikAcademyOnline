namespace Methods
{
    using System;

    /// <summary>
    /// Student class, containing all of the basic information such as names, birthdate and age
    /// </summary>
    public class Student
    {
        public Student(string firstName, string lastName, DateTime birthDate, string town, string comments = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.Comments = comments;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Town { get; set; }

        public string Comments { get; set; }

        /// <summary>
        /// The method compares two students by their age.
        /// </summary>
        public bool IsOlderThan(Student other)
        {
            return this.BirthDate < other.BirthDate;
        }
    }
}