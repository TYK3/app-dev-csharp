using System;

class Program
{
    static Student[] students = new Student[50];
    static int studentCount = 0;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to the Student Management System");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1. Add a New Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Search for a Student by ID");
            Console.WriteLine("4. Remove a Student by ID");
            Console.WriteLine("5. Update a Student's Grade");
            Console.WriteLine("6. Sort Students by Grade");
            Console.WriteLine("7. Display Average Grade");
            Console.WriteLine("8. Count Passing Students");
            Console.WriteLine("9. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    ViewAllStudents();
                    break;
                case "3":
                    SearchStudentByID();
                    break;
                case "4":
                    RemoveStudentByID();
                    break;
                case "5":
                    UpdateStudentGrade();
                    break;
                case "6":
                    SortStudentsByGrade();
                    break;
                case "7":
                    DisplayAverageGrade();
                    break;
                case "8":
                    CountPassingStudents();
                    break;
                case "9":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddStudent()
    {
        if (studentCount >= students.Length)
        {
            Console.WriteLine("Student array is full. Cannot add more students.");
            return;
        }

        Console.Write("Enter Student ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Student Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter Student Grade: ");
        double grade = double.Parse(Console.ReadLine());

        students[studentCount] = new Student(id, name, age, grade);
        studentCount++;

        Console.WriteLine("Student added successfully!");
    }

    static void ViewAllStudents()
    {
        if (studentCount == 0)
        {
            Console.WriteLine("No students to display.");
            return;
        }

        for (int i = 0; i < studentCount; i++)
        {
            students[i].DisplayDetails();
        }
    }

    static void SearchStudentByID()
    {
        Console.Write("Enter Student ID: ");
        int id = int.Parse(Console.ReadLine());

        for (int i = 0; i < studentCount; i++)
        {
            if (students[i].ID == id)
            {
                students[i].DisplayDetails();
                return;
            }
        }

        Console.WriteLine("Student not found.");
    }

    static void RemoveStudentByID()
    {
        Console.Write("Enter Student ID: ");
        int id = int.Parse(Console.ReadLine());

        for (int i = 0; i < studentCount; i++)
        {
            if (students[i].ID == id)
            {
                // Shift elements left to remove the student
                for (int j = i; j < studentCount - 1; j++)
                {
                    students[j] = students[j + 1];
                }

                students[--studentCount] = null;
                Console.WriteLine("Student removed successfully.");
                return;
            }
        }

        Console.WriteLine("Student not found.");
    }

    static void UpdateStudentGrade()
    {
        Console.Write("Enter Student ID: ");
        int id = int.Parse(Console.ReadLine());

        for (int i = 0; i < studentCount; i++)
        {
            if (students[i].ID == id)
            {
                Console.Write("Enter new grade: ");
                double newGrade = double.Parse(Console.ReadLine());
                students[i].Grade = newGrade;
                Console.WriteLine("Student grade updated successfully.");
                return;
            }
        }

        Console.WriteLine("Student not found.");
    }

    static void SortStudentsByGrade()
    {
        Array.Sort(students, 0, studentCount, Comparer<Student>.Create((s1, s2) => s2.Grade.CompareTo(s1.Grade)));

        Console.WriteLine("Students sorted by grade:");
        ViewAllStudents();
    }

    static void DisplayAverageGrade()
    {
        if (studentCount == 0)
        {
            Console.WriteLine("No students to calculate average grade.");
            return;
        }

        double total = 0;
        for (int i = 0; i < studentCount; i++)
        {
            total += students[i].Grade;
        }

        double average = total / studentCount;
        Console.WriteLine($"Average Grade: {average:F2}");
    }

    static void CountPassingStudents()
    {
        int count = 0;
        for (int i = 0; i < studentCount; i++)
        {
            if (students[i].IsPassing())
            {
                count++;
            }
        }

        Console.WriteLine($"Number of students passing: {count}");
    }
}
