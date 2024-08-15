// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Declare and initialize an array of integers
//         int[] numbers = { 10, 20, 30, 40, 50 };

//         // Access and print the elements of the array
//         Console.WriteLine("Array elements:");

//         for (int i = 0; i < numbers.Length; i++)
//         {
//             Console.WriteLine($"Element at index {i}: {numbers[i]}");
//         }

//         // Modify an element of the array
//         numbers[2] = 100; // Changing the third element (index 2) to 100

//         Console.WriteLine("\nArray after modification:");
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             Console.WriteLine($"Element at index {i}: {numbers[i]}");
//         }
//     }
// }




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
//             Console.Write("Enter the age: ");
//             int age = int.Parse(Console.ReadLine());

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
//             Console.Write("Enter the grade: ");
//             string input = Console.ReadLine();

//             if (input.Length != 1)
//             {
//                 Console.WriteLine("Invalid input. Please enter a single character.");
//                 return;
//             }

//             char grade = char.ToUpper(input[0]);

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
//             for (int i = 1; i <= 10; i+=3)
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
//                 i+=3;
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

//                  //
//     Subtopic     //
//     Questions    //
//                  //

// 1. if-elseif-else Scenario: Grade Categorization

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter the student's grade: ");
//         int grade = int.Parse(Console.ReadLine());

//         if (grade < 0 || grade > 100)
//         {
//             Console.WriteLine("Error: Grade must be between 0 and 100.");
//         }
//         else if (grade < 50)
//         {
//             Console.WriteLine($"The grade {grade} is considered Failing.");
//         }
//         else if (grade >= 50 && grade <= 69)
//         {
//             Console.WriteLine($"The grade {grade} is considered Passing.");
//         }
//         else if (grade >= 70 && grade <= 89)
//         {
//             Console.WriteLine($"The grade {grade} is considered Good.");
//         }
//         else
//         {
//             Console.WriteLine($"The grade {grade} is considered Excellent.");
//         }
//     }
// }

// 2. switch Scenario: Calculator
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter the first number: ");
//         string input1 = Console.ReadLine();
//         if (!double.TryParse(input1, out double num1))
//         {
//             Console.WriteLine("Error: Please enter a valid number for the first input.");
//             return;
//         }

//         Console.Write("Enter the second number: ");
//         string input2 = Console.ReadLine();
//         if (!double.TryParse(input2, out double num2))
//         {
//             Console.WriteLine("Error: Please enter a valid number for the second input.");
//             return;
//         }

//         Console.Write("Enter the operation (+, -, *, /, %): ");
//         string operationInput = Console.ReadLine();
//         if (operationInput.Length != 1)
//         {
//             Console.WriteLine("Error: Invalid operator.");
//             return;
//         }

//         char operation = operationInput[0];

//         double result = 0; // Initialize result to avoid any uninitialized usage

//         switch (operation)
//         {
//             case '+':
//                 result = num1 + num2;
//                 Console.WriteLine($"Result: {num1} + {num2} = {result}");
//                 break;
//             case '-':
//                 result = num1 - num2;
//                 Console.WriteLine($"Result: {num1} - {num2} = {result}");
//                 break;
//             case '*':
//                 result = num1 * num2;
//                 Console.WriteLine($"Result: {num1} * {num2} = {result}");
//                 break;
//             case '/':
//                 if (num2 != 0)
//                 {
//                     result = num1 / num2;
//                     Console.WriteLine($"Result: {num1} / {num2} = {result}");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Error: Division by zero is not allowed.");
//                 }
//                 break;
//             case '%':
//                 if (num2 != 0)
//                 {
//                     result = num1 % num2;
//                     Console.WriteLine($"Result: {num1} % {num2} = {result}");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Error: Modulus by zero is not allowed.");
//                 }
//                 break;
//             default:
//                 Console.WriteLine("Error: Invalid operator.");
//                 break;
//         }
//     }
// }


// 3. for Scenario: Prime Number Check

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter a number: ");
//         int number = int.Parse(Console.ReadLine());

