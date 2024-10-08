﻿// What is Object-Oriented Programming (OOP)?
// Object-Oriented Programming (OOP) is a programming paradigm that uses "objects" to represent data and methods. 
// An object is an instance of a class, and a class is a blueprint for creating objects. OOP focuses on breaking down 
// problems into smaller, manageable pieces by modeling real-world entities as objects.

// Creating a Class and Object
// Class: A blueprint or template for creating objects.
// Object: An instance of a class.
// Method: A function defined inside a class that describes the behaviors of an object.
// Property: A variable defined inside a class that describes the attributes of an object.


// Example: Define a Car class and create an object.

// using System; //imports the System namespace, 
// // which provides fundamental classes like Console for input and output.

// namespace OOPConcepts // groups related classes under a common name. 
//                       //Namespaces help organize code and avoid naming conflicts.
// {
//     class Car // class Car defines a new class named Car. A class is a blueprint for creating objects. 
//               // It encapsulates data (properties) and behavior (methods).

//     {
//         //properties of the Car class.
//         public string model; // stores the model name of the car.
//         public int year; // stores the year of manufacture.

//         public void StartEngine() 
//         // method that describes a behavior of the Car class.
//         {
//             Console.WriteLine("The engine is started.");
//         }

//         //public is an access modifier that allows the property or method to be accessible from outside the Car class. 
//         //By default, class members are private, meaning they are only accessible within the class itself.
//     }

//     class Program //contains the Main method, which is the entry point of a C# application
//     {
//         static void Main(string[] args) 
//         // The static keyword means this method belongs to the class itself rather than an instance of the class.
//         {
//             Car myCar = new Car();
//             //creates an instance of the Car class. This object, myCar, has its own set of properties (model and year) 
//             //and can call the method StartEngine.
//             myCar.model = "Toyota"; //sets the model property of the myCar object to "Toyota".
//             myCar.year = 2020; // sets the year property of the myCar object to 2020.
//             myCar.StartEngine(); //calls the StartEngine method on the myCar object, which prints a message to the console.

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
//             Car myCar = new Car 
//             { 
//                 Model = "Toyota", 
//                 Year = 2020, 
//                 Color = "Red", 
//                 FuelType = "Petrol" 
//             };
//             myCar.StartEngine();
//             myCar.Accelerate();
//             myCar.Brake();

//             Console.WriteLine($"Car Model: {myCar.Model}, Year: {myCar.Year}, Color: {myCar.Color}, Fuel Type: {myCar.FuelType}");
//         }
//     }
// }

// Encapsulation with Properties
// -Encapsulation in programming means hiding the internal details of how an object works and only exposing 
//  what is necessary.
// -Bundling: Combine data (properties) and actions (methods) into one unit (class).
// -Data Protection: Hide the internal state of the object to prevent unintended changes.
// -Controlled Access: Use public methods and properties to control how data is accessed and modified.

// Example: Encapsulate fields in the Car class using properties.
// using System;

// namespace OOPConcepts
// {
//     class Car
//     {
//         //Private fields are used to store data within an object but prevent direct modification from outside the class.
//         private string _model; // Private field that can only be accessed directly within the Car class.
//         private int _year; // Private field that can only be accessed directly within the Car class.
                       
//         // Public property for accessing and modifying the model
//         public string Model
//         {
//             get { return _model; } // Returns the value of the private _model field
//             set { _model = value; } // Sets the value of the private _model field
//         }

//         // Public property for accessing and modifying the year
//         public int Year
//         {
//             get { return _year; } // Returns the value of the private _year field
//             set { _year = value; } // Sets the value of the private _year field
//         }

//         // Method to start the engine
//         public void StartEngine()
//         {
//             Console.WriteLine("The engine is started.");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Create an instance of the Car class
//             Car myCar = new Car
//             {
//                 // Set the properties of the Car object
//                 Model = "Toyota",
//                 Year = 2020
//             };

//             // Call the StartEngine method
//             myCar.StartEngine();

//             // Display the properties of the Car object
//             Console.WriteLine("Car Model: " + myCar.Model);
//             Console.WriteLine("Car Year: " + myCar.Year);

