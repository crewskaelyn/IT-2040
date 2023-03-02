using System;

namespace FuelGauge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your fuel level in fraction form. Type \"end\" to quit.\n");
            
            while (true)
            {
                try {
                    Console.WriteLine("Fraction:");
                    string input = Console.ReadLine().ToLower();

                    if (input == "end") {
                        break;
                    }

                    string[] numbers = input.Split('/');
                    int x, y;
                    if (numbers.Length != 2 || !int.TryParse(numbers[0], out x) || !int.TryParse(numbers[1], out y) || y == 0 || x > y) {
                        continue;
                    }

                    double percentage = (double)x / y * 100;
                    if (percentage <= 1) {
                        Console.WriteLine("E\n");
                    } else if (percentage >= 99) {
                        Console.WriteLine("F\n");
                    } else {
                        Console.WriteLine(Math.Round(percentage) + "%\n");
                    }

                } catch (Exception err) {
                    Console.WriteLine("Error: " + err);
                }
            }
        }
    }
}

//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number
//https://learn.microsoft.com/en-us/dotnet/api/system.math.round?view=net-7.0#Round2_Example