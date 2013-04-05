using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzinator
    {
        public IEnumerable<string> Generate()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0) yield return "FizzBuzz";
                if (i % 3 == 0) yield return "Fizz";
                if (i % 5 == 0) yield return "Buzz";
                yield return i.ToString(CultureInfo.InvariantCulture);
            }
        }
    }
}

