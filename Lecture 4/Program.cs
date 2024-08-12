
// Creating a Class and Object
// Example: Define a Car class and create an object.

// using System;

// namespace OOPConcepts
// {
//     class Car
//     {
//         public string model;
//         public int year;

//         public void StartEngine()
//         {
//             Console.WriteLine("The engine is started.");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Car myCar = new Car();
//             myCar.model = "Toyota";
//             myCar.year = 2020;
//             myCar.StartEngine();

//             Console.WriteLine("Car Model: " + myCar.model);
//             Console.WriteLine("Car Year: " + myCar.year);
//         }
//     }
// }

// using System;

// namespace OOPConcepts
// {
//     class Car
//     {
//         public string Model { get; set; }
//         public int Year { get; set; }
//         public string Color { get; set; }
//         public string FuelType { get; set; }

//         public void StartEngine()
//         {
//             Console.WriteLine("The engine is started.");
//         }

//         public void Accelerate()
//         {
//             Console.WriteLine("The car is accelerating.");
//         }

//         public void Brake()
//         {
//             Console.WriteLine("The car is braking.");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Car myCar = new Car { Model = "Toyota", Year = 2020, Color = "Red", FuelType = "Petrol" };
//             myCar.StartEngine();
//             myCar.Accelerate();
//             myCar.Brake();

//             Console.WriteLine($"Car Model: {myCar.Model}, Year: {myCar.Year}, Color: {myCar.Color}, Fuel Type: {myCar.FuelType}");
//         }
//     }
// }

// Example: Define a Book class and create an object.

using System;

namespace OOPConcepts
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        public void Read()
        {
            Console.WriteLine($"Reading '{Title}' by {Author}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book { Title = "1984", Author = "George Orwell", Pages = 328 };
            myBook.Read();

            Console.WriteLine($"Book Title: {myBook.Title}, Author: {myBook.Author}, Pages: {myBook.Pages}");
        }
    }
}


// Encapsulation with Properties
// Example: Encapsulate fields in the Car class using properties.
// using System;

// namespace OOPConcepts
// {
//     class Car
//     {
//         private string _model;
//         private int _year;

//         public string Model
//         {
//             get { return _model; }
//             set { _model = value; }
//         }

//         public int Year
//         {
//             get { return _year; }
//             set { _year = value; }
//         }

//         public void StartEngine()
//         {
//             Console.WriteLine("The engine is started.");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Car myCar = new Car();
//             myCar.Model = "Toyota";
//             myCar.Year = 2020;
//             myCar.StartEngine();

//             Console.WriteLine("Car Model: " + myCar.Model);
//             Console.WriteLine("Car Year: " + myCar.Year);
//         }
//     }
// }

// using System;

// namespace OOPConcepts
// {
//     class Car
//     {
//         private int _year;
//         public string Model { get; set; }
//         public string Color { get; set; }
//         public string FuelType { get; set; }

//         public int Year
//         {
//             get { return _year; }
//             set
//             {
//                 if (value > DateTime.Now.Year)
//                 {
//                     Console.WriteLine("Year cannot be in the future.");
//                 }
//                 else
//                 {
//                     _year = value;
//                 }
//             }
//         }

//         public void StartEngine()
//         {
//             Console.WriteLine("The engine is started.");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Car myCar = new Car { Model = "Toyota", Color = "Red", FuelType = "Petrol" };
//             myCar.Year = 2025; // Invalid year
//             myCar.Year = 2020; // Valid year

//             Console.WriteLine($"Car Model: {myCar.Model}, Year: {myCar.Year}, Color: {myCar.Color}, Fuel Type: {myCar.FuelType}");
//         }
//     }
// }

// Example: Encapsulate fields in the Student class using properties.
// using System;

// namespace OOPConcepts
// {
//     class Student
//     {
//         private int _age;
//         public string Name { get; set; }

//         public int Age
//         {
//             get { return _age; }
//             set
//             {
//                 if (value < 0 || value > 120)
//                 {
//                     Console.WriteLine("Invalid age.");
//                 }
//                 else
//                 {
//                     _age = value;
//                 }
//             }
//         }

//         public void Introduce()
//         {
//             Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Student student = new Student { Name = "John" };
//             student.Age = 25;  // Valid age
//             student.Introduce();

//             student.Age = 150; // Invalid age
//         }
//     }
// }



// Inheritance
// Example: Create a Vehicle base class and derive a Car class from it.

// using System;

// namespace OOPConcepts
// {
//     class Vehicle
//     {
//         public string brand = "Ford";

//         public void Honk()
//         {
//             Console.WriteLine("Honk! Honk!");
//         }
//     }

//     class Car : Vehicle
//     {
//         public string modelName = "Mustang";
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Car myCar = new Car();
//             myCar.Honk();
//             Console.WriteLine(myCar.brand + " " + myCar.modelName);
//         }
//     }
// }

// using System;

// namespace OOPConcepts
// {
//     class Vehicle
//     {
//         public string Brand { get; set; }

//         public void Start()
//         {
//             Console.WriteLine($"{Brand} vehicle started.");
//         }

