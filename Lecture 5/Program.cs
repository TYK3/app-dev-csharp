// Example Code: Filtering with where

// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace LINQBasics
// {
//     class Person
//     {
//         public string Name { get; set; }
//         public int Age { get; set; }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             List<Person> people = new List<Person>
//             {
//                 new Person { Name = "Alice", Age = 25 },
//                 new Person { Name = "Bob", Age = 17 },
//                 new Person { Name = "Charlie", Age = 30 }
//             };

//             var adults = from person in people
//                          where person.Age >= 18
//                          select person;


//             // var adults = people.Where(p => p.Age >= 18);

//             Console.WriteLine("Adults:");
//             foreach (var person in adults)
//             {
//                 Console.WriteLine($"{person.Name}, Age: {person.Age}");
//             }
//         }
//     }
// }

// Example Code: Sorting with order by

// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace LINQBasics
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             List<Person> people = new List<Person>
//             {
//                 new Person { Name = "Alice", Age = 25 },
//                 new Person { Name = "Bob", Age = 17 },
//                 new Person { Name = "Charlie", Age = 30 }
//             };

//             var sortedPeople = from person in people
//                                orderby person.Age
//                                select person;


//             // var sortedPeople = people.OrderBy(p => p.Age);

//             Console.WriteLine("People sorted by age:");
//             foreach (var person in sortedPeople)
//             {
//                 Console.WriteLine($"{person.Name}, Age: {person.Age}");
//             }
//         }
//     }
// }

// Example Code: Projection with select

// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace LINQBasics
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             List<Person> people = new List<Person>
//             {
//                 new Person { Name = "Alice", Age = 25 },
//                 new Person { Name = "Bob", Age = 17 },
//                 new Person { Name = "Charlie", Age = 30 }
//             };

//             var names = from person in people
//             select person.Name;

//             // var names = people.Select(p => p.Name);

//             Console.WriteLine("Names:");
//             foreach (var name in names)
//             {
//                 Console.WriteLine(name);
//             }
//         }
//     }
// }

// Example Code: Aggregation Methods

// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace LINQBasics
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             List<Person> people = new List<Person>
//             {
//                 new Person { Name = "Alice", Age = 25 },
//                 new Person { Name = "Bob", Age = 17 },
//                 new Person { Name = "Charlie", Age = 30 }
//             };

//             var totalAge = people.Sum(p => p.Age);
//             var averageAge = people.Average(p => p.Age);
//             var adultCount = people.Count(p => p.Age >= 18);

//             Console.WriteLine($"Total Age: {totalAge}");
//             Console.WriteLine($"Average Age: {averageAge}");
//             Console.WriteLine($"Number of Adults: {adultCount}");
//         }
//     }
// }

// Example Code: Joining Data with Join

// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace LINQAdvanced
// {
//     class Student
//     {
//         public string Name { get; set; }
//         public int CourseId { get; set; }
//     }

//     class Course
//     {
//         public int CourseId { get; set; }
//         public string CourseName { get; set; }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             List<Student> students = new List<Student>
//             {
//                 new Student { Name = "Alice", CourseId = 1 },
//                 new Student { Name = "Bob", CourseId = 2 },
//                 new Student { Name = "Charlie", CourseId = 1 }
//             };

//             List<Course> courses = new List<Course>
//             {
//                 new Course { CourseId = 1, CourseName = "Mathematics" },
//                 new Course { CourseId = 2, CourseName = "Physics" }
//             };

//             var query = from student in students
//                         join course in courses on student.CourseId equals course.CourseId
//                         select new { student.Name, course.CourseName };

//             // var query = students.Join(courses,
//             //                           student => student.CourseId,
//             //                           course => course.CourseId,
//             //                           (student, course) => new { student.Name, course.CourseName });

//             Console.WriteLine("Student-Course pairs:");
//             foreach (var result in query)
//             {
//                 Console.WriteLine($"{result.Name} is enrolled in {result.CourseName}");
//             }
//         }
//     }
// }

// Example Code: Grouping Data with GroupBy

// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace LINQAdvanced
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             List<Person> people = new List<Person>
//             {
//                 new Person { Name = "Alice", Age = 25 },
//                 new Person { Name = "Bob", Age = 25 },
//                 new Person { Name = "Charlie", Age = 30 }
//             };

//             var groups = from person in people
//                          group person by person.Age into ageGroup
//                          select ageGroup;


//             // var groups = people.GroupBy(p => p.Age);

//             foreach (var group in groups)
//             {
//                 Console.WriteLine($"Age Group: {group.Key}");
//                 foreach (var person in group)
//                 {
//                     Console.WriteLine($" - {person.Name}");
//                 }
//             }
//         }
//     }
// }

// Code Example: Comparing Query Syntax and Method Syntax with a for Loop

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace LINQPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of integers
            List<int> numbers = Enumerable.Range(1, 1000000).ToList();

            // Query Syntax
            var querySyntax = from num in numbers
                              where num % 2 == 0
                              select num;

            // Method Syntax
            var methodSyntax = numbers.Where(num => num % 2 == 0);

            // Measure runtime for Query Syntax
            var stopwatch = Stopwatch.StartNew();
            long sumQuerySyntax = 0;
            for (int i = 0; i < 100; i++)
            {
                sumQuerySyntax = querySyntax.Sum(num => (long)num); // Use long for summation
            }
            stopwatch.Stop();
            Console.WriteLine($"Query Syntax Sum: {sumQuerySyntax}");
            Console.WriteLine($"Query Syntax Runtime: {stopwatch.ElapsedMilliseconds} ms");

            // Measure runtime for Method Syntax
            stopwatch.Restart();
            long sumMethodSyntax = 0;
            for (int i = 0; i < 100; i++)
            {
                sumMethodSyntax = methodSyntax.Sum(num => (long)num); // Use long for summation
            }
            stopwatch.Stop();
            Console.WriteLine($"Method Syntax Sum: {sumMethodSyntax}");
            Console.WriteLine($"Method Syntax Runtime: {stopwatch.ElapsedMilliseconds} ms");

            // Explicit Execution - To Show Impact of Deferred Execution
            // Pre-execute the LINQ results and store them
            var preExecutedQuery = querySyntax.ToList();
            var preExecutedMethod = methodSyntax.ToList();

            // Measure runtime for pre-executed Query Syntax
            stopwatch.Restart();
            for (int i = 0; i < 100; i++)
            {
                sumQuerySyntax = preExecutedQuery.Sum(num => (long)num); // No deferred execution
            }
            stopwatch.Stop();
            Console.WriteLine($"Pre-executed Query Syntax Runtime: {stopwatch.ElapsedMilliseconds} ms");

            // Measure runtime for pre-executed Method Syntax
            stopwatch.Restart();
            for (int i = 0; i < 100; i++)
            {
                sumMethodSyntax = preExecutedMethod.Sum(num => (long)num); // No deferred execution
            }
            stopwatch.Stop();
            Console.WriteLine($"Pre-executed Method Syntax Runtime: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}


