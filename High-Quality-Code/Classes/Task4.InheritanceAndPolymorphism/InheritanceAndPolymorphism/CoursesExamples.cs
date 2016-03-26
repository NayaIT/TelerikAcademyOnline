/*Task 4. Inheritance and Polymorphism
Redesign the classes and refactor the code from the solution Inheritance-and-Polymorphism to follow the best practices in high-quality classes.
Extract abstract base class and move all common properties in it.
Encapsulate the fields and make sure required fields are not left without a value.
Reuse the repeating code though base methods.*/

namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;

    class CoursesExamples
    {
        static void Main()
        {
            LocalCourse localCourse = new LocalCourse("Transporter", "Jason Statham", new List<string>() { "Tom", "Jane" }, "Enterprise");
            Console.WriteLine(localCourse);
            localCourse.Students.Add("Kary");
            localCourse.Students.Add("Ted");
            Console.WriteLine(localCourse);

            OffsiteCourse offsiteCourse = new OffsiteCourse("Transporter", "Jason Statham", new List<string>() { "Jhon", "Jery", "Steve" }, "New York");
            Console.WriteLine(offsiteCourse);
        }
    }
}