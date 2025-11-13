using System;

namespace ConsoleApp
{
    // This is the 'MathOperations' class, where we'll define our method
    class MathOperations
    {
        // Method 'PerformOperation' takes two integer parameters.
        // We perform a math operation on the first parameter (num1),
        // and print the second parameter (num2) to the console.
        public void PerformOperation(int num1, int num2)
        {
            // Here we perform an example math operation: adding 10 to num1
            int result = num1 + 10; // Adds 10 to num1

            // Print the result of the math operation and display num2.
            // This is our way of showing that the first parameter has been manipulated.
            Console.WriteLine($"Result of adding 10 to {num1}: {result}"); // Outputs the math result
            Console.WriteLine($"The second number (num2) is: {num2}"); // Displays num2 (unchanged)
        }
    }

    class Program
    {
        // Main method: the entry point of our application
        static void Main(string[] args)
        {
            // Instantiating an object of the 'MathOperations' class
            MathOperations mathOps = new MathOperations();

            // First call to 'PerformOperation' using positional arguments
            // We pass 7 for num1 and 25 for num2
            mathOps.PerformOperation(7, 25);  // Here, 7 is the first parameter, 25 is the second

            // Second call to 'PerformOperation' but this time using named arguments
            // This makes it more explicit what each argument represents
            mathOps.PerformOperation(num1: 12, num2: 35);  // Clearly specifying which is which using names
        }
    }
}
