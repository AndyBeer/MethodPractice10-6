using System;

namespace DevBuildLab2NumberAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            //0.0 get user's name, to refer to them throughout the code
            //1.0 get integer input between 1 and 100
            //1.1 add validation to guarantee a user enters a valid input
            //2.0 take integer that user submitted and:
            //2.1 if odd, printe the number and display "Odd."
            //2.2 if even and between 2-25 incl, print "even and less than 25."
            //2.3 if even and between 26 - 60 incl, print "Even."
            //2.4 if even and > 60 excl, print the number and "Even."
            //2.5 if odd and > 60 excl, print the number and "Odd."

            //0.0
            Console.WriteLine("Hello!  Welcome to Number Analyzer.  Please enter your name");
            string userName = Console.ReadLine();

            Console.WriteLine($"Welcome {userName}!  Let's get started.");
            Console.WriteLine();
            Console.WriteLine("Please enter an integer from 1 to 100 (inclusive).");
            
            int userInput = int.Parse(Console.ReadLine());



        }
    }
}
