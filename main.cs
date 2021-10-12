using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    
    int[] Celsius = new int[7];
    int[] Farenheit = new int[7];
    int sum = 0;
    int average = 0;

    for (int i = 0; i < 7; i++)
    {
      Console.WriteLine("Enter temperature in celsius");
      Celsius[i] = Convert.ToInt32(Console.ReadLine());
      Farenheit[i] = (Celsius[i] * 9/5) + 32;
      sum = sum + Farenheit[i];
    }

    Array.Sort(Farenheit);
    Console.WriteLine("Temperature in Farenheit");
    
    foreach (int n in Farenheit)
    {
      Console.WriteLine(n);
    }

    average = sum / 7;
    Console.WriteLine("Average weekly tempurature is " + average + " degrees fahrenheit");
  }
}