//         public void Stop()
//         {
//             Console.WriteLine($"{Brand} vehicle stopped.");
//         }
//     }

//     class Car : Vehicle
//     {
//         public string Model { get; set; }

//         public void Honk()
//         {
//             Console.WriteLine($"{Model} is honking: Beep! Beep!");
//         }
//     }

//     class Motorcycle : Vehicle
//     {
//         public void Wheelie()
//         {
//             Console.WriteLine($"{Brand} motorcycle is doing a wheelie!");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Car myCar = new Car { Brand = "Ford", Model = "Mustang" };
//             myCar.Start();
//             myCar.Honk();
//             myCar.Stop();

//             Motorcycle myBike = new Motorcycle { Brand = "Harley-Davidson" };
//             myBike.Start();
//             myBike.Wheelie();
//             myBike.Stop();
//         }
//     }
// }

// Example: Create a Shape base class and derive Rectangle and Circle classes from it.
// using System;

// namespace OOPConcepts
// {
//     class Shape
//     {
//         public string Color { get; set; }

//         public void Describe()
//         {
//             Console.WriteLine($"This is a {Color} shape.");
//         }
//     }

//     class Rectangle : Shape
//     {
//         public double Width { get; set; }
//         public double Height { get; set; }

//         public double GetArea()
//         {
//             return Width * Height;
//         }
//     }

//     class Circle : Shape
//     {
//         public double Radius { get; set; }

//         public double GetArea()
//         {
//             return Math.PI * Radius * Radius;
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Rectangle myRectangle = new Rectangle { Color = "Red", Width = 5, Height = 10 };
//             myRectangle.Describe();
//             Console.WriteLine($"Rectangle Area: {myRectangle.GetArea()}");

//             Circle myCircle = new Circle { Color = "Blue", Radius = 7 };
//             myCircle.Describe();
//             Console.WriteLine($"Circle Area: {myCircle.GetArea()}");
//         }
//     }
// }


// Compile-time Polymorphism (Method Overloading)

// using System;

// namespace PolymorphismExample
// {
//     class Calculator
//     {
//         // Method to add two integers
//         public int Add(int a, int b)
//         {
//             return a + b;
//         }

//         // Overloaded method to add three integers
//         public int Add(int a, int b, int c)
//         {
//             return a + c + b;
//         }

//         // Overloaded method to add two doubles
//         public double Add(double a, double b)
//         {
//             return a + b;
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Calculator calc = new Calculator();

//             // Call the Add method with two integers
//             Console.WriteLine("Add two integers: " + calc.Add(10, 20)); // Output: 30

//             // Call the Add method with three integers
//             Console.WriteLine("Add three integers: " + calc.Add(10, 20, 30)); // Output: 60

//             // Call the Add method with two doubles
//             Console.WriteLine("Add two doubles: " + calc.Add(10.5, 20.7)); // Output: 31.2
//         }
//     }
// }

// using System;

// namespace PolymorphismExample
// {
//     class Calculator
//     {
//         public int Add(int a, int b) => a + b;
//         public int Add(int a, int b, int c) => a + b + c;
//         public double Add(double a, double b) => a + b;

//         public int Subtract(int a, int b) => a - b;
//         public double Subtract(double a, double b) => a - b;
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Calculator calc = new Calculator();

//             Console.WriteLine("Add two integers: " + calc.Add(10, 20));
//             Console.WriteLine("Add three integers: " + calc.Add(10, 20, 30));
//             Console.WriteLine("Add two doubles: " + calc.Add(10.5, 20.7));
//             Console.WriteLine("Subtract two integers: " + calc.Subtract(20, 10));
//             Console.WriteLine("Subtract two doubles: " + calc.Subtract(20.7, 10.5));
//         }
//     }
// }

// Example: Define a Printer class with overloaded Print methods.
// using System;

// namespace PolymorphismExample
// {
//     class Printer
//     {
//         public void Print(string text)
//         {
//             Console.WriteLine($"Printing text: {text}");
//         }

//         public void Print(int number)
//         {
//             Console.WriteLine($"Printing number: {number}");
//         }

//         public void Print(string text, int copies)
//         {
//             for (int i = 0; i < copies; i++)
//             {
//                 Console.WriteLine($"Copy {i + 1}: {text}");
//             }
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Printer myPrinter = new Printer();

//             myPrinter.Print("Hello, World!");
//             myPrinter.Print(12345);
//             myPrinter.Print("Confidential Document", 3);
//         }
//     }
// }


// Run-time Polymorphism (Method Overriding)
// Example: Override a method in the derived class.

// using System;

// namespace PolymorphismExample
// {
//     // Base class
//     class Animal
//     {
//         // Virtual method to be overridden
//         public virtual void Speak()
//         {
//             Console.WriteLine("The animal makes a sound.");
//         }
//     }

//     // Derived class (Dog)
//     class Dog : Animal
//     {
//         // Override the Speak method
//         public override void Speak()
//         {
//             Console.WriteLine("The dog barks.");
//         }
//     }