//         if (number < 2)
//         {
//             Console.WriteLine($"{number} is not a prime number.");
//         }
//         else
//         {
//             bool isPrime = true;

//             for (int i = 2; i * i <= number; i++)
//             {
//                 if (number % i == 0)
//                 {
//                     isPrime = false;
//                     break;
//                 }
//             }

//             if (isPrime)
//             {
//                 Console.WriteLine($"{number} is a prime number.");
//             }
//             else
//             {
//                 Console.WriteLine($"{number} is not a prime number.");
//             }
//         }
//     }
// }

// 4. foreach Scenario: Word Length Analysis

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter a sentence: ");
//         string sentence = Console.ReadLine();

//         string[] words = sentence.Split(' ');

//         int count = 0;

//         foreach (string word in words)
//         {
//             if (word.Length > 5)
//             {
//                 count++;
//             }
//         }

//         Console.WriteLine($"Number of words with more than 5 characters: {count}");
//     }
// }

// 5. while Scenario: Number Guessing Game

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Random random = new Random();
//         int targetNumber = random.Next(1, 101);

//         Console.WriteLine("Guess the number (between 1 and 100):");

//         while (true)
//         {
//             Console.Write("Enter your guess: ");
//             int guess = int.Parse(Console.ReadLine());

//             if (guess < targetNumber)
//             {
//                 Console.WriteLine("Too low! Try again.");
//             }
//             else if (guess > targetNumber)
//             {
//                 Console.WriteLine("Too high! Try again.");
//             }
//             else
//             {
//                 Console.WriteLine("Congratulations! You guessed the correct number.");
//                 break;
//             }
//         }
//     }
// }

// 6. do-while Scenario: Password Validator

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         string password;
//         bool isValid;

//         do
//         {
//             Console.Write("Enter a password: ");
//             password = Console.ReadLine();

//             isValid = password.Length >= 8 && 
//                       ContainsUpper(password) && 
//                       ContainsLower(password) && 
//                       ContainsDigit(password);

//             if (!isValid)
//             {
//                 Console.WriteLine("Password does not meet the criteria. Try again.");
//             }
//         } while (!isValid);

//         Console.WriteLine("Password accepted!");

//     }

//     static bool ContainsUpper(string input)
//     {
//         foreach (char c in input)
//         {
//             if (char.IsUpper(c))
//                 return true;
//         }
//         return false;
//     }

//     static bool ContainsLower(string input)
//     {
//         foreach (char c in input)
//         {
//             if (char.IsLower(c))
//                 return true;
//         }
//         return false;
//     }

//     static bool ContainsDigit(string input)
//     {
//         foreach (char c in input)
//         {
//             if (char.IsDigit(c))
//                 return true;
//         }
//         return false;
//     }
// }

// 7. break Scenario: Sum of Positive Numbers

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int sum = 0;

//         while (true)
//         {
//             Console.Write("Enter a number: ");
//             int number = int.Parse(Console.ReadLine());

//             if (number < 0)
//             {
//                 break;
//             }

//             sum += number;
//         }

//         Console.WriteLine($"Total sum of positive numbers: {sum}");
//     }
// }

// 8. continue Scenario: Skip Even Numbers

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Enter 10 integers:");

//         for (int i = 1; i <= 10; i++)
//         {
//             Console.Write($"Enter number {i}: ");
//             int number = int.Parse(Console.ReadLine());

//             if (number % 2 == 0)
//             {
//                 continue; // Skip even numbers
//             }

//             Console.WriteLine($"Odd number: {number}");
//         }
//     }
// }

// 9. recursion Scenario: Recursive Factorial

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter a number: ");
//         int number = int.Parse(Console.ReadLine());

//         long factorial = CalculateFactorial(number);
//         Console.WriteLine($"The factorial of {number} is {factorial}.");
//     }

//     static long CalculateFactorial(int n)
//     {
//         if (n == 0 || n == 1)
//         {
//             return 1;
//         }
//         return n * CalculateFactorial(n - 1);
//     }
// }

//                  //
//     Questions    //
//                  //

