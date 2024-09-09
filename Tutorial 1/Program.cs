// Question 1: String Concatenation and Arithmetic Operations

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter your first name:");
//         string firstName = Console.ReadLine();

//         Console.WriteLine("Enter your last name:");
//         string lastName = Console.ReadLine();

//         Console.WriteLine("Enter your age:");
//         int age = int.Parse(Console.ReadLine());

//         string fullName = firstName + " " + lastName;
//         int yearsUntil100 = 100 - age;

//         Console.WriteLine($"Hello, {fullName}. You will turn 100 in {yearsUntil100} years.");
//     }
// }

// Question 2: String Length and Looping

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter a word:");
//         string word = Console.ReadLine();

//         for (int i = 0; i < word.Length; i++)
//         {
//             Console.WriteLine($"Character {i + 1}: {word[i]}");
//         }
//     }
// }

// Question 3: String Comparison and Conditional Statements

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter the first string:");
//         string str1 = Console.ReadLine();

//         Console.WriteLine("Enter the second string:");
//         string str2 = Console.ReadLine();

//         if (string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase))
//         {
//             Console.WriteLine("The strings are equal.");
//         }
//         else
//         {
//             Console.WriteLine("The strings are not equal.");
//         }
//     }
// }

// Question 4: String Interpolation and Mathematical Calculations

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter the radius of the circle:");
//         double radius = double.Parse(Console.ReadLine());

//         double area = Math.PI * Math.Pow(radius, 2);
//         double circumference = 2 * Math.PI * radius;

//         Console.WriteLine($"For a circle with radius {radius}, Area: {area:F2}, Circumference: {circumference:F2}");
//     }
// }

// Question 5: Substring and Vowel Counting

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter a sentence:");
//         string sentence = Console.ReadLine();
//         string firstWord = sentence.Split(' ')[0];

//         int vowelCount = 0;
//         foreach (char c in firstWord.ToLower())
//         {
//             if ("aeiou".Contains(c))
//             {
//                 vowelCount++;
//             }
//         }

//         Console.WriteLine($"The first word is '{firstWord}', which contains {vowelCount} vowels.");
//     }
// }
// Question 6: String Reversal and Palindrome Check

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter a string:");
//         string input = Console.ReadLine();
//         string reversed = "";

//         for (int i = input.Length - 1; i >= 0; i--)
//         {
//             reversed += input[i];
//         }

//         Console.WriteLine($"Reversed String: {reversed}");

//         if (string.Equals(input, reversed, StringComparison.OrdinalIgnoreCase))
//         {
//             Console.WriteLine("The string is a palindrome.");
//         }
//         else
//         {
//             Console.WriteLine("The string is not a palindrome.");
//         }
//     }
// }
// Question 7: Character Frequency Counter

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter a string:");
//         string input = Console.ReadLine();

//         Dictionary<char, int> frequency = new Dictionary<char, int>();

//         foreach (char c in input)
//         {
//             if (frequency.ContainsKey(c))
//             {
//                 frequency[c]++;
//             }
//             else
//             {
//                 frequency[c] = 1;
//             }
//         }

//         Console.WriteLine("Character frequencies:");
//         foreach (var pair in frequency)
//         {
//             Console.WriteLine($"{pair.Key}: {pair.Value}");
//         }
//     }
// }
// Question 8: String Formatting and Date Calculation

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter your birthdate (YYYY-MM-DD):");
//         DateTime birthdate = DateTime.Parse(Console.ReadLine());
//         TimeSpan ageSpan = DateTime.Now - birthdate;
//         int daysLived = (int)ageSpan.TotalDays;

//         Console.WriteLine($"You have lived {daysLived} days.");
//     }
// }
// Question 9: Capitalization and Looping

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter a sentence:");
//         string sentence = Console.ReadLine();
//         string[] words = sentence.Split(' ');

//         for (int i = 0; i < words.Length; i++)
//         {
//             if (words[i].Length > 0)
//             {
//                 words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
//             }
//         }

//         string capitalizedSentence = string.Join(" ", words);
//         Console.WriteLine($"Capitalized Sentence: {capitalizedSentence}");
//     }
// }
// Question 10: String Splitting and Word Count

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter a sentence:");
//         string sentence = Console.ReadLine();
//         string[] words = sentence.Split(' ');

//         Console.WriteLine($"Number of words: {words.Length}");

//         for (int i = 0; i < words.Length; i++)
//         {
//             Console.WriteLine($"Word {i + 1}: {words[i]}");
//         }
//     }
// }

// Question 11: Anagram Checker

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter the first string:");
//         string str1 = Console.ReadLine().Replace(" ", "").ToLower();

//         Console.WriteLine("Enter the second string:");
//         string str2 = Console.ReadLine().Replace(" ", "").ToLower();

//         char[] arr1 = str1.ToCharArray();
//         char[] arr2 = str2.ToCharArray();

//         Array.Sort(arr1);
//         Array.Sort(arr2);

//         if (new string(arr1) == new string(arr2))
//         {
//             Console.WriteLine("The strings are anagrams.");
//         }
//         else
//         {
//             Console.WriteLine("The strings are not anagrams.");
//         }
//     }
// }

// Question 12: String Compression Algorithm

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter a string:");
//         string input = Console.ReadLine();
//         string compressed = "";
//         int count = 1;

//         for (int i = 0; i < input.Length - 1; i++)
//         {
//             if (input[i] == input[i + 1])
//             {
//                 count++;
//             }
//             else
//             {
//                 compressed += input[i] + count.ToString();
//                 count = 1;
//             }
//         }