//             // Attempting direct field modification (this will cause a compilation error)
//             // myCar._model = "Honda"; // Error: '_model' is inaccessible due to its protection level
//             // myCar._year = 2025; // Error: '_year' is inaccessible due to its protection level

//             // Directly modify the values using properties
//             myCar.Model = "Honda";
//             myCar.Year = 2025;

//             // Print updated values
//             Console.WriteLine("Updated Car Model: " + myCar.Model);
//             Console.WriteLine("Updated Car Year: " + myCar.Year);
//         }
//     }
// }

// Example: Encapsulate fields in the Car class using properties.
// using System;

// namespace OOPConcepts
// {
//     // Car class represents a simple model of a car
//     class Car
//     {
//         // Private field to store the car's year
//         private int _year;

//         // Public property to get or set the car's model
//         public string Model { get; set; }

//         // Public property to get or set the car's color
//         public string Color { get; set; }

//         // Public property to get or set the car's fuel type
//         public string FuelType { get; set; }

//         // Public property to get or set the car's year with validation
//         public int Year
//         {
//             get
//             {
//                 // Return the value of the private field _year
//                 return _year;
//             }
//             set
//             {
//                 // Check if the year is in the future
//                 if (value > DateTime.Now.Year)
//                 {
//                     // Print a warning message if the year is invalid
//                     Console.WriteLine("Year cannot be in the future.");
//                 }
//                 else
//                 {
//                     // Set the private field _year if the year is valid
//                     _year = value;
//                 }
//             }
//         }

//         // Method to start the car's engine
//         public void StartEngine()
//         {
//             Console.WriteLine("The engine is started.");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Create a new Car object and set its properties
//             Car myCar = new Car
//             {
//                 Model = "Toyota", // Set the car's model
//                 Color = "Red", // Set the car's color
//                 FuelType = "Petrol", // Set the car's fuel type
//                 Year = 2025 // Attempt to set the car's year to 2025 (invalid)
//             };

//             // Attempt to set a valid year for the car
//             // myCar.Year = 2020; // Valid year

//             // Attempt to direct manipulation
//             // myCar._year = 2025; // Error: '_year' is inaccessible due to its protection level

//             // Print the car's details to the console
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

//             // student._age = 25;  // Valid age

//             //student.Age = 150; // Invalid age
//         }
//     }
// }



// Inheritance
// -Inheritance allows a class (child/derived class) to inherit properties and methods from 
// another class (parent/base class).
// -Enables code reuse by allowing the child class to use existing functionality from the parent class.
// -Establishes a hierarchical relationship between classes, where the child class can have additional properties 
//  and methods.
// -Simplifies code maintenance by reducing duplication and making it easier to extend functionality.

// Example: Create a Vehicle base class and derive a Car class from it.

// using System;

// namespace OOPConcepts
// {
//     // Base class or Parent class
//     class Vehicle
//     {
//         // Public field in the Vehicle class
//         public string brand = "Ford";

//         // Public method in the Vehicle class
//         public void Honk()
//         {
//             // This method prints a honking sound
//             Console.WriteLine("Honk! Honk!");
//         }
//     }

//     // Derived class or Child class that inherits from Vehicle
//     class Car : Vehicle
//     {
//         // Public field in the Car class
//         public string modelName = "Mustang";
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Create an instance of the Car class
//             Car myCar = new Car();

//             // Call the inherited Honk method from the Vehicle class
//             myCar.Honk();

//             // Access the inherited brand field from the Vehicle class 
//             // and the modelName field from the Car class
//             Console.WriteLine(myCar.brand + " " + myCar.modelName);
//             // Output will be: "Ford Mustang"
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

//             Motorcycle myBike = new Motorcycle { Brand = "Harley-Davidson"};
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

//Polymorphism allows objects of different classes to be 
//treated as objects of a common base class.

// Compile-time Polymorphism (Method Overloading): 
//Same method name, different parameters.

//using System;

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


