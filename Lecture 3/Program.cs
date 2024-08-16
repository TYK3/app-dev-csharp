//Arrays
// -An array is a collection of items of the same type stored 
// at contiguous memory locations. Arrays are fixed in size, 
// meaning once you define the size of an array, you can’t change it.
// -Common operations with arrays include searching, sorting, and modifying elements. 
// However, remember that arrays are of a fixed size, so they’re not always the most 
// flexible choice.

//An array named numbers that can store 5 integers. By default, all elements 
//in the array are initialized to 0
// int[] numbers = new int[5]; // An array of 5 integers

// // Access elements in an array using their index, which starts at 0
// numbers[0] = 10; // Set the first element to 10
// Console.WriteLine(numbers[0]); // Output: 10

// //Use a for loop to iterate through an array and perform operations on each element.
// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.WriteLine(numbers[i]);
// }

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

//List
// -A List in C# is a dynamic collection that can grow or shrink as needed, 
// making it more flexible than an array.
// -Lists are more versatile than arrays because they can dynamically 
// adjust their size. However, they use more memory because of this flexibility.

// //create a list of integers
// List<int> numbers = new List<int>();

// //add elements to a list using the Add method.
// numbers.Add(10);
// numbers.Add(20);

// //access elements in a list using an index.
// Console.WriteLine(numbers[0]); // Output: 10

// // remove elements from a list using the Remove method.
// numbers.Remove(10); // Removes the first occurrence of 10

// //iterate through a list using a foreach loop, which is a bit more readable than a for loop.
// foreach (int number in numbers)
// {
//     Console.WriteLine(number);
// }

// using System;
// using System.Collections.Generic;

// namespace Collections
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             List<int> numbers = new List<int> { 1, 2, 3 };

//             // Add and remove elements
//             numbers.Add(4);
//             numbers.Remove(2);

//             // Print the list
//             Console.WriteLine("List elements:");
//             foreach (int number in numbers)
//             {
//                 Console.WriteLine(number);
//             }
//         }
//     }
//  }



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
//             Console.WriteLine("\nAfter removing element '2':");
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

//Dictionary
// -Dictionary in C# is a collection of key-value pairs. 
// Each key in a dictionary is unique,
// and it’s used to access the corresponding value.
// -Dictionaries are very efficient for lookups when you have unique keys, 
// but they require a bit more overhead compared to lists and arrays

// //create a dictionary where the key is a string and 
// //the value is an integer
// Dictionary<string, int> ages = new Dictionary<string, int>();

// //add key-value pairs to a dictionary using the Add method.
// ages.Add("Alice", 25);
// ages.Add("Bob", 30);

// // To access a value, you use the corresponding key.
// Console.WriteLine(ages["Alice"]); // Output: 25

// // remove a key-value pair using the Remove method.
// ages.Remove("Alice");

// //iterate through a dictionary using a foreach loop to access both keys and values.
// foreach (var pair in ages)
// {
//     Console.WriteLine($"{pair.Key}: {pair.Value}");
// }

// using System;
// using System.Collections.Generic;

// namespace Collections
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Dictionary<int, string> students = new Dictionary<int, string>();

//             // Add elements
//             students.Add(1, "Alice");
//             students.Add(2, "Bob");

//             // Remove an element
//             students.Remove(1);

//             // Print the dictionary
//             Console.WriteLine("Dictionary elements:");
//             foreach (var student in students)
//             {
//                 Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
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

// Set
// -A Set in C# is a collection that contains unique elements. 
// This means that it automatically prevents duplicates, 
// making it useful when you want to ensure that your collection has only distinct items.
// -Sets are especially useful when you need to ensure that a collection has no duplicates 
// and when the order of elements is not important.

// //create a set of integers
// HashSet<int> numbers = new HashSet<int>();

// //add elements to a set using the Add method.
// numbers.Add(10);
// numbers.Add(20);
// numbers.Add(10); // This will not add another 10, as it’s a duplicate

// //iterate through a set using a foreach loop.
// foreach (int number in numbers)
// {
//     Console.WriteLine(number);
// }

// using System;
// using System.Collections.Generic;

// namespace Collections
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             HashSet<int> numbers = new HashSet<int> { 1, 2, 3, 4 };

