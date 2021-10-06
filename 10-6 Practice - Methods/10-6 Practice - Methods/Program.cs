using System;

namespace _10_6_Practice___Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Best Practices for methods
            //- Methods should be reusable!
            //- Methods should generally (outside of main method or a "runner" or manager method) should have ONE job!
            //- Methods should account for the most likely inputs (aka parameters) - 1+1 or 1million + 1million should both work in a method that adds two numbers
            //- Make sure to review the syntax for a method, and get in the habit of moving per each part of the method signature!

            bool goOn = true;
            while (goOn == true)

            {

                //1. Getting user input
                //Prompt the user 
                //Read in their input
                string result = GetInput("Please input your age");
                Console.WriteLine(result);
                // You then can make multiple instances of this, to pass in whatever string you want it to
                string result2 = GetInput("What is your name?");
                Console.WriteLine(result2);


                //2. Continue loop via a method
                //Ask user "Would you like to continue?  Y/N"
                //*placed at the bottom of the main method, to make sure the rest of main executes.  

                //3 Cases to care about: 
                //user says Y, and we continue
                //user says N, and we stop the main loop
                //user inputs anything else, and we try getting valid input again
                //3. Representing Math formulas (area, perimeter, etc.) - it needs to be correct once, then we just call the method

                //we will also write area, perimeter, calc paint cans, and range checking within this practice code.
                int x = 7;
                float f = 1.5f;  //first time using a FLOAT - these values MUST end with a lowercase f in order to actually format.  Just use decimals or doubles.
                //this is just showing that similar data types (decimals, floats, ints, etc.) can be implicitly converted by C#
                double area = GetArea(f,5);
                Console.WriteLine($"Area: {area}");

                //range checking validation of the inputs, making sure they are within the right range and format:
                bool inRange = RangeCheck(10, 80, 30);
                Console.WriteLine(inRange);
                //it works when we pass in literal integers, but we can also use the parameter section above to pass in variables as well
                //Now we are going to try and break it.  Holding your mouse over the method will show what each parameter is doing
                //you can break this method if you don't follow the convention that is has (like if we set the max to 1 and the min to 10) - it'll always return 'false'
                //we can add in (within the method) to put rules on these parameters.

                goOn = ContinueLoop();  //this means the method can control whether or not we go through the while loop for the whole main method
            }

        }
        public static string GetInput(string prompt) //we want a public (static) string-returning method called GetInput, that uses the string "prompt" variable

            //Reusable!!!  You can pass in any string in this case for whatever question you have to the user.
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();

            return output;
        }
        public static bool ContinueLoop()
        {
            string answer = GetInput("Would you like to continue?  y/n"); //calling the existing method above in another method!
            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine("Goodbye!");
                return false;
                //If we put another cw("See ya!") here/below the 'return', it wouldnt execute - return statement above kicks us out of the above method
            }
            else 
            {
                Console.WriteLine("I'm sorry, I didn't understand that.");
                Console.WriteLine("Let's try again.");
                return ContinueLoop();  //This will re-run the method so we don't "break out" of the method until a valid answer is given (called "recursion")
            }
        }
        public static double GetArea(double width, double length) 
        { 
            double area = length * width;
            return area;
        }
        public static bool RangeCheck(int min, int max, int num) //using each parameter to build the guardrails, then check our num value
        {
            //this is where we are adding the rules for the min/max with wrapping the if statement in ANOTHER if statement.  The min < max 'if' is validation.

            if (min < max)
            {

                if (num > min && num < max)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Console.WriteLine($"Min {min} is greater than Max {max} and therefore the range cannot be checked.");
                return false;
            }
        }
    
    }


}
