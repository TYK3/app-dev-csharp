// conditional Statements: if, else if, else
// Use: Execute different blocks of code based on conditions.
// if (condition)
// {
//     // Code to execute if condition is true
// }
// else if (anotherCondition)
// {
//     // Code to execute if anotherCondition is true
// }
// else
// {
//     // Code to execute if none of the above conditions are true
// }

// Example: Check if a person is eligible to vote.
// using System;

// namespace ConditionalStatements
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int age = 18;

//             if (age >= 18)
//             {
//                 Console.WriteLine("You are eligible to vote.");
//             }
//             else
//             {
//                 Console.WriteLine("You are not eligible to vote.");
//             }
//         }
//     }
// }

// Switch Statements
// Use: Simplifies complex conditional logic by testing a variable against multiple values.

// switch (variable)
// {
//     case value1:
//         // Code to execute if variable equals value1
//         break;
//     case value2:
//         // Code to execute if variable equals value2
//         break;
//     default:
//         // Code to execute if variable doesn't match any case
//         break;
// }

// Example: Simple grading system using switch
// using System;

// namespace SwitchStatement
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             char grade = 'B';

//             switch (grade)
//             {
//                 case 'A':
//                     Console.WriteLine("Excellent!");
//                     break;
//                 case 'B':
//                     Console.WriteLine("Well done!");
//                     break;
//                 case 'C':
//                     Console.WriteLine("Good!");
//                     break;
//                 case 'D':
//                     Console.WriteLine("Needs improvement.");
//                     break;
//                 case 'F':
//                     Console.WriteLine("Fail.");
//                     break;
//                 default:
//                     Console.WriteLine("Invalid grade.");
//                     break;
//             }
//         }
//     }
// }

// Loops: for, foreach, while, do-while
// Purpose: Repeat code blocks multiple times.

// for: Known number of iterations.
// Use: Repeats code a specific number of times.

// for (initialization; condition; increment)
// {
//     // Code to execute repeatedly
// }

// Example: Print numbers 1 to 10.

// using System;

// namespace ForLoop
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             for (int i = 1; i <= 10; i++)
//             {
//                 Console.WriteLine("Number: " + i);
//             }
//         }
//     }
// }

// foreach: Iterates over elements in a collection.
// Use: Iterates over elements in a collection (e.g., array, list).
// foreach (type variable in collection)
// {
//     // Code to execute for each element
// }

// Example: Print each name in an array.

// using System;

// namespace ForEachLoop
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string[] names = { "Alice", "Bob", "Charlie" };

//             foreach (string name in names)
//             {
//                 Console.WriteLine("Hello, " + name + "!");
//             }
//         }
//     }
// }

// while: Iterates while condition is true.
// Use: Repeats code as long as a condition is true.
// while (condition)
// {
//     // Code to execute repeatedly
// }

// Example: Print numbers 1 to 10.

// using System;

// namespace WhileLoop
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int i = 1;

//             while (i <= 10)
//             {
//                 Console.WriteLine("Number: " + i);
//                 i++;
//             }
//         }
//     }
// }

// do-while: Executes at least once, then checks condition.
// Use: Ensures the code block runs at least once.
// do
// {
//     // Code to execute repeatedly
// } while (condition);

// Example: Print numbers 1 to 10

// using System;

// namespace DoWhileLoop
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int i = 1;

//             do
//             {
//                 Console.WriteLine("Number: " + i);
//                 i++;
//             } while (i <= 10);
//         }
//     }
// }

// Break: Exits the loop immediately.
// Example: Stop the loop when a condition is met.
// for (int i = 0; i < 10; i++)
// {
//     if (i == 5)
//     {
//         break; // Exit the loop when i equals 5
//     }
//     Console.WriteLine(i);
// }

// Continue: Skips the current iteration, moves to the next one.
// Example: Skip even numbers in a loop
// for (int i = 0; i < 10; i++)
// {
//     if (i % 2 == 0)
//     {
//         continue; // Skip the rest of the loop for even numbers
//     }
//     Console.WriteLine(i);
// }

// Defining and Calling Methods
// Purpose: Organize and reuse code.
// returnType MethodName(parameters)
// {
//     // Code to execute
//     return value;
// }

// Example: Method to add two numbers
// using System;

// namespace Methods
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int result = Add(10, 20);
//             Console.WriteLine("Sum: " + result);
//         }

//         static int Add(int a, int b)
//         {
//             return a + b;
//         }
//     }
// }

// Example: Multiply two numbers
// using System;

// namespace MethodParameters
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             double product = Multiply(5.5, 4.2);
//             Console.WriteLine("Product: " + product);
//         }

//         static double Multiply(double a, double b)
//         {
//             return a * b;
//         }
//     }
// }

// Example: Add integers and doubles using overloaded methods.
// using System;

// namespace MethodOverloading
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int sumInt = Add(10, 20);
//             double sumDouble = Add(5.5, 4.5);

//             Console.WriteLine("Sum of Integers: " + sumInt);
//             Console.WriteLine("Sum of Doubles: " + sumDouble);
//         }

//         static int Add(int a, int b)
//         {
//             return a + b;
//         }

//         static double Add(double a, double b)
//         {
//             return a + b;
//         }
//     }
// }

// Recursion
// Purpose: A method calls itself to solve a problem.
// Use: Ideal for tasks that can be broken into smaller, similar tasks.
// returnType MethodName(parameters)
// {
//     if (baseCondition)
//     {
//         return baseValue;
//     }
//     else
//     {
//         return MethodName(modifiedParameters);
//     }
// }

// Example: Calculate factorial of a number using recursion.
// using System;

// namespace RecursionExample
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int number = 5;
//             int result = Factorial(number);
//             Console.WriteLine("Factorial of " + number + " is " + result);
//         }

//         static int Factorial(int n)
//         {
//             if (n <= 1)
//             {
//                 return 1;
//             }
//             else
//             {
//                 return n * Factorial(n - 1);
//             }
//         }
//     }
// }