//             // Add elements
//             numbers.Add(5);
//             numbers.Add(3); // Duplicate, won't be added

//             // Print the set
//             Console.WriteLine("Set elements:");
//             foreach (int number in numbers)
//             {
//                 Console.WriteLine(number);
//             }

//             // Perform a union operation with another set
//             HashSet<int> otherNumbers = new HashSet<int> { 3, 4, 5, 6 };
//             numbers.UnionWith(otherNumbers);

//             Console.WriteLine("Set after union:");
//             foreach (int number in numbers)
//             {
//                 Console.WriteLine(number);
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
//             // Original sets
//             HashSet<int> originalSetA = new HashSet<int> { 1, 2, 3, 4 };
//             HashSet<int> setB = new HashSet<int> { 3, 4, 5, 6 };

//             // Clone original setA to preserve its state
//             HashSet<int> setA = new HashSet<int>(originalSetA);

//             // Add an element to setA
//             setA.Add(7);
//             Console.WriteLine("After adding 7 to setA:");
//             PrintSet(setA);

//             // Reset setA to original
//             setA = new HashSet<int>(originalSetA);

//             // Remove an element from setA
//             setA.Remove(1);
//             Console.WriteLine("\nAfter removing 1 from setA:");
//             PrintSet(setA);

//             // Reset setA to original
//             setA = new HashSet<int>(originalSetA);

//             // Perform a union of setA and setB
//             setA.UnionWith(setB);
//             Console.WriteLine("\nAfter union of setA and setB:");
//             PrintSet(setA);

//             // Reset setA to original
//             setA = new HashSet<int>(originalSetA);

//             // Perform an intersection of setA and setB
//             setA.IntersectWith(setB);
//             Console.WriteLine("\nAfter intersection of setA and setB:");
//             PrintSet(setA);

//             // Reset setA to original
//             setA = new HashSet<int>(originalSetA);

//             // Perform a difference of setA and setB (removes elements of setB from setA)
//             setA.ExceptWith(setB);
//             Console.WriteLine("\nAfter difference (setA except setB):");
//             PrintSet(setA);

//             // Reset setA to original
//             setA = new HashSet<int>(originalSetA);

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

// // Generics
// -Generics allow you to define a class, method, delegate, or interface with 
// a placeholder for the data type. This makes your code more reusable and type-safe.
// -A generic in C# is a feature that allows you to write flexible and reusable code 
// by working 
// with any data type without specifying it in advance. It’s like a template that can 
// handle different 
// types of data without needing to write separate code for each type
// -Imagine you have a box that can hold different things. Sometimes you might want it 
// to hold apples, 
// and other times you might want it to hold oranges. A generic is like that box—it can
//  hold any type of item, 
// but you decide what type when you use it.
// -generics help you write code that is more flexible, reusable, and safe, because you 
// can specify the type of data 
// it will work with only when you actually use it. This way, you avoid making mistakes 
// like putting the wrong type 
// of item in the wrong place.

// List<int> numberList = new List<int>(); // A list that holds integers
// List<string> wordList = new List<string>(); // A list that holds strings

// // A non-generic list, such as ArrayList, can store items of any data type. 
// // However, this flexibility comes at the cost of type safety
// System.Collections.ArrayList nonGenericList = new System.Collections.ArrayList();
// nonGenericList.Add(10);    // Adding an integer
// nonGenericList.Add("Hello"); // Adding a string
// nonGenericList.Add(3.14);    // Adding a double

// // Type Safety: No type safety. You can add items of different data types to the same list, 
// // which can lead to runtime errors if you try to retrieve an item and use it in a way that’s 
// // incompatible with its actual type.

// int firstItem = (int)nonGenericList[0]; // Requires explicit casting
// string secondItem = (string)nonGenericList[1];

// // A generic list, such as List<T>, is type-safe. It requires you to specify the data type of the items it 
// // will store when you declare the list.
// List<int> genericList = new List<int>();
// genericList.Add(10);    // Adding an integer
// //genericList.Add("Hello"); // This will cause a compile-time error
// genericList.Add(20);    // Adding another integer
// int firstItem = genericList[0]; // No casting required