// Question 1: Checking Even or Odd
// Task:
// Write a C# program that prompts the user to enter an integer. 
// Use an if-else statement to check if the number is even or odd, 
// and then print the result using string interpolation.

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter an integer: ");
//         int number = int.Parse(Console.ReadLine());

//         if (number % 2 == 0)
//         {
//             Console.WriteLine($"The number {number} is even.");
//         }
//         else
//         {
//             Console.WriteLine($"The number {number} is odd.");
//         }
//     }
// }

// Question 2: Validating Input Range
// Task:
// Create a C# program that asks the user to input an integer between 1 
// and 100. Use an if-else statement to validate the input. If the number 
// is within the range, print a success message; otherwise, print an error 
// message formatted with string interpolation.

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter a number between 1 and 100: ");
//         int number = int.Parse(Console.ReadLine());

//         if (number >= 1 && number <= 100)
//         {
//             Console.WriteLine($"{number} is within the valid range.");
//         }
//         else
//         {
//             Console.WriteLine($"{number} is not within the valid range.");
//         }
//     }
// }

// Question 3: Determining Grade Category
// Task:
// Write a C# program that takes a student's grade (a double) as input and 
// uses a switch statement to categorize the grade into "Excellent", "Good",
// "Average", or "Fail". Use string formatting to display the category.

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter the student's grade: ");
//         double grade = double.Parse(Console.ReadLine());

//         string category;

//         switch (grade)
//         {
//             case >= 90:
//                 category = "Excellent";
//                 break;
//             case >= 75:
//                 category = "Good";
//                 break;
//             case >= 50:
//                 category = "Average";
//                 break;
//             default:
//                 category = "Fail";
//                 break;
//         }

//         Console.WriteLine($"The grade {grade} is considered {category}.");
//     }
// }

// Question 4: Formatting a Price with Tax
// Task:
// Create a C# program that asks the user for the price of an item (a double).
// Use an if-else statement to apply a 10% tax if the price is above $100. 
// Print the original price, tax, and final price using string interpolation.

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter the price of the item: ");
//         double price = double.Parse(Console.ReadLine());

//         double tax = 0;

//         if (price > 100)
//         {
//             tax = price * 0.1;
//         }

//         double finalPrice = price + tax;

//         Console.WriteLine($"Original Price: {price:C}");
//         Console.WriteLine($"Tax: {tax:C}");
//         Console.WriteLine($"Final Price: {finalPrice:C}");
//     }
// }

// Question 5: Identifying the Largest of Three Numbers
// Task:
// Write a C# program that prompts the user to input three integers. 
// Use nested if-else statements to determine the largest of the three 
// numbers and print the result using string interpolation.

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter the first number: ");
//         int num1 = int.Parse(Console.ReadLine());

//         Console.Write("Enter the second number: ");
//         int num2 = int.Parse(Console.ReadLine());

//         Console.Write("Enter the third number: ");
//         int num3 = int.Parse(Console.ReadLine());

//         int largest;

//         if (num1 >= num2 && num1 >= num3)
//         {
//             largest = num1;
//         }
//         else if (num2 >= num1 && num2 >= num3)
//         {
//             largest = num2;
//         }
//         else
//         {
//             largest = num3;
//         }

//         Console.WriteLine($"The largest number is {largest}.");
//     }
// }

// Program 1: Student Grade Analysis
// Requirements:

// -Create a program that takes the names and grades of five students using a for loop and stores them in arrays.
// -Calculate the average grade and display the result.
// -Use a foreach loop to find and print the names of students who scored above the average.
// -Implement a method that recursively calculates the sum of all grades.
// -Display the highest and lowest grades using conditional statements.

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         string[] names = new string[5];
//         int[] grades = new int[5];

//         // Step 1: Taking input from the user
//         for (int i = 0; i < 5; i++)
//         {
//             Console.Write($"Enter the name of student {i + 1}: ");
//             names[i] = Console.ReadLine();

//             Console.Write($"Enter the grade of student {i + 1}: ");
//             grades[i] = int.Parse(Console.ReadLine());
//         }

