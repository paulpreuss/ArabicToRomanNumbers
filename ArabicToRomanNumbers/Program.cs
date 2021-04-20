using System;

namespace ArabicToRomanNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Which number do you want to convert?");
                try
                {
                    int number = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(ArabicToRomanNumbersConverter.Convert(number));
                }
                catch (Exception ex)
                {
                    if (ex is ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Please enter a number between 1 and 3999.");
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number.");
                    }
                }   
            }
        }
    }
}
