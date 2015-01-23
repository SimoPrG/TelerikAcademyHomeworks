//Problem 2. Gravitation on the Moon

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;

class GravitOnTheMoon
{
    static void Main()
    {
        Console.Write("Please, enter your weight: ");
        float weight = float.Parse(Console.ReadLine());
        float moonWeight = weight * 0.17F;
        Console.WriteLine("Your weight on the Moon is: " + moonWeight);
    }
}