//Problem 11. Bank Account Data
//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, 
//IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive
//names.


using System;

class AccountData
{
    static void Main()
    {
        DateTime date = DateTime.Now;
        Console.WriteLine("Welcome to our Bank account system on date {0} \n", date);

        Console.Write("Please enter your username and PIN code:");
        string userName = Console.ReadLine();
        Console.WriteLine("Hello, {0} ! \n", userName);

        string firstName = "Natalie";
        string middleName = "Jonson";
        string lastName = "Klein";
        string holderName = firstName + " " + middleName + " " + lastName;
        decimal amoutOfMoney = 503000.65m;
        object bankName = "Societe Generale";
        string iBan = "BG 18 BEUR XXXX XXXX XXXX XX";
        long creditCardOne = 6598213659878965;
        long creditCardTwo = 6528965421032658;
        long creditCardThree = 5629875632985456;
        
        Console.WriteLine("Holder name - {0}, available amount: {1} EUR at \"{2}\" BANK", holderName, amoutOfMoney, bankName);
        Console.WriteLine("IBAN: {0} \nHolder credit card numbers: \nVisa - {1} \nMaestro - {2} \nMaster card - {3}", iBan, creditCardOne, creditCardTwo, creditCardThree);

    }
}