//                      //
//  Subtopic Tutorial   //
//                      //
// 1. Arrays: Resizing an Array
// Question:
// Write a program that initializes an array with 5 integers. Then, ask the user to enter 5 more integers. 
// Create a new array that combines the original array and the new integers, effectively resizing the array. 
// Display the contents of the combined array.
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] originalArray = { 1, 2, 3, 4, 5 };
//         int[] newArray = new int[10];

//         // Copy original array to the new array
//         for (int i = 0; i < originalArray.Length; i++)
//         {
//             newArray[i] = originalArray[i];
//         }

//         // Adding new elements to the array
//         for (int i = originalArray.Length; i < newArray.Length; i++)
//         {
//             Console.Write("Enter a new number: ");
//             newArray[i] = int.Parse(Console.ReadLine());
//         }

//         // Display the combined array
//         Console.WriteLine("Combined array: ");
//         foreach (int number in newArray)
//         {
//             Console.Write(number + " ");
//         }
//     }
// }

// 2. Lists: Managing a To-Do List

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main(string[] args)
//     {
//         List<string> toDoList = new List<string>();
//         int option;

//         do
//         {
//             Console.WriteLine("");
//             Console.WriteLine("1. Add a task");
//             Console.WriteLine("2. Remove a task");
//             Console.WriteLine("3. View all tasks");
//             Console.WriteLine("4. Exit");
//             Console.Write("Choose an option: ");
//             option = int.Parse(Console.ReadLine());

//             switch (option)
//             {
//                 case 1:
//                     Console.Write("Enter the task: ");
//                     toDoList.Add(Console.ReadLine());
//                     break;
//                 case 2:
//                     Console.Write("Enter the task number to remove: ");
//                     int taskIndex = int.Parse(Console.ReadLine()) - 1;
//                     if (taskIndex >= 0 && taskIndex < toDoList.Count)
//                     {
//                         toDoList.RemoveAt(taskIndex);
//                     }
//                     else
//                     {
//                         Console.WriteLine("Invalid task number.");
//                     }
//                     break;
//                 case 3:
//                     Console.WriteLine("Tasks:");
//                     for (int i = 0; i < toDoList.Count; i++)
//                     {
//                         Console.WriteLine($"{i + 1}. {toDoList[i]}");
//                     }
//                     break;
//             }

//         } while (option != 4);
//     }
// }

//3. Dictionaries: Counting Word Frequencies

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine().ToLower();
        string[] words = sentence.Split(new char[] { ' ', '.', ',', '!', '?' });

        Dictionary<string, int> wordFrequencies = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordFrequencies.ContainsKey(word))
            {
                wordFrequencies[word]++;
            }
            else
            {
                wordFrequencies.Add(word, 1);
            }
        }

        Console.WriteLine("Word frequencies:");
        foreach (var pair in wordFrequencies)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}

// 4. Sets: Finding Common Elements

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter the first list of numbers (comma-separated): ");
//         string[] firstListInput = Console.ReadLine().Split(',');
//         HashSet<int> firstSet = new HashSet<int>();

//         foreach (string number in firstListInput)
//         {
//             firstSet.Add(int.Parse(number.Trim()));
//         }

//         Console.Write("Enter the second list of numbers (comma-separated): ");
//         string[] secondListInput = Console.ReadLine().Split(',');
//         HashSet<int> secondSet = new HashSet<int>();

//         foreach (string number in secondListInput)
//         {
//             secondSet.Add(int.Parse(number.Trim()));
//         }

//         firstSet.IntersectWith(secondSet);

//         Console.WriteLine("Common elements:");
//         foreach (int number in firstSet)
//         {
//             Console.Write(number + " ");
//         }
//     }
// }

//              //
//  Tutorials   //
//              //

// 1. Calculate Average Grade and Find Highest Using Lists and Loops

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main(string[] args)
//     {
//         List<string> names = new List<string>();
//         List<int> grades = new List<int>();
//         int totalGrades = 0;

//         for (int i = 0; i < 5; i++)
//         {
//             Console.Write($"Enter the name of student {i + 1}: ");
//             names.Add(Console.ReadLine());