//         // Step 2: Calculating the average grade
//         double average = CalculateAverage(grades);
//         Console.WriteLine($"\nThe average grade is: {average}");

//         // Step 3: Finding and printing names of students who scored above average
//         Console.WriteLine("\nStudents who scored above average:");
//         for (int i = 0; i < 5; i++)
//         {
//             if (grades[i] > average)
//             {
//                 Console.WriteLine(names[i]);
//             }
//         }

//         // Step 4: Finding the highest and lowest grades
//         int highestGrade = grades[0];
//         string highestName = names[0];

//         int lowestGrade = grades[0];
//         string lowestName = names[0];

//         for (int i = 1; i < 5; i++)
//         {
//             if (grades[i] > highestGrade)
//             {
//                 highestGrade = grades[i];
//                 highestName = names[i];
//             }
//             if (grades[i] < lowestGrade)
//             {
//                 lowestGrade = grades[i];
//                 lowestName = names[i];
//             }
//         }

//         Console.WriteLine($"\nHighest grade: {highestGrade} by {highestName}");
//         Console.WriteLine($"Lowest grade: {lowestGrade} by {lowestName}");
//     }

//     static double CalculateAverage(int[] grades)
//     {
//         int sum = 0;
//         for (int i = 0; i < grades.Length; i++)
//         {
//             sum += grades[i];
//         }
//         return (double)sum / grades.Length;
//     }
// }



// Program 2: Recursive String Manipulation
// Requirements:

// -Create a program that takes a string input from the user and recursively reverses the string.
// -Implement a method to count the number of vowels in the string using a foreach loop.
// -Use an if-else statement to check if the reversed string is a palindrome (same forwards and backwards).
// -Implement string concatenation to combine the original string with its reversed version.
// -Display the original string, reversed string, and whether it is a palindrome.

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter a string: ");
//         string input = Console.ReadLine();

//         string reversed = ReverseString(input);
//         Console.WriteLine($"Reversed string: {reversed}");

//         bool isPalindrome = input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
//         Console.WriteLine($"Is palindrome: {(isPalindrome ? "Yes" : "No")}");

//         string combined = input + reversed;
//         Console.WriteLine($"Combined string: {combined}");

//         int vowelCount = CountVowels(input);
//         Console.WriteLine($"Number of vowels: {vowelCount}");
//     }

//     static string ReverseString(string s)
//     {
//         if (s.Length <= 1)
//             return s;

//         return s[^1] + ReverseString(s.Substring(0, s.Length - 1));
//     }

//     static int CountVowels(string s)
//     {
//         int count = 0;
//         foreach (char c in s.ToLower())
//         {
//             if ("aeiou".Contains(c))
//                 count++;
//         }
//         return count;
//     }
// }



// Program 3: Recursive Factorial and String Formatter
// Requirements:

// -Write a program that calculates the factorial of a number using a recursive method.
// -Implement a loop that repeatedly prompts the user to enter a number until a valid positive integer is provided.
// -Format the output to display the factorial result with string interpolation.
// -Use an if-else statement to check if the factorial result exceeds 10,000 and display a warning message if it does.
// -Provide an option to the user to calculate another factorial or exit the program using a switch statement.

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         string userInput;

//         do
//         {
//             Console.Write("Enter a positive integer: ");
//             int number;
//             while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
//             {
//                 Console.Write("Please enter a valid positive integer: ");
//             }

//             long factorial = CalculateFactorial(number);
//             Console.WriteLine($"Factorial of {number} is {factorial}");

//             if (factorial > 10000)
//             {
//                 Console.WriteLine("Warning: Factorial exceeds 10,000!");
//             }

//             Console.Write("Enter another number? (yes/no): ");
//             userInput = Console.ReadLine().ToLower();

//         } while (userInput == "yes");

//         Console.WriteLine("Exiting program. Goodbye!");
//     }

//     static long CalculateFactorial(int n)
//     {
//         if (n == 1)
//             return 1;
//         return n * CalculateFactorial(n - 1);
//     }
// }


// Program 4: Text Analyzer with Multiple Conditions
// Requirements:

