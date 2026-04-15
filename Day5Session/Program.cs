//************************************ How C# Programs Work ************************************//
/*
1. Source Code -> .cs files
2. Compilation -> .exe or .dll (Intermediate Language - IL)
3. CLR (Common Language Runtime) -> manages memory, handles exceptions, garbage collection
4. JIT (Just-In-Time Compiler) -> compiles IL to machine code at runtime
*/

//************************************ Step Wise Program Execution ************************************//
/*
Step 1 — You write code (.cs file)
Think of this like writing a recipe. You type instructions in English-like text (C#), and save it as a file. 
The computer can't do anything with this yet — it's just words on a page.

Step 2 — The compiler translates it (IL code)
A tool called the compiler reads your recipe and converts it into a special intermediate language (IL). 
It's no longer human-readable, but it's also not yet something your computer's processor can run directly. Think of it like translating your recipe into a universal symbol language.

Step 3 — The CLR manages things
The Common Language Runtime is like a kitchen manager. When your program runs, the CLR watches over it — 
it cleans up memory you no longer need (garbage collection), catches errors so your app doesn't crash badly, and keeps everything running safely.

Step 4 — The JIT makes it fast
The Just-In-Time compiler is the chef who actually cooks. It reads those symbols and converts them into real instructions that your specific computer's processor understands — right as the program is running.

Step 5 — Your program runs!
The machine instructions execute, and your app does its thing — shows a window, calculates something, plays a sound, etc.
*/


//************************************ Access Modifiers ************************************//
/*
public -> any where accessible -> shopping mall open doors
private -> only inside same class -> shopping mall manager's office
protected -> inside same class and derived classes -> shopping mall manager's office and security guard (derived class)
internal -> inside same assembly , same project -> shopping mall, only people with access card can enter
protected internal -> same class, chil class, or any class within same assembly/project -> shopping mall, only people with access card can enter, and security guard (derived class)
private protected -> inside same class and derived classes (but not accessible from outside) -> shopping mall manager's office, only security guard (derived class) can enter, but not accessible from outside
*/



//************************************ Classes And Objects ************************************//
/*
Class -> blueprint for creating objects, defines properties and behaviors
Object -> instance of a class, has state and behavior
*/
//************************************ Class Syntax ************************************//
/*
class ClassName
{
    // Fields (variables)
    // Properties
    // Methods (functions)
    // Constructors
}
*/

/*
    Example:
    // This is the CLASS — the blueprint (written once)
    class Car
    {
        // Properties — the data each car holds
        public string Color;
        public string Brand;
        public int Speed;

        // Method — something every car can do
        public void Honk()
        {
            Console.WriteLine("Beep beep!");
        }
    }
*/


//************************************ Object Syntax ************************************//
/*
    ClassName objectName = new ClassName(); // Create a new object (instance of the class)
    objectName.Property = value; // Set properties
*/

/*
    Example:
    // This is the OBJECT — an actual car you can use (created from the blueprint)
    Car myCar = new Car(); // Create a new car object
    myCar.Color = "Red"; // Set properties
    myCar.Brand = "Toyota";
    myCar.Speed = 100;
    myCar.Honk(); // Call method
*/


//************************************ Constructors ************************************//
/*
Constructor -> special method that is called when an object is created, used to initialize properties
Syntax:
class ClassName
{
    // Constructor
    public ClassName()
    {
        // Initialization code
    }
}       
*/

//************************************ Constructors Syntax ************************************//
/*
class ClassName
{
    // Constructor
    public ClassName()
    {
        // Initialization code
    }
}       
*/

/*
    Example:
    class Car
    {
        public string Color;
        public string Brand;
        public int Speed;
        public int NoOfDoors;

        // Constructor to initialize properties
        public Car(string color, string brand, int speed)
        {
            Color = color;
            Brand = brand;
            Speed = speed;
            NoOfDoors = 4; // Default value for all cars
        }

        public void Honk()
        {
            Console.WriteLine("Beep beep!");
        }
    }

    // Creating an object using the constructor
    Car myCar = new Car("Red", "Toyota", 100);
    myCar.Honk();
*/



//************************************ Static Class ************************************//
/*
Static Class -> a class that cannot be instantiated, all members must be static, used for utility or helper methods
*/

