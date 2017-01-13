using System;
using System.Collections.Generic;

namespace DailyChallenge228
{
    class Program
    {
        static void Main()
        {
            var inputList = new List<string>{ "billowy", "biopsy", "chinos", "defaced", "chintz", "sponged",
                                              "bijoux", "abhors", "fiddle", "begins", "chimps", "wronged" };

            foreach (var item in inputList) {
                Console.WriteLine(IsOrdered(item));
            }            

            Console.ReadKey();            
        }

        static string IsOrdered(string input)
        {
            bool notOrdered = false;

            // check if not ordered
            for (int i = 0; i < input.Length - 1; i++) {
                if (input[i] > input[i + 1]) {
                    notOrdered = true;
                    break;
                }
            }            

            // since not ordered, check if in reverse order
            if (notOrdered == true) {
                for (int i = input.Length - 1; i > 0; i--) {    // iterate backwards from end of word
                    if (input[i] > input[i - 1]) {     // if any char is higher than the one before it, string is not in order or reverse order
                        return $"{input} NOT IN ORDER"; 
                    }
                }

                // if code gets through the for loop, it's in reverse order
                return $"{input} IN REVERSE ORDER";
            }

            return $"{input} IN ORDER";
        }
    }
}
