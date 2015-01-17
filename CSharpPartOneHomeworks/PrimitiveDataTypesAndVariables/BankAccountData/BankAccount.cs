//Problem 11. Bank Account Data

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN,
//3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccount
{
    static void Main()
    {
        string fName = "Petko";
        string mName = "Ivanov";
        string lName = "Petrov";
        double balance = 1473.38;
        string bankName = "Beta Bank";
        string iban = "BG80 BNBG 9661 1020 3456 78";
        long creditCard1 = 4640123456789112;
        long creditCard2 = 3712345678950063;
        long creditCard3 = 4123123457891234;
        string fullName = fName +" " + mName +" "+ lName;
        Console.WriteLine("\t{0}", bankName);
        Console.WriteLine("\t*********\nWelcome, Mr. {0}", fullName);
        Console.WriteLine("Balance: {0} BGN \nIBAN: {1}", balance, iban);
        Console.WriteLine("VISA: {0} \nMaestro: {1} \nMaster Card: {2}", creditCard1, creditCard2, creditCard3);
        Console.WriteLine("\t\t\t{0}", DateTime.Now);
    }
}

