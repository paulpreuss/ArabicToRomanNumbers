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
                int number = Int32.Parse(Console.ReadLine());
                Console.WriteLine(ArabicToRomanNumbersConverter.Convert(number));
            }
        }
    }
}