// Run-time Polymorphism (Method Overriding): 
// A base class method is overridden in a derived class to provide a specific implementation.
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
//             Employee emp3 = new Employee { Name = "Lee" };
//             Employee emp1 = new Manager { Name = "Alice" };
//             Employee emp2 = new Developer { Name = "Bob" };

//             emp1.Work();  // Output: Alice is managing the team.
//             emp2.Work();  // Output: Bob is writing code.
//             emp3.Work();
//         }
//     }
// }


// Abstraction is to hide complex implementation details and showing only the essential features of an object.
// - Simplifies interaction by focusing on what an object does rather than how it does it.
// - Use abstract classes or interfaces to define the structure and behavior without providing full implementation.

// Example: Create an abstract class Shape and a derived class Circle.

// using System;

// namespace OOPConcepts
// {
//     // Abstract class Shape is an example of abstraction.
//     // It defines a method Draw() that derived classes must implement, but it does not provide a method body.
//     abstract class Shape
//     {
//         // Abstract method Draw() must be implemented by any derived class.
//         public abstract void Draw();
//     }

//     // Circle class inherits from Shape and provides a specific implementation for the Draw() method.
//     // This shows how abstraction allows defining a general method in the abstract class, 
//     // while leaving the details to be defined by derived classes.
//     class Circle : Shape
//     {
//         // Provides the implementation of the Draw() method specific to a Circle.
//         public override void Draw()
//         {
//             Console.WriteLine("Drawing a circle");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Create an instance of Circle, but treat it as a Shape.
//             // This demonstrates abstraction by allowing the use of Shape's interface without knowing Circle's details.
//             Shape myShape = new Circle();

//             // Attempt to create an instance of the abstract class Shape directly.
//             // This will cause a compilation error because Shape cannot be instantiated.
//             // Shape myShape = new Shape(); // Error: Cannot create an instance of the abstract class or interface 'Shape'
            
//             // Calls the Draw() method on the Shape reference, which will execute the Circle's implementation.
//             // This shows how abstraction and polymorphism work together. 
//             // Polymorphism allows the method call to be resolved to Circle's Draw() at runtime, even though the reference type is Shape.
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
    



//                      //
//  Subtopic Questions  //
//                      //

//Question 1:
// Create a base class `LibraryItem` with private fields for `Title` and `YearPublished`.
// Add public properties to access these fields.
// Derive a class `Book` from `LibraryItem` that includes an additional property `Author`.
// Write a program to create a `Book` object, set all its properties, and display its details.

// using System;

// namespace OOPConcepts
// {
//     class LibraryItem
//     {
//         private string _title;
//         private int _yearPublished;

//         public string Title
//         {
//             get { return _title; }
//             set { _title = value; }
//         }

//         public int YearPublished
//         {
//             get { return _yearPublished; }
//             set { _yearPublished = value; }
//         }
//     }

//     class Book : LibraryItem
//     {
//         public string Author { get; set; }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Book myBook = new Book
//             {
//                 Title = "The Great Gatsby",
//                 YearPublished = 1925,
//                 Author = "F. Scott Fitzgerald"
//             };

//             Console.WriteLine($"Title: {myBook.Title}");
//             Console.WriteLine($"Year Published: {myBook.YearPublished}");
//             Console.WriteLine($"Author: {myBook.Author}");
//         }
//     }
// }

//Question 2:
// Define a base class `Account` with private fields for `AccountHolder` and `Balance`.
// Implement methods to deposit and withdraw funds with validation.
// Create a derived class `BusinessAccount` that adds a `BusinessName` property and a method to apply a business fee.
// Demonstrate how to create and use these classes.

// using System;

// namespace OOPConcepts
// {
//     class Account
//     {
//         private string _accountHolder;
//         private double _balance;

//         public string AccountHolder
//         {
//             get { return _accountHolder; }
//             set { _accountHolder = value; }
//         }

//         public double Balance
//         {
//             get { return _balance; }
//             private set { _balance = value; }
//         }

//         public void Deposit(double amount)
//         {
//             if (amount > 0)
//             {
//                 Balance += amount;
//             }
//         }

//         public void Withdraw(double amount)
//         {
//             if (amount > 0 && amount <= Balance)
//             {
//                 Balance -= amount;
//             }
//         }
//     }

