using System;

namespace JobNimbusAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            MatchingBrackets mb = new MatchingBrackets();
            string input = "{}";
            Console.WriteLine("Input: " + input + " Result: " + mb.HasMatchingBrackets_Approach1(input));
            input = "}{";
            Console.WriteLine("Input: " + input + " Result: " + mb.HasMatchingBrackets_Approach1(input));
            input = "{{}";
            Console.WriteLine("Input: " + input + " Result: " + mb.HasMatchingBrackets_Approach1(input));
            input = "";
            Console.WriteLine("Input: " + input + " Result: " + mb.HasMatchingBrackets_Approach1(input));
            input = "{{{{}}}}{}{}{{}}";
            Console.WriteLine("Input: " + input + " Result: " + mb.HasMatchingBrackets_Approach1(input));
            input = "{{{{}}}}{}{}{{}";
            Console.WriteLine("Input: " + input + " Result: " + mb.HasMatchingBrackets_Approach1(input));
            input = "}}}}{{{{";
            Console.WriteLine("Input: " + input + " Result: " + mb.HasMatchingBrackets_Approach1(input));

            SumOfMultiples sm = new SumOfMultiples();
            Console.WriteLine($"Sum of Multiples of 3 or 5 below 10: {sm.SumofMultiples(10)}");
            Console.WriteLine($"Sum of Multiples of 3 or 5 below 1000: {sm.SumofMultiples(1000)}");
        }
    }
}
