//Problem 2. Print Company Information
//
//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class CompanyInfo
{
    static void Main()
    {
        Console.WriteLine("please enter the following details: \n ");
        
        Console.Write("Enter the Company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Enter the Company address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Enter the phone number: ");
        string phoneNumber = Console.ReadLine();

        Console.Write("Enter the fax number: "); //If there is no fax nhumber you can write "no fax"
        string faxNumber = Console.ReadLine();

        Console.Write("Enter the web site: ");
        string webSite = Console.ReadLine();

        Console.Write("Enter the Manager first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter the Manager last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter the Manager age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter the Manager phone: ");
        string managerPhone = Console.ReadLine();



        Console.WriteLine("\nCompany name: " + companyName + "\nCompany address: " + companyAddress + "\nPhone number: " + phoneNumber +
            "\nFax number: " + faxNumber + "\nWeb site: " + webSite + "\nManager first name: " + firstName + "\nManager last name: " + lastName +
            "\nManager age: " + age + "\nManager phone: " + managerPhone);
    }
}

