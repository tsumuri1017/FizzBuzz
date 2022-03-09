using System;

namespace FizzBuzzApp {
    class Program {
        static void Main(string[] args) {
            for (int i = 1; i <= 100; i++) {
                Console.WriteLine(FizzBuzz(i));
            }
        }

        static string FizzBuzz(int n) {
            if (n % 3 == 0 && n % 5 == 0)
                return "FizzBuzz";
            if (n % 3 == 0)
                return "Fizz";
            if (n % 5 == 0)
                return "Buzz";
            return n.ToString();
        }
    }
}
