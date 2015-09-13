using System;
using System.Collections;
using System.Linq;

public class Statistics
{
    private double[] numbers;

    public Statistics (double[] numbers)
	{
        this.numbers = numbers;
	}

    public double[] Numbers { get; set; }

    public void Print()
    {
        Console.WriteLine(string.Join(",", this.numbers));
    }

    public void PrintMax()
    {
        Console.WriteLine("Max number is: {0}", this.numbers.Max());
    }
        
    public void PrintMin()
    {
        Console.WriteLine("Min number is: {0}", this.numbers.Min());
    }

    public void PrintAvg()
    {
        Console.WriteLine("Avarage number is: {0}", this.numbers.Average());
    }
}
