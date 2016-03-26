
namespace PersonClass
{
    using System;

    public class TestingPerson
    {
        public static void Main()
        {
            var person = new Person("Jakub Holecek", 12);

            Console.WriteLine(person);

            var otherPerson = new Person("Javiera Canales");

            Console.WriteLine(otherPerson);
        }
    }
}