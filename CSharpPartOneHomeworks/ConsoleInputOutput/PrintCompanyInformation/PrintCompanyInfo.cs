//Problem 2. Print Company Information

//A company has name, address, phone number, fax number, web site and manager. The manager has first name,
//last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class PrintCompanyInfo
{
    static void Main()
    {
        Console.WriteLine("Please enter company information...");

        Console.Write("Name: ");
        string companyName = Console.ReadLine();

        Console.Write("Address: ");
        string address = Console.ReadLine();

        Console.Write("Phone number: ");
        string phoneCompany = Console.ReadLine();

        Console.Write("Fax number: ");
        string faxCompany = Console.ReadLine();

        Console.Write("Web site: ");
        string webSite = Console.ReadLine();

        Console.WriteLine("Please enter manager information.");
        Console.Write("First name: ");
        string managerFName = Console.ReadLine();

        Console.Write("Last name: ");
        string managerLName = Console.ReadLine();

        Console.Write("Age: ");
        string managerAge = Console.ReadLine();

        Console.Write("Phone number: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine(companyName + "\nAddress: " + address);
        Console.WriteLine("Tel: " + managerPhone);
        if (faxCompany.Length < 8)
        {
            Console.WriteLine("Fax: (no fax)");
        }
        else
        {
            Console.WriteLine("Fax: " + faxCompany);
        }
        Console.WriteLine("Web site: " + webSite);
        Console.WriteLine();
        Console.WriteLine("Manager: " + managerFName + " " + managerLName);
        Console.WriteLine("(age: {0}, tel. {1} )", managerAge, managerPhone);
    }
}