//************************************ Static Class Syntax************************************//
/*
static class ClassName
{
    // Static members
}

//Usage:
ClassName.StaticMethod(); // Call static method without creating an object
*/

/*
    Example:
    static class Utility
    {
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

    // Using the static method without creating an object
    Utility.PrintMessage("Hello, World!");
*/


//************************************ Complete Example With All The Learned Details ************************************//

/*
namespace Day5Session
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            
            //Access Modifiers Example:
            //student.name = "Ram"; // Error: 'Student.name' is inaccessible due to its protection level
            //student.age = 20; // Error: 'Student.age' is inaccessible due to its protection level
            //student.college = "XYZ College"; // Accessible (internal)
            //student.country = "USA"; // Accessible (protected internal)
            
            

            // Set student details using the method
            //if we don't set student details, it will use the default values from the constructor
            student.SetStudentDetails("Ram", 20); 
            
            // Display student details
            student.DisplayStudent(); 
        
            //Usage of derived class / inheritance
            SunwayStudents sunwayStudents = new SunwayStudents();
            sunwayStudents.DisplayStudentDetails();
            sunwayStudents.DisplayStudent();


            //Usage of static class and method
            Utility.PrintMessage("Welcome to the Student Management System!");
        
            Console.ReadLine();

            // Reference Type Example:
            Student studentSunway = student; // Reference to the same object
            studentSunway.SetStudentDetails("Shyam", 20); // Both student and studentSunway refer to the same object, so changes affect both
            // Display student details using both references
            student.DisplayStudent();
            // Display student details using the second reference
            studentSunway.DisplayStudent();
            

        }
    }

    public class Student
    {
        // Fields with different access modifiers

        // Proper way to initialize properties with getters and setters

        // can be accessed only within the Student class
        private string name { get; set; }

        // can be accessed within the Student class and derived classes (like SunwayStudents)
        protected int age;

        // can be accessed within the same assembly/project (like Program class)
        internal string college = "Sunway College";

        // can be accessed within the same assembly/project and derived classes (like SunwayStudents)
        protected internal string country = "Nepal";

        // constructor to initialize default values for the student
        public Student()
        {
            name = "Hello Bob";
            age = 10;
        }

        // Method to set student details
        public void SetStudentDetails(string studentName, int studentAge)
        {
            name = studentName;
            age = studentAge;
        }

        // Method to display student details
        public void DisplayStudent()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("College: " + college);
            Console.WriteLine("Country: " + country);
        }
    }

    // Derived class that inherits from Student class
    public class SunwayStudents : Student
    {
        public void DisplayStudentDetails()
        {
            Console.WriteLine("College: " + college); // Accessible (internal)
            Console.WriteLine("Country: " + country); // Accessible (protected internal)
            Console.WriteLine("Age: " + age); // Accessible (protected)
        }
    }

    // Static class for utility methods
    // This class cannot be instantiated and all members must be static
    public static class Utility
    {
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
*/

//************************************ Notes ************************************//
/*
    1. Inherited class after initialization will also hit the constructor of the base class (Student) and initialize the default values for the inherited class (SunwayStudents) as well, but we can override it in the derived class if needed.
    2. Static classes cannot be instantiated, and all members must be static. They are used for utility or helper methods that don't require an instance of the class to be used.
    3. Static class can have constructors, but they are static constructors and are called automatically before the first instance is created or any static members are referenced. They are used to initialize static members of the class.
*/



//************************************ Practice Session ************************************//

/*
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("*********************************************************");
Console.WriteLine("*********************************************************");
Console.WriteLine("******************  Practice Session  *******************");
Console.WriteLine("*********************************************************");
Console.WriteLine("*********************************************************");
Console.ResetColor();
*/


//************************************************************************************* Practice Problems *********************************************************************// 
// 1. Create a 'Rectangle' class with private fields Width and Height, a parameterised constructor, public properties with validation (no negative values), and methods GetArea() and GetPerimeter().
// 2. Create a 'Person' class with Name, Age, Email. The Email property must validate that it contains '@'. If invalid, throw an exception.
// 3. Add a static field 'TotalObjects' to your Person class. Every time a Person is created, increment it. After creating 5 people, print the total count.
// 4. Create a 'Temperature' class that stores Celsius internally but has a computed property 'Fahrenheit' that converts it: F = (C × 9/5) + 32.