//             Console.Write($"Enter the grade of student {i + 1}: ");
//             int grade = int.Parse(Console.ReadLine());
//             grades.Add(grade);
//             totalGrades += grade;
//         }

//         double averageGrade = totalGrades / 5.0;
//         Console.WriteLine($"\nThe average grade is: {averageGrade}");

//         int highestGrade = grades[0];
//         string highestName = names[0];

//         for (int i = 1; i < grades.Count; i++)
//         {
//             if (grades[i] > highestGrade)
//             {
//                 highestGrade = grades[i];
//                 highestName = names[i];
//             }
//         }

//         Console.WriteLine($"The highest grade is {highestGrade} by {highestName}.");
//     }
// }

// 2. Manage an Inventory Using Dictionaries

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Dictionary<string, int> inventory = new Dictionary<string, int>();
//         int option;

//         do
//         {
//             Console.WriteLine("1. Add an item");
//             Console.WriteLine("2. Remove an item");
//             Console.WriteLine("3. Update item quantity");
//             Console.WriteLine("4. View inventory");
//             Console.WriteLine("5. Exit");
//             Console.Write("Choose an option: ");
//             option = int.Parse(Console.ReadLine());

//             switch (option)
//             {
//                 case 1:
//                     Console.Write("Enter the item name: ");
//                     string itemName = Console.ReadLine();
//                     Console.Write("Enter the quantity: ");
//                     int quantity = int.Parse(Console.ReadLine());
//                     inventory[itemName] = quantity;
//                     break;
//                 case 2:
//                     Console.Write("Enter the item name to remove: ");
//                     itemName = Console.ReadLine();
//                     if (inventory.ContainsKey(itemName))
//                     {
//                         inventory.Remove(itemName);
//                     }
//                     else
//                     {
//                         Console.WriteLine("Item not found.");
//                     }
//                     break;
//                 case 3:
//                     Console.Write("Enter the item name to update: ");
//                     itemName = Console.ReadLine();
//                     if (inventory.ContainsKey(itemName))
//                     {
//                         Console.Write("Enter the new quantity: ");
//                         quantity = int.Parse(Console.ReadLine());
//                         inventory[itemName] = quantity;
//                     }
//                     else
//                     {
//                         Console.WriteLine("Item not found.");
//                     }
//                     break;
//                 case 4:
//                     Console.WriteLine("Inventory:");
//                     foreach (var pair in inventory)
//                     {
//                         Console.WriteLine($"{pair.Key}: {pair.Value}");
//                     }
//                     break;
//             }

//         } while (option != 5);
//     }
// }

// 3. Count Even and Odd Numbers Using Arrays and Loops

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] numbers = new int[10];
//         Random random = new Random();
//         int evenCount = 0, oddCount = 0;

//         for (int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = random.Next(1, 101); // Random numbers between 1 and 100
//             Console.Write(numbers[i] + " ");
//         }

//         Console.WriteLine();

//         foreach (int number in numbers)
//         {
//             if (number % 2 == 0)
//             {
//                 evenCount++;
//             }
//             else
//             {
//                 oddCount++;
//             }
//         }

//         Console.WriteLine($"Number of even numbers: {evenCount}");
//         Console.WriteLine($"Number of odd numbers: {oddCount}");
//     }
// }

//4. Unique Word List Using a HashSet and a Loop

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Step 1: Get input from the user
//         Console.Write("Enter words (comma-separated): ");
//         string input = Console.ReadLine();

//         // Step 2: Split the input string into an array of words
//         string[] wordsArray = input.Split(',');

//         // Step 3: Create a HashSet to store unique words
//         HashSet<string> uniqueWords = new HashSet<string>();

//         // Step 4: Add words to the HashSet (duplicates will be ignored)
//         foreach (string word in wordsArray)
//         {
//             uniqueWords.Add(word.Trim()); // Trim to remove any extra spaces
//         }

//         // Step 5: Convert the HashSet to a List and sort it alphabetically
//         List<string> sortedWords = uniqueWords.ToList();
//         sortedWords.Sort();

//         // Step 6: Display the unique, sorted words
//         Console.WriteLine("Unique words: " + string.Join(", ", sortedWords));
//     }
// }
