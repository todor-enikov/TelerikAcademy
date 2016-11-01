// A company has name, address, phone number, fax number, web site and manager. 
// The manager has first name, last name, age and a phone number.
// Write a program that reads the information about a company and its manager and prints it back on the console.
using System;
class CompanyInformation
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAdress = Console.ReadLine();
        string companyPhoneNumber = Console.ReadLine();
        string companyFaxNumber = Console.ReadLine();
        if (companyFaxNumber == string.Empty)
        {
            companyFaxNumber = "(no fax)";
        }
        string companyWebSite = Console.ReadLine();
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        string age = Console.ReadLine();
        string managerPhoneNumber = Console.ReadLine();

        Console.WriteLine("{0}", companyName);
        Console.WriteLine("Address: {0}", companyAdress);
        Console.WriteLine("Tel. {0}", companyPhoneNumber);
        Console.WriteLine("Fax: {0}", companyFaxNumber);
        Console.WriteLine("Web site: {0}", companyWebSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", firstName, lastName, age, managerPhoneNumber);
    }
}