// -Create a program that prompts the user to enter a sentence.
// -Use a for loop to iterate through each character and count the number of words, vowels, and consonants.
// -Implement a switch statement to categorize the sentence length as "Short", "Medium", or "Long".
// -Create a method that recursively removes all spaces from the sentence.
// -Display the original sentence, the number of words, vowels, consonants, and the categorized length.

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter a sentence: ");
//         string sentence = Console.ReadLine();

//         int wordCount = 1, vowelCount = 0, consonantCount = 0;

//         for (int i = 0; i < sentence.Length; i++)
//         {
//             if (sentence[i] == ' ')
//             {
//                 wordCount++;
//             }
//             else if ("aeiouAEIOU".Contains(sentence[i]))
//             {
//                 vowelCount++;
//             }
//             else if (char.IsLetter(sentence[i]))
//             {
//                 consonantCount++;
//             }
//         }

//         Console.WriteLine($"Words: {wordCount}");
//         Console.WriteLine($"Vowels: {vowelCount}");
//         Console.WriteLine($"Consonants: {consonantCount}");

//         string lengthCategory = sentence.Length switch
//         {
//             <= 20 => "Short",
//             <= 50 => "Medium",
//             _ => "Long"
//         };

//         Console.WriteLine($"Sentence Length: {lengthCategory}");

//         string sentenceWithoutSpaces = RemoveSpaces(sentence);
//         Console.WriteLine($"Sentence without spaces: {sentenceWithoutSpaces}");
//     }

//     static string RemoveSpaces(string s)
//     {
//         if (s.Length == 0)
//             return s;

//         char firstChar = s[0];
//         if (firstChar == ' ')
//             return RemoveSpaces(s.Substring(1));

//         return firstChar + RemoveSpaces(s.Substring(1));
//     }
// }


// Program 5: Recursive Array Processing and Search
// Requirements:

// -Create a program that takes five integers from the user and stores them in an array.
// -Implement a recursive method to calculate the sum of the elements in the array.
// -Use a foreach loop to print the array elements in reverse order.
// -Implement a linear search using a for loop and conditional statements to find if a specific number exists in the array.
// -If the number is found, display its position in the array; otherwise, indicate that it was not found.
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Step 1: Taking input from the user
//         Console.Write("Enter number 1: ");
//         int num1 = int.Parse(Console.ReadLine());

//         Console.Write("Enter number 2: ");
//         int num2 = int.Parse(Console.ReadLine());

//         Console.Write("Enter number 3: ");
//         int num3 = int.Parse(Console.ReadLine());

//         Console.Write("Enter number 4: ");
//         int num4 = int.Parse(Console.ReadLine());

//         Console.Write("Enter number 5: ");
//         int num5 = int.Parse(Console.ReadLine());

//         // Step 2: Calculating the sum
//         int sum = num1 + num2 + num3 + num4 + num5;
//         Console.WriteLine($"Sum of the numbers: {sum}");

//         // Step 3: Displaying the numbers in reverse order
//         string reversed = $"{num5} {num4} {num3} {num2} {num1}";
//         Console.WriteLine($"Numbers in reverse order: {reversed}");

//         // Step 4: Searching for a specific number
//         Console.Write("Enter a number to search for: ");
//         int searchNumber = int.Parse(Console.ReadLine());

//         bool found = false;
//         if (searchNumber == num1)
//         {
//             Console.WriteLine("Number found: It matches number 1");
//             found = true;
//         }
//         else if (searchNumber == num2)
//         {
//             Console.WriteLine("Number found: It matches number 2");
//             found = true;
//         }
//         else if (searchNumber == num3)
//         {
//             Console.WriteLine("Number found: It matches number 3");
//             found = true;
//         }
//         else if (searchNumber == num4)
//         {
//             Console.WriteLine("Number found: It matches number 4");
//             found = true;
//         }
//         else if (searchNumber == num5)
//         {
//             Console.WriteLine("Number found: It matches number 5");
//             found = true;
//         }

//         if (!found)
//         {
//             Console.WriteLine("Number not found.");
//         }
//     }
// }