//     class BusinessAccount : Account
//     {
//         public string BusinessName { get; set; }

//         public void ApplyBusinessFee(double fee)
//         {
//             Withdraw(fee);
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             BusinessAccount myAccount = new BusinessAccount
//             {
//                 AccountHolder = "Alice Smith",
//                 BusinessName = "Tech Innovations"
//             };
//             myAccount.Deposit(5000);
//             myAccount.ApplyBusinessFee(50);

//             Console.WriteLine($"Account Holder: {myAccount.AccountHolder}");
//             Console.WriteLine($"Balance: {myAccount.Balance}");
//             Console.WriteLine($"Business Name: {myAccount.BusinessName}");
//             Console.WriteLine($"Balance after applying fee: {myAccount.Balance}");
//         }
//     }
// }

//Question 1:
// Create an abstract class `RemoteControl` with an abstract method `PressButton`.
// Derive two classes, `TelevisionRemote` and `AirConditionerRemote`, that implement the `PressButton` method.
// Write a program to create instances of both remotes and demonstrate polymorphism by calling the `PressButton` method.

using System;

namespace PolymorphismExample
{
    abstract class RemoteControl
    {
        public abstract void PressButton();
    }

    class TelevisionRemote : RemoteControl
    {
        public override void PressButton()
        {
            Console.WriteLine("TV Remote Button Pressed: Turning on TV");
        }
    }

    class AirConditionerRemote : RemoteControl
    {
        public override void PressButton()
        {
            Console.WriteLine("AC Remote Button Pressed: Setting temperature to 22°C");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl tvRemote = new TelevisionRemote();
            RemoteControl acRemote = new AirConditionerRemote();

            tvRemote.PressButton();
            acRemote.PressButton();
        }
    }
}

//Question 2:
// Define an abstract class `PaymentMethod` with an abstract method `ProcessPayment`.
// Implement derived classes `CreditCard` and `PayPal` that provide specific implementations of `ProcessPayment`.
// Demonstrate polymorphism by creating a list of `PaymentMethod` references and processing payments using different methods.

// using System;
// using System.Collections.Generic;

// namespace PolymorphismExample
// {
//     abstract class PaymentMethod
//     {
//         public abstract void ProcessPayment(double amount);
//     }

//     class CreditCard : PaymentMethod
//     {
//         public override void ProcessPayment(double amount)
//         {
//             Console.WriteLine($"Processing Credit Card Payment: ${amount}");
//         }
//     }

//     class PayPal : PaymentMethod
//     {
//         public override void ProcessPayment(double amount)
//         {
//             Console.WriteLine($"Processing PayPal Payment: ${amount}");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             List<PaymentMethod> payments = new List<PaymentMethod>
//             {
//                 new CreditCard(),
//                 new PayPal()
//             };

//             foreach (var payment in payments)
//             {
//                 payment.ProcessPayment(100);
//             }
//         }
//     }
// }

//            //
// Questions //
//            //

//Question 1:
// Create an abstract class `Employee` with encapsulated properties for `Name` and `Salary`, and an abstract method `CalculateAnnualBonus`.
// Derive classes `FullTimeEmployee` and `PartTimeEmployee` that implement `CalculateAnnualBonus` with different logic.
// Demonstrate encapsulation, inheritance, and polymorphism by calculating bonuses for both types of employees.

// using System;

// namespace OOPConcepts
// {
//     abstract class Employee
//     {
//         private string _name;
//         private double _salary;

//         public string Name
//         {
//             get { return _name; }
//             set { _name = value; }
//         }

//         public double Salary
//         {
//             get { return _salary; }
//             set { _salary = value; }
//         }

//         public abstract double CalculateAnnualBonus();
//     }

//     class FullTimeEmployee : Employee
//     {
//         public override double CalculateAnnualBonus()
//         {
//             return Salary * 0.2; // 20% bonus for full-time employees
//         }
//     }

