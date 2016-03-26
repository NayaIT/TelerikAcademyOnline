
namespace StudentClass
{
    using System;
    class TestStudent
    {
        static void Main(string[] args)
        {
            Student student = new Student("Jakub", "M", "Jakson", 10002922, "Telerik", "+359 885", "jakub.jakson@gmail.com");
            student.FillUniversityInfo(Student._University.SofiaUniversity, 4, Student._Faculty.Mathematics, Student._Speciality.IT);
            Console.WriteLine(student.GetHashCode());
            Student student2 = new Student("Mark", "S", "Morison", 10034222, "Telerik", "+359 883", "mark.morison@gmail.com");
            student2.FillUniversityInfo(Student._University.TechnicalUniversity, 4, Student._Faculty.Mathematics, Student._Speciality.IT);
            Console.WriteLine(student2.GetHashCode() + Environment.NewLine);

            Console.WriteLine(student);
            Console.WriteLine(student2);
            Console.WriteLine(student == student2);
            Console.WriteLine(student.Equals(student));
            Console.WriteLine(student.Equals(student2));
            Console.WriteLine(student != student2);
        }
    }
}