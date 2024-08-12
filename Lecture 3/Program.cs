// using System;

// namespace Collections
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[] numbers = { 1, 2, 3, 4, 5 };

//             // Modify the array
//             numbers[0] = 10;

//             // Print the array
//             Console.WriteLine("Array elements:");
//             foreach (int number in numbers)
//             {
//                 Console.WriteLine(number);
//             }
//         }
//     }
// }

// Example: Create and manipulate both single-dimensional and multi-dimensional arrays.

// using System;

// namespace Collections
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Single-Dimensional Array
//             int[] numbers = { 1, 2, 3, 4, 5 };

//             // Modify the array
//             numbers[0] = 10;

//             // Print the single-dimensional array
//             Console.WriteLine("Single-Dimensional Array elements:");
//             foreach (int number in numbers)
//             {
//                 Console.WriteLine(number);
//             }

//             // Multi-Dimensional Array (2x3 matrix)
//             int[,] matrix = new int[2, 3] 
//             {
//                 { 1, 2, 3 },
//                 { 4, 5, 6 }
//             };

//             // Modify an element in the multi-dimensional array
//             matrix[0, 0] = 10; // Changing the first element

//             // Print the multi-dimensional array
//             Console.WriteLine("\nMulti-Dimensional Array (2x3 matrix) elements:");
//             for (int i = 0; i < 2; i++)
//             {
//                 for (int j = 0; j < 3; j++)
//                 {
//                     Console.Write(matrix[i, j] + " ");
//                 }
//                 Console.WriteLine(); // New line after each row
//             }
//         }
//     }
// }

// Example: Demonstrating Add, Remove, Contains, IndexOf, Insert, and Clear with a List.

// using System;
// using System.Collections.Generic;

// namespace Collections
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Create a list of integers
//             List<int> numbers = new List<int> { 1, 2, 3 };

//             // Add elements to the list
//             numbers.Add(4);
//             numbers.Add(5);
//             Console.WriteLine("After adding elements:");
//             PrintList(numbers);

//             // Remove an element from the list
//             numbers.Remove(2);
//             Console.WriteLine("After removing element '2':");
//             PrintList(numbers);

//             // Check if the list contains an element
//             bool containsThree = numbers.Contains(3);
//             Console.WriteLine($"List contains 3: {containsThree}");

//             // Find the index of an element
//             int indexOfFour = numbers.IndexOf(4);
//             Console.WriteLine($"Index of 4: {indexOfFour}");

//             // Insert an element at a specific index
//             numbers.Insert(2, 10); // Inserts 10 at index 2
//             Console.WriteLine("After inserting '10' at index 2:");
//             PrintList(numbers);

//             // Clear the list
//             numbers.Clear();
//             Console.WriteLine("After clearing the list:");
//             PrintList(numbers);
//         }

//         static void PrintList(List<int> list)
//         {
//             if (list.Count > 0)
//             {
//                 foreach (int number in list)
//                 {
//                     Console.WriteLine(number);
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("The list is empty.");
//             }
//         }
//     }
// }

// Example: Comprehensive Dictionary Operations

// using System;
// using System.Collections.Generic;

// namespace DictionaryExample
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Create a dictionary with int keys and string values
//             Dictionary<int, string> students = new Dictionary<int, string>();

//             // Add elements to the dictionary
//             students.Add(1, "Alice");
//             students.Add(2, "Bob");
//             students.Add(3, "Charlie");

//             Console.WriteLine("After adding elements:");
//             PrintDictionary(students);

//             // Remove an element by key
//             students.Remove(2);
//             Console.WriteLine("\nAfter removing key '2':");
//             PrintDictionary(students);

//             // Check if the dictionary contains a specific key
//             bool containsKey = students.ContainsKey(1);
//             Console.WriteLine($"\nDictionary contains key '1': {containsKey}");

//             // Check if the dictionary contains a specific value
//             bool containsValue = students.ContainsValue("Charlie");
//             Console.WriteLine($"Dictionary contains value 'Charlie': {containsValue}");

//             // Try to get a value with a specific key
//             if (students.TryGetValue(3, out string studentName))
//             {
//                 Console.WriteLine($"\nValue associated with key '3': {studentName}");
//             }
//             else
//             {
//                 Console.WriteLine("\nKey '3' not found in the dictionary.");
//             }

//             // Get the count of elements in the dictionary
//             int count = students.Count;
//             Console.WriteLine($"\nNumber of elements in the dictionary: {count}");

//             // Clear the dictionary
//             students.Clear();
//             Console.WriteLine("\nAfter clearing the dictionary:");
//             PrintDictionary(students);
//         }

//         static void PrintDictionary(Dictionary<int, string> dict)
//         {
//             if (dict.Count > 0)
//             {
//                 foreach (var kvp in dict)
//                 {
//                     Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("The dictionary is empty.");
//             }
//         }
//     }
// }

// Example: Working with Sets in C#

// using System;
// using System.Collections.Generic;

// namespace SetOperations
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Create two sets
//             HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4 };
//             HashSet<int> setB = new HashSet<int> { 3, 4, 5, 6 };

//             // Add an element to setA
//             setA.Add(7);
//             Console.WriteLine("After adding 7 to setA:");
//             PrintSet(setA);

//             // Remove an element from setA
//             setA.Remove(1);
//             Console.WriteLine("\nAfter removing 1 from setA:");
//             PrintSet(setA);

//             // Perform a union of setA and setB
//             setA.UnionWith(setB);
//             Console.WriteLine("\nAfter union of setA and setB:");
//             PrintSet(setA);

//             // Perform an intersection of setA and setB
//             setA.IntersectWith(setB);
//             Console.WriteLine("\nAfter intersection of setA and setB:");
//             PrintSet(setA);

//             // Perform a difference of setA and setB (removes elements of setB from setA)
//             setA.ExceptWith(setB);
//             Console.WriteLine("\nAfter difference (setA except setB):");
//             PrintSet(setA);

//             // Perform a symmetric difference (elements in either setA or setB but not in both)
//             setA.SymmetricExceptWith(setB);
//             Console.WriteLine("\nAfter symmetric difference of setA and setB:");
//             PrintSet(setA);

//             // Check if setA contains a specific element
//             bool containsThree = setA.Contains(3);
//             Console.WriteLine($"\nSetA contains 3: {containsThree}");

//             // Check if setA equals setB
//             bool setsEqual = setA.SetEquals(setB);
//             Console.WriteLine($"\nSetA equals SetB: {setsEqual}");
//         }

//         static void PrintSet(HashSet<int> set)
//         {
//             Console.WriteLine("Set elements:");
//             foreach (int element in set)
//             {
//                 Console.WriteLine(element);
//             }
//         }
//     }
// }