//     class PartTimeEmployee : Employee
//     {
//         public override double CalculateAnnualBonus()
//         {
//             return Salary * 0.1; // 10% bonus for part-time employees
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             FullTimeEmployee fullTime = new FullTimeEmployee
//             {
//                 Name = "John Doe",
//                 Salary = 60000
//             };
//             PartTimeEmployee partTime = new PartTimeEmployee
//             {
//                 Name = "Jane Smith",
//                 Salary = 20000
//             };

//             Console.WriteLine($"{fullTime.Name} Annual Bonus: {fullTime.CalculateAnnualBonus()}");
//             Console.WriteLine($"{partTime.Name} Annual Bonus: {partTime.CalculateAnnualBonus()}");
//         }
//     }
// }

//Question 2:
// Define a base class `Appliance` with encapsulated properties for `Brand` and `Power`.
// Create a derived class `WashingMachine` that adds a property for `LoadCapacity` and a method to start the washing cycle.
// Define another derived class `Microwave` with a method to set the cooking time.
// Demonstrate encapsulation, inheritance, and method overriding by creating and using these appliance objects.

// using System;

// namespace OOPConcepts
// {
//     class Appliance
//     {
//         private string _brand;
//         private int _power;

//         public string Brand
//         {
//             get { return _brand; }
//             set { _brand = value; }
//         }

//         public int Power
//         {
//             get { return _power; }
//             set { _power = value; }
//         }
//     }

//     class WashingMachine : Appliance
//     {
//         public int LoadCapacity { get; set; }

//         public void StartWashingCycle()
//         {
//             Console.WriteLine("Starting washing cycle.");
//         }
//     }

//     class Microwave : Appliance
//     {
//         public void SetCookingTime(int minutes)
//         {
//             Console.WriteLine($"Setting cooking time to {minutes} minutes.");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             WashingMachine washer = new WashingMachine
//             {
//                 Brand = "Samsung",
//                 Power = 1500,
//                 LoadCapacity = 8
//             };
//             Microwave microwave = new Microwave
//             {
//                 Brand = "LG",
//                 Power = 1000
//             };

//             Console.WriteLine($"Washing Machine - Brand: {washer.Brand}, Power: {washer.Power}W, Load Capacity: {washer.LoadCapacity}kg");
//             washer.StartWashingCycle();

//             Console.WriteLine($"Microwave - Brand: {microwave.Brand}, Power: {microwave.Power}W");
//             microwave.SetCookingTime(5);
//         }
//     }
// }

//Question 3:
// Implement a base class `Shape` with encapsulated properties for `Area` and `Perimeter`, and an abstract method `CalculateDimensions`.
// Derive classes `Square` and `Circle` that override `CalculateDimensions` to compute their specific area and perimeter.
// Use encapsulation to protect `Area` and `Perimeter`, and demonstrate inheritance and polymorphism by creating and manipulating shapes.

// using System;

// namespace OOPConcepts
// {_
//     abstract class Shape
//     {
//         private double _area;
//         private double _perimeter;

//         public double Area
//         {
//             get { return _area; }
//             protected set { _area = value; }
//         }

//         public double Perimeter
//         {
//             get { return _perimeter; }
//             protected set { _perimeter = value; }
//         }

//         public abstract void CalculateDimensions();
//     }

//     class Square : Shape
//     {
//         private double _sideLength;

//         public Square(double sideLength)
//         {
//             _sideLength = sideLength;
//             CalculateDimensions();
//         }

//         public override void CalculateDimensions()
//         {
//             Area = _sideLength * _sideLength;
//             Perimeter = 4 * _sideLength;
//         }
//     }

//     class Circle : Shape
//     {
//         private double _radius;

//         public Circle(double radius)
//         {
//             _radius = radius;
//             CalculateDimensions();
//         }

//         public override void CalculateDimensions()
//         {
//             Area = Math.PI * _radius * _radius;
//             Perimeter = 2 * Math.PI * _radius;
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Shape square = new Square(4);
//             Shape circle = new Circle(5);

//             Console.WriteLine($"Square - Area: {square.Area}, Perimeter: {square.Perimeter}");
//             Console.WriteLine($"Circle - Area: {circle.Area}, Perimeter: {circle.Perimeter}");
//         }
//     }
// }
