//Problem 4. Person class

//Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. 
//Override ToString() to display the information of a person and if age is not specified – to say so.
//Write a program to test this functionality.

namespace PersonClass
{
    using System;

    public class TestPerson
    {
        public static void Main()
        {
            var person = new Person("Ivan", null);

            var otherPerson = new Person("Pencho", 22);

            var anotherPerson = new Person("Gosho");

            Console.WriteLine(person);
            Console.WriteLine(otherPerson);
            Console.WriteLine(anotherPerson);
        }
    }
}
