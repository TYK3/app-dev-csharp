// C# First Program

// using System;

// namespace HelloWorld
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello, World!");
//         }
//     }
// }

// General Shortcuts:
// Ctrl + Shift + P opens the Command Palette.
// Ctrl + P opens Quick Open.
// Ctrl + N creates a new file.
// Ctrl + S saves the current file.
// Ctrl + Shift + S saves all files.
// F5 Run and Debug

// Code Editing Shortcuts:
// Ctrl + / comments the selected code.
// Ctrl + / uncomments the selected code.
// Alt + Shift + Down Arrow duplicates the current line.
// Ctrl + X cuts the current line.

// Navigation Shortcuts:
// F12 navigates to the definition.
// Ctrl + Shift + F finds in files.
// Ctrl + - zoom out.
// Ctrl + + zoom in.


//                         //
//        Data Types       //
//                         //


// using System;

// namespace IntegerTypes
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // int: Commonly used integer type
//             int age = 25;
//             Console.WriteLine("Age: " + age);

//             // long: Used for larger numbers
//             long distance = 9876543210;
//             Console.WriteLine("Distance: " + distance);

//             // short: Used for smaller numbers
//             short temperature = -10;
//             Console.WriteLine("Temperature: " + temperature);

//             // byte: Used for very small numbers or binary data
//             byte level = 255;
//             Console.WriteLine("Level: " + level);
//         }
//     }
// }

// using System;

// namespace FloatingPointTypes
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // float: Single-precision floating point, Less precision, used when memory savings are important.
//             float piFloat = 3.14f;
//             Console.WriteLine("Float value of Pi: " + piFloat);

//             // double: Double-precision floating point, More precision, commonly used for precise calculations.
//             double piDouble = 3.141592653589793;
//             Console.WriteLine("Double value of Pi: " + piDouble);
//         }
//     }
// }

// using System;

// namespace CharacterType
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // char: Represents a single character, Represents a single Unicode character.
//             char grade = 'A';
//             Console.WriteLine("Grade: " + grade);
//         }
//     }
// }

// using System;

// namespace BooleanType
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // bool: Represents a true or false value
//             bool isStudent = true;
//             Console.WriteLine("Is Student: " + isStudent);
//         }
//     }
// }

// using System;

// namespace VariableDeclaration
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Declare and initialize a variable
//             int age = 25;
//             Console.WriteLine("Age: " + age);
//         }
//     }
// }

// using System;

// namespace ConstantsExample
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Declare a constant value
//             const int MaxValue = 100;
//             Console.WriteLine("Max Value: " + MaxValue);

//             // MaxValue = 200;
//             // Console.WriteLine("Updated Max Value: " + MaxValue);
//         }
//     }
// }

// using System;

// namespace WithoutConstants
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int maxValue = 100; // Variable declaration
//             Console.WriteLine("Max Value: " + maxValue);

//             // Changing the value of maxValue
//             maxValue = 200;
//             Console.WriteLine("Updated Max Value: " + maxValue);
//         }
//     }
// }

// using System;

// namespace TypeConversion
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Implicit conversion from int to double
//             int num = 123;
//             double doubleNum = num;
//             Console.WriteLine("Implicit Conversion from int to double: " + doubleNum);

//             // Explicit conversion from double to int
//             double pi = 3.14;
//             int intPi = (int)pi; // Cast double to int
//             Console.WriteLine("Explicit Conversion from double to int: " + intPi);
//         }
//     }
// }

//                         //
//      Type of strings    //
//                         //

// Length: Returns the number of characters in the string.

// using System;

// namespace StringMethods
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string name = "Alice";
//             int length = name.Length;
//             Console.WriteLine($"The length of the string '{name}' is: {length}");
//         }
//     }
// }

// Substring: Extracts a portion of the string starting at a specified index.

// using System;

// namespace StringMethods
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string sentence = "Hello, World!";
//             string part = sentence.Substring(7, 5); // Start at index 7, length 5
//             Console.WriteLine($"Extracted substring: {part}");
//         }
//     }
// }

// IndexOf: Finds the index of the first occurrence of a substring within the string.

// using System;

