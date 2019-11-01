using System;

using static System.Console;

namespace ConvertQuartsToLiters {
    class Program {
        private static double ToLiter(double quart) => quart * 0.94635295;

        static void Main(string[] args) {
            bool valid1;
            double quart;
            do {
                Write("Enter quarts: ");
                valid1 = double.TryParse(ReadLine(), out quart);
            } while (!valid1);

            WriteLine("{0} quart(s), is equal to {1} liter(s).", quart, ToLiter(quart));
        }
    }
}
