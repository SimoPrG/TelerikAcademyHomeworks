//Problem 10. Employee Data

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:

//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
//Use descriptive names. Print the data at the console.

using System;

class EmplData
{
    static void Main()
    {
        string fName = "Petko";
        string lName = "Petrov";
        byte age = 25;
        char gender = 'm';
        ulong idNum = 8906134312;
        int employeeNum = 27567348;
        Console.WriteLine("First name: {0} \nLast name: {1}", fName, lName);
        Console.WriteLine("Age: {0} \nGender: {1}", age, gender);
        Console.WriteLine("Personal ID number: {0} \nEmployee number: {1}", idNum, employeeNum);

    }
}
