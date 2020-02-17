using System;

namespace FizzBuzz_
{
    class Program
    {
        static void Main(string[] args)
        {
            // for (int i = 1; i <= 100; i++) {

            //     if (i % 3 == 0 && i % 5 == 0) {

            //         Console.WriteLine("FizzBuzz");

            //     } else if (i % 3 == 0) {

            //         Console.WriteLine("Fizz");

            //     } else if (i % 5 == 0) {

            //         Console.WriteLine("Buzz");

            //     } else {

            //         Console.WriteLine(i);
            //     }
            // }

            bool isFizzOrBuzz = false;
            string fizzBuzzMessage = "";

            for (int i = 1; i <= 100; i++) {
                isFizzOrBuzz = false;
                fizzBuzzMessage = "";

                if (i % 3 == 0) {
                    fizzBuzzMessage += "Fizz";
                    // Console.Write("Fizz");
                    isFizzOrBuzz = true;
                }
                if (i % 5 == 0) {
                    fizzBuzzMessage += "Buzz";
                    // Console.Write("Buzz");
                    isFizzOrBuzz = true;
                }

                Console.Write(isFizzOrBuzz ? fizzBuzzMessage : i.ToString());

                Console.WriteLine("");
                //15
                //FizzBuzz
            }
        }
    }
}