//     // Derived class (Cat)
//     class Cat : Animal
//     {
//         // Override the Speak method
//         public override void Speak()
//         {
//             Console.WriteLine("The cat meows.");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Create instances of the derived classes
//             Animal myDog = new Dog();
//             Animal myCat = new Cat();

//             // Call the Speak method on the derived class instances
//             myDog.Speak(); // Output: The dog barks.
//             myCat.Speak(); // Output: The cat meows.
//         }
//     }
// }

// using System;

// namespace PolymorphismExample
// {
//     class Animal
//     {
//         public virtual void MakeSound()
//         {
//             Console.WriteLine("Some generic animal sound");
//         }
//     }

//     class Dog : Animal
//     {
//         public override void MakeSound()
//         {
//             Console.WriteLine("Bark! Bark!");
//         }
//     }

//     class Cat : Animal
//     {
//         public override void MakeSound()
//         {
//             Console.WriteLine("Meow! Meow!");
//         }
//     }

//     class Bird : Animal
//     {
//         public override void MakeSound()
//         {
//             Console.WriteLine("Chirp! Chirp!");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Animal[] animals = { new Dog(), new Cat(), new Bird() };

//             foreach (Animal animal in animals)
//             {
//                 animal.MakeSound();
//             }
//         }
//     }
// }

// Example: Create an Employee base class and override the Work method in Manager and Developer classes.
// using System;

// namespace PolymorphismExample
// {
//     class Employee
//     {
//         public string Name { get; set; }

//         public virtual void Work()
//         {
//             Console.WriteLine($"{Name} is working.");
//         }
//     }

//     class Manager : Employee
//     {
//         public override void Work()
//         {
//             Console.WriteLine($"{Name} is managing the team.");
//         }
//     }

//     class Developer : Employee
//     {
//         public override void Work()
//         {
//             Console.WriteLine($"{Name} is writing code.");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Employee emp1 = new Manager { Name = "Alice" };
//             Employee emp2 = new Developer { Name = "Bob" };

//             emp1.Work();  // Output: Alice is managing the team.
//             emp2.Work();  // Output: Bob is writing code.
//         }
//     }
// }


// Abstraction
// Example: Create an abstract class Shape and a derived class Circle.

// using System;

// namespace OOPConcepts
// {
//     abstract class Shape
//     {
//         public abstract void Draw();
//     }

//     class Circle : Shape
//     {
//         public override void Draw()
//         {
//             Console.WriteLine("Drawing a circle");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Shape myShape = new Circle();
//             myShape.Draw();
//         }
//     }
// }

// Example: Abstraction with Shape and Draw Method
// using System;

// namespace OOPConcepts
// {
//     // Abstract class Shape with an abstract method Draw
//     abstract class Shape
//     {
//         public string Color { get; set; }

//         // Abstract method - must be implemented by derived classes
//         public abstract void Draw();
//     }

//     // Derived class Circle
//     class Circle : Shape
//     {
//         public double Radius { get; set; }

//         public override void Draw()
//         {
//             Console.WriteLine($"Drawing a {Color} circle with radius {Radius}.");
//         }
//     }

//     // Derived class Rectangle
//     class Rectangle : Shape
//     {
//         public double Width { get; set; }
//         public double Height { get; set; }

//         public override void Draw()
//         {
//             Console.WriteLine($"Drawing a {Color} rectangle with width {Width} and height {Height}.");
//         }
//     }

//     // Derived class Triangle
//     class Triangle : Shape
//     {
//         public double BaseLength { get; set; }
//         public double Height { get; set; }

//         public override void Draw()
//         {
//             Console.WriteLine($"Drawing a {Color} triangle with base {BaseLength} and height {Height}.");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Creating objects of derived classes
//             Shape myCircle = new Circle { Color = "Red", Radius = 5 };
//             Shape myRectangle = new Rectangle { Color = "Blue", Width = 10, Height = 5 };
//             Shape myTriangle = new Triangle { Color = "Green", BaseLength = 8, Height = 6 };

//             // Calling the Draw method on each object
//             myCircle.Draw();     // Output: Drawing a Red circle with radius 5.
//             myRectangle.Draw();  // Output: Drawing a Blue rectangle with width 10 and height 5.
//             myTriangle.Draw();   // Output: Drawing a Green triangle with base 8 and height 6.
//         }
//     }
// }


// Example: Create an abstract class Appliance and derive WashingMachine and Microwave classes from it.
// using System;

// namespace OOPConcepts
// {
//     abstract class Appliance
//     {
//         public string Brand { get; set; }

//         public abstract void Operate();
//     }

//     class WashingMachine : Appliance
//     {
//         public override void Operate()
//         {
//             Console.WriteLine($"The {Brand} washing machine is washing clothes.");
//         }
//     }

//     class Microwave : Appliance
//     {
//         public override void Operate()
//         {
//             Console.WriteLine($"The {Brand} microwave is heating food.");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Appliance myWasher = new WashingMachine { Brand = "LG" };
//             Appliance myMicrowave = new Microwave { Brand = "Samsung" };

//             myWasher.Operate();  // Output: The LG washing machine is washing clothes.
//             myMicrowave.Operate();  // Output: The Samsung microwave is heating food.
//         }
//     }
// }



