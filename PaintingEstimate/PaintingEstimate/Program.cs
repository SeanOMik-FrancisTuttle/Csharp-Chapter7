using System;

using static System.Console;

namespace PaintingEstimate {
    class Program {
        static double CalculateCost(double width, double length) => width* length * 6;

        static void Main(string[] args) {

            bool valid1;
            double width;
            do {
                Write("Enter room width: ");
                valid1 = double.TryParse(ReadLine(), out width);
            } while (!valid1);

            bool valid2;
            double length;
            do {
                Write("Enter room length: ");
                valid2 = double.TryParse(ReadLine(), out length);
            } while (!valid2);

            WriteLine("Cost: {0}", CalculateCost(width, length).ToString("C"));
        }
    }
}
