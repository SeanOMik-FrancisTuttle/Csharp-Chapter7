using System;

using static System.Console;

namespace AdmissionModularized {
    class Program {
        private static void DisplayAccepted(double gpa, double testScore) {
            if ((gpa >= 3 && testScore >= 60) || (gpa <= 3 && testScore >= 80)) {
                WriteLine("Accept");
            }
            else {
                WriteLine("Reject");
            }
        }
        static void Main(string[] args) {
            bool valid1;
            double gpa;
            do {
                Write("Enter Highschool Grade Point Average (GPA): ");
                valid1 = double.TryParse(ReadLine(), out gpa);
            } while (!valid1);

            bool valid2;
            double testScore;
            do {
                Write("Enter Admission Test Score: ");
                valid2 = double.TryParse(ReadLine(), out testScore);
            } while (!valid2);

            DisplayAccepted(gpa, testScore);
        }
    }
}
