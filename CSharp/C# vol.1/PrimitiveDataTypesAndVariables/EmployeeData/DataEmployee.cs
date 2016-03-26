/*Problem 10. Employee Data

A marketing company wants to keep record of its employees. Each record would have the following characteristics:
First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
Use descriptive names. Print the data at the console.*/


using System;

class DataEmployee
{
    static void Main()
    {
        DateTime date = DateTime.Now;
        Console.WriteLine("Welcome to our Company account system on date {0} \n", date);
        
        Console.Write("Please enter your username and password:");
        string userName = Console.ReadLine();
       
        string firstName = "Natalie";
        string lastName = "Klein";
        string fullName = firstName + " " + lastName;
        int age = 34;

        long PersonalIdNumber = 8005095698;
        long UniqueEmployeeNumber = 27560009;

        Console.WriteLine("Employee name - {0} {1},\nUnique employee number: {2}.", firstName, lastName, UniqueEmployeeNumber);
        Console.WriteLine("The employee named {0} with Personal ID number {1} is {2} years old.", fullName, PersonalIdNumber, age);
    
    }
}

