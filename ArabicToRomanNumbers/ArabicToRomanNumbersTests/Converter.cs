using System;
using System.Collections.Generic;

namespace ArabicToRomanNumbersTests
{
    internal class Converter
    {
        public static string Convert(int arabicNumber)
        {
            if (arabicNumber <= 0 || arabicNumber >= 4000)
                throw new ArgumentOutOfRangeException();

            Dictionary<int, string> values = new Dictionary<int, string>()
            {
                { 1000, "M" }, { 900, "CM" }, { 500, "D" }, { 400, "CD" },
                { 100, "C" }, { 90, "XC" }, { 50, "L" }, { 40, "XL" },
                { 10, "X" }, { 9, "IX" }, { 5, "V"}, { 4, "IV" }, { 1, "I" }
            };

            string romanNumber = string.Empty;

            foreach (var arabicToRoman in values)
            {
                while (arabicNumber >= arabicToRoman.Key)
                {
                    romanNumber += arabicToRoman.Value;
                    arabicNumber -= arabicToRoman.Key;
                }
            }

            return romanNumber;
        }
    }
}