//         compressed += input[input.Length - 1] + count.ToString();

//         if (compressed.Length >= input.Length)
//         {
//             Console.WriteLine(input);
//         }
//         else
//         {
//             Console.WriteLine($"Compressed String: {compressed}");
//         }
//     }
// }

// Question 13: Caesar Cipher

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter a string to encrypt:");
//         string input = Console.ReadLine();

//         Console.WriteLine("Enter shift amount:");
//         int shift = int.Parse(Console.ReadLine());

//         string encrypted = "";
//         foreach (char c in input)
//         {
//             if (char.IsLetter(c))
//             {
//                 char d = char.IsUpper(c) ? 'A' : 'a';
//                 encrypted += (char)(((c + shift - d) % 26) + d);
//             }
//             else
//             {
//                 encrypted += c;
//             }
//         }

//         Console.WriteLine($"Encrypted String: {encrypted}");

//         string decrypted = "";
//         foreach (char c in encrypted)
//         {
//             if (char.IsLetter(c))
//             {
//                 char d = char.IsUpper(c) ? 'A' : 'a';
//                 decrypted += (char)(((c - shift - d + 26) % 26) + d);
//             }
//             else
//             {
//                 decrypted += c;
//             }
//         }

//         Console.WriteLine($"Decrypted String: {decrypted}");
//     }
// }
// Question 14: Longest Word Finder

// using System;
// using System.Linq;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter a sentence:");
//         string sentence = Console.ReadLine();
//         string[] words = sentence.Split(' ');

//         int maxLength = words.Max(word => word.Length);
//         var longestWords = words.Where(word => word.Length == maxLength);

//         Console.WriteLine($"Longest word(s): {string.Join(", ", longestWords)}");
//     }
// }
// Question 15: Advanced Palindrome Checker

// using System;
// using System.Text.RegularExpressions;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter a sentence:");
//         string input = Regex.Replace(Console.ReadLine().ToLower(), @"[^a-z]", "");
//         string reversed = new string(input.Reverse().ToArray());

//         if (input == reversed)
//         {
//             Console.WriteLine("The sentence is a palindrome.");
//         }
//         else
//         {
//             Console.WriteLine("The sentence is not a palindrome.");
//         }
//     }
// }
// Question 16: String Permutations

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter a string:");
//         string input = Console.ReadLine();
//         var result = new List<string>();
//         Permute(input, 0, input.Length - 1, result);

//         Console.WriteLine("Permutations:");
//         foreach (var permutation in result)
//         {
//             Console.WriteLine(permutation);
//         }
//     }

//     static void Permute(string str, int l, int r, List<string> result)
//     {
//         if (l == r)
//             result.Add(str);
//         else
//         {
//             for (int i = l; i <= r; i++)
//             {
//                 str = Swap(str, l, i);
//                 Permute(str, l + 1, r, result);
//                 str = Swap(str, l, i);
//             }
//         }
//     }

//     static string Swap(string a, int i, int j)
//     {
//         char temp;
//         char[] charArray = a.ToCharArray();
//         temp = charArray[i];
//         charArray[i] = charArray[j];
//         charArray[j] = temp;
//         return new string(charArray);
//     }
// }

// Question 17: Password Strength Checker

// using System;
// using System.Linq;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter a password:");
//         string password = Console.ReadLine();

//         int score = 0;

//         if (password.Length >= 8)
//             score++;
//         if (password.Any(char.IsUpper))
//             score++;
//         if (password.Any(char.IsLower))
//             score++;
//         if (password.Any(char.IsDigit))
//             score++;
//         if (password.Any(ch => !char.IsLetterOrDigit(ch)))
//             score++;

//         string strength = score switch
//         {
//             5 => "Very Strong",
//             4 => "Strong",
//             3 => "Medium",
//             2 => "Weak",
//             _ => "Very Weak",
//         };

//         Console.WriteLine($"Password Strength: {strength}");
//     }
// }

// Question 18: Advanced Substring Search

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter the main string:");
//         string mainString = Console.ReadLine();

//         Console.WriteLine("Enter the substring to find:");
//         string substringToFind = Console.ReadLine();

//         Console.WriteLine("Enter the substring to replace it with:");
//         string substringToReplace = Console.ReadLine();

//         string result = mainString.Replace(substringToFind, substringToReplace);

//         Console.WriteLine($"Resulting String: {result}");
//     }
// }

// Question 19: Sentence Reversal

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter a sentence:");
//         string sentence = Console.ReadLine();
//         string[] words = sentence.Split(' ');
//         Array.Reverse(words);

//         string reversedSentence = string.Join(" ", words);
//         Console.WriteLine($"Reversed Sentence: {reversedSentence}");
//     }
// }

// Question 20: Base Conversion

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter the number:");
//         string number = Console.ReadLine();

//         Console.WriteLine("Enter the current base (2 for binary, 8 for octal, 16 for hexadecimal):");
//         int currentBase = int.Parse(Console.ReadLine());

//         Console.WriteLine("Enter the desired base (10 for decimal, 8 for octal, 16 for hexadecimal):");
//         int desiredBase = int.Parse(Console.ReadLine());

//         int decimalValue = Convert.ToInt32(number, currentBase);
//         string convertedNumber = Convert.ToString(decimalValue, desiredBase);

//         Console.WriteLine($"Converted Number: {convertedNumber}");
//     }
// }
