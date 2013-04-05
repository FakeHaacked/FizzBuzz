using System;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        const int columnCount = 5;
        const int totalCount = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to get your FizzBuzz on!");
            Console.ReadKey();

            var fizzBuzzinator = new FizzBuzzinator();
            fizzBuzzinator.Generate()
                          .Take(totalCount)
                          .Select((entry, index) => new {entry, number = index + 1})
                          .GroupBy(x => x.number % (totalCount/columnCount))
                          .Select(x => String.Join("  ", x.Select(y => Pad(y.entry)).ToArray()))
                          .ToList()
                          .ForEach(Console.WriteLine);

            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
            Console.WriteLine("QUITTER!");
        }

        private static string Pad(string value)
        {
            return value.PadLeft("FizzBuzz".Length, ' ');
        }
    }
}
