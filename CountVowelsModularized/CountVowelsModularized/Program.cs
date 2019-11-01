using System;
using System.Text.RegularExpressions;

using static System.Console;

namespace CountVowelsModularized {
    class Program {
        private static int vowelAmount(string str) {
            string before = str;
            str = Regex.Replace(str, "(?<!^)([aouie]|y(?![aouie]))(?!$)", "");
            return before.Length - str.Length;
        }

        static void Main(string[] args) {
            WriteLine("Count vowel amount for what word? ");
            WriteLine("That word has {0} vowel(s)!", vowelAmount(ReadLine()));
        }
    }
}
