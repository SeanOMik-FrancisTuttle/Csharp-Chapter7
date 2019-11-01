using System;

using static System.Console;

namespace Multiplication {
    class Program {
        private static void DisplayMultiplicationTable(double num) {
            for (int i = 2; i <= 10; ++i) {
                Write("{0,3}x{1}={2}", i, num, num * i);
            }
        }

        static void Main(string[] args) {
            bool valid;
            double num;
            do {
                Write("Enter number to multiply: ");
                valid = double.TryParse(ReadLine(), out num);
            } while (!valid);

            DisplayMultiplicationTable(num);
        }
    }
}