// namespace StringMethods
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string sentence = "Hello, World!";
//             int index = sentence.IndexOf("World");
//             Console.WriteLine($"The index of 'World' in '{sentence}' is: {index}");
//         }
//     }
// }

// Replace: Replaces all occurrences of a specified substring with another substring.

// using System;

// namespace StringMethods
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string sentence = "Hello, World!";
//             string newSentence = sentence.Replace("World", "C#");
//             Console.WriteLine($"Original sentence: {sentence}");
//             Console.WriteLine($"Modified sentence: {newSentence}");
//         }
//     }
// }

// ToUpper: Converts the string to uppercase.

// using System;

// namespace StringMethods
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string lower = "hello world";
//             string upper = lower.ToUpper();
//             Console.WriteLine($"Original string: {lower}");
//             Console.WriteLine($"Uppercase string: {upper}");
//         }
//     }
// }

// ToLower: Converts the string to lowercase.

// using System;

// namespace StringMethods
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string upper = "HELLO WORLD";
//             string lower = upper.ToLower();
//             Console.WriteLine($"Original string: {upper}");
//             Console.WriteLine($"Lowercase string: {lower}");
//         }
//     }
// }

// Trim: Removes all leading and trailing white-space characters from the string.

// using System;

// namespace StringMethods
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string untrimmed = "   Hello, World!   ";
//             string trimmed = untrimmed.Trim();
//             Console.WriteLine($"Original string: '{untrimmed}'");
//             Console.WriteLine($"Trimmed string: '{trimmed}'");
//         }
//     }
// }

// Contains: Checks if the string contains a specified substring.

// using System;

// namespace StringMethods
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string sentence = "The quick brown fox";
//             bool containsFox = sentence.Contains("fox");
//             Console.WriteLine($"Does the sentence contain 'fox'? {containsFox}");
//         }
//     }
// }

// Split: Splits the string into an array of substrings based on a delimiter.

// using System;

// namespace StringMethods
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string names = "Alice,Bob,Charlie";
//             string[] nameArray = names.Split(',');
//             Console.WriteLine("Names in the array:");
//             foreach (string name in nameArray)
//             {
//                 Console.WriteLine(name);
//             }
//         }
//     }
// }

// Join: Joins an array of strings into a single string with a specified delimiter.

// using System;

// namespace StringMethods
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string[] nameArray = { "Alice", "Bob", "Charlie" };
//             string names = string.Join(", ", nameArray);
//             Console.WriteLine($"Joined string: {names}");
//         }
//     }
// }

// String Interpolation: Embeds expressions inside string literals.

// using System;

// namespace StringInterpolation
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string name = "Alice";
//             int age = 25;
//             string hobby = "painting";
//             string message = $"Name: {name}, Age: {age}, Hobby: {hobby}";
//             Console.WriteLine(message);
//         }
//     }
// }

// String Formatting: Uses String.Format for complex formatting.

// using System;

// namespace StringFormatting
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string name = "Alice";
//             int age = 25;
//             string hobby = "painting";
//             string formattedMessage = String.Format("Name: {0}, Age: {1}, Hobby: {2}", name, age, hobby);
//             Console.WriteLine(formattedMessage);
//         }
//     }
// }

// Currency Formatting: Format a number as currency.

// using System;

// namespace StringFormatting
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             double price = 123.45;
//             string formattedPrice = String.Format("Price: {0:C}", price);
//             Console.WriteLine(formattedPrice);
//         }
//     }
// }

// Date Formatting: Format a DateTime object.

// using System;

// namespace StringFormatting
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             DateTime today = DateTime.Now;
//             string formattedDate = String.Format("Today is {0:MMMM dd, yyyy}", today);
//             Console.WriteLine(formattedDate);
//         }
//     }
// }

// Reverse a String: Reverses the characters in a string.

// using System;

// namespace StringManipulation
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string original = "C# Programming";
//             char[] charArray = original.ToCharArray();
//             Array.Reverse(charArray);
//             string reversed = new string(charArray);
//             Console.WriteLine($"Original string: {original}");
//             Console.WriteLine($"Reversed string: {reversed}");
//         }
//     }
// }



