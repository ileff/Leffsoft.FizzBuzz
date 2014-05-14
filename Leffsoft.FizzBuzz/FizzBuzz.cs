using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leffsoft.FizzBuzz
{
    public class FizzBuzz
    {
        public static String Value(int number)
        {
            String value = "";

            if (number % 3 == 0) value = "Fizz";
            if (number % 5 == 0) value = value + "Buzz";
            if (value.Length == 0) value = number.ToString();

            return value;
        }
    }
}
