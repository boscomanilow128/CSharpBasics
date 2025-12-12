using System;

// This declares a class named "Program". In C#, all code must be inside a class.
// Classes are blueprints for creating objects and organizing related functionality.
class Program
{
    // This is the Main method, which is the entry point of the application.
    // When you run the program, execution starts here.
    // - "static" means this method belongs to the class itself, not to instances
    // - "void" means this method doesn't return any value
    // - "string[] args" is an array parameter that can receive command-line arguments
    static void Main(string[] args)
    {
        Console.WriteLine("=== C# BASICS TUTORIAL ===\n");

        // ==================== VARIABLES AND DATA TYPES ====================
        Console.WriteLine("--- 1. VARIABLES AND DATA TYPES ---");

        // Integer types
        int age = 25;                    // Whole numbers (-2,147,483,648 to 2,147,483,647)
        long population = 7800000000;    // Larger whole numbers

        // Floating-point types
        double price = 19.99;            // Double precision decimal (15-16 digits)
        float temperature = 36.5f;       // Single precision decimal (6-7 digits) - note the 'f'
        decimal money = 1234.56m;        // High precision for financial calculations - note the 'm'

        // Character and string
        char grade = 'A';                // Single character - use single quotes
        string name = "Alice";           // Text - use double quotes

        // Boolean
        bool isStudent = true;           // true or false

        // Display variables
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Price: ${price}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Is Student: {isStudent}\n");

        // ==================== CONSTANTS ====================
        Console.WriteLine("--- 2. CONSTANTS ---");

        // Constants cannot be changed after declaration
        const double PI = 3.14159;
        const int DAYS_IN_WEEK = 7;

        Console.WriteLine($"PI: {PI}");
        Console.WriteLine($"Days in a week: {DAYS_IN_WEEK}\n");

        // ==================== OPERATORS ====================
        Console.WriteLine("--- 3. OPERATORS ---");

        // Arithmetic operators
        int a = 10;
        int b = 3;
        Console.WriteLine($"Addition: {a} + {b} = {a + b}");
        Console.WriteLine($"Subtraction: {a} - {b} = {a - b}");
        Console.WriteLine($"Multiplication: {a} * {b} = {a * b}");
        Console.WriteLine($"Division: {a} / {b} = {a / b}");           // Integer division
        Console.WriteLine($"Modulus (remainder): {a} % {b} = {a % b}");

        // Comparison operators
        Console.WriteLine($"\n{a} > {b} is {a > b}");
        Console.WriteLine($"{a} < {b} is {a < b}");
        Console.WriteLine($"{a} == {b} is {a == b}");
        Console.WriteLine($"{a} != {b} is {a != b}");

        // Logical operators
        bool x = true;
        bool y = false;
        Console.WriteLine($"\ntrue AND false = {x && y}");
        Console.WriteLine($"true OR false = {x || y}");
        Console.WriteLine($"NOT true = {!x}\n");

        // ==================== TYPE CONVERSION ====================
        Console.WriteLine("--- 4. TYPE CONVERSION ---");

        // Implicit conversion (automatic)
        int num1 = 100;
        double num2 = num1;  // int to double - safe, no data loss
        Console.WriteLine($"Implicit: int {num1} to double {num2}");

        // Explicit conversion (casting)
        double num3 = 9.8;
        int num4 = (int)num3;  // double to int - may lose data
        Console.WriteLine($"Explicit: double {num3} to int {num4}");

        // Parse string to number
        string numberText = "42";
        int parsedNumber = int.Parse(numberText);
        Console.WriteLine($"Parse: string \"{numberText}\" to int {parsedNumber}\n");

        // ==================== STRING OPERATIONS ====================
        Console.WriteLine("--- 5. STRING OPERATIONS ---");

        string firstName = "John";
        string lastName = "Doe";

        // Concatenation
        string fullName = firstName + " " + lastName;
        Console.WriteLine($"Concatenation: {fullName}");

        // String interpolation (modern way)
        string greeting = $"Hello, {firstName}!";
        Console.WriteLine($"Interpolation: {greeting}");

        // String methods
        Console.WriteLine($"Length: {fullName.Length}");
        Console.WriteLine($"Uppercase: {fullName.ToUpper()}");
        Console.WriteLine($"Lowercase: {fullName.ToLower()}");
        Console.WriteLine($"Contains 'John': {fullName.Contains("John")}\n");

        // ==================== CONDITIONAL STATEMENTS ====================
        Console.WriteLine("--- 6. CONDITIONAL STATEMENTS (IF/ELSE) ---");

        int score = 85;

        if (score >= 90)
        {
            Console.WriteLine("Grade: A");
        }
        else if (score >= 80)
        {
            Console.WriteLine("Grade: B");
        }
        else if (score >= 70)
        {
            Console.WriteLine("Grade: C");
        }
        else
        {
            Console.WriteLine("Grade: F");
        }

        // Ternary operator (shorthand if/else)
        string result = (score >= 60) ? "Pass" : "Fail";
        Console.WriteLine($"Result: {result}\n");

        // ==================== SWITCH STATEMENT ====================
        Console.WriteLine("--- 7. SWITCH STATEMENT ---");

        int dayNumber = 3;
        string dayName;

        switch (dayNumber)
        {
            case 1:
                dayName = "Monday";
                break;
            case 2:
                dayName = "Tuesday";
                break;
            case 3:
                dayName = "Wednesday";
                break;
            case 4:
                dayName = "Thursday";
                break;
            case 5:
                dayName = "Friday";
                break;
            default:
                dayName = "Weekend";
                break;
        }

        Console.WriteLine($"Day {dayNumber} is {dayName}\n");

        // ==================== LOOPS ====================
        Console.WriteLine("--- 8. LOOPS ---");

        // For loop
        Console.WriteLine("For loop (1 to 5):");
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();

        // While loop
        Console.WriteLine("\nWhile loop (countdown from 5):");
        int count = 5;
        while (count > 0)
        {
            Console.Write($"{count} ");
            count--;
        }
        Console.WriteLine();

        // Do-While loop (executes at least once)
        Console.WriteLine("\nDo-While loop:");
        int number = 1;
        do
        {
            Console.Write($"{number} ");
            number++;
        } while (number <= 3);
        Console.WriteLine("\n");

        // ==================== ARRAYS ====================
        Console.WriteLine("--- 9. ARRAYS ---");

        // Declare and initialize array
        int[] numbers = { 10, 20, 30, 40, 50 };
        string[] fruits = new string[3] { "Apple", "Banana", "Orange" };

        Console.WriteLine($"Array length: {numbers.Length}");
        Console.WriteLine($"First element: {numbers[0]}");
        Console.WriteLine($"Last element: {numbers[numbers.Length - 1]}");

        // Loop through array
        Console.WriteLine("\nFruits in array:");
        for (int i = 0; i < fruits.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {fruits[i]}");
        }

        // Foreach loop (easier way to iterate)
        Console.WriteLine("\nNumbers using foreach:");
        foreach (int num in numbers)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine("\n");

        // ==================== MULTI-DIMENSIONAL ARRAYS ====================
        Console.WriteLine("--- 10. MULTI-DIMENSIONAL ARRAYS ---");

        // 2D array (matrix)
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.WriteLine("2D Array (3x3 matrix):");
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write($"{matrix[row, col]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // ==================== METHODS/FUNCTIONS ====================
        Console.WriteLine("--- 11. METHODS/FUNCTIONS ---");

        // Call methods defined below Main
        SayHello();
        SayHelloTo("Bob");
        int sum = Add(5, 3);
        Console.WriteLine($"5 + 3 = {sum}");

        int product = Multiply(4, 7);
        Console.WriteLine($"4 * 7 = {product}\n");

        // ==================== END ====================
        Console.WriteLine("=== END OF C# BASICS TUTORIAL ===");
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    // ==================== EXAMPLE METHODS ====================

    // Method with no parameters and no return value
    static void SayHello()
    {
        Console.WriteLine("Hello from a method!");
    }

    // Method with parameter but no return value
    static void SayHelloTo(string personName)
    {
        Console.WriteLine($"Hello, {personName}!");
    }

    // Method with parameters and return value
    static int Add(int x, int y)
    {
        return x + y;
    }

    // Another method with return value
    static int Multiply(int x, int y)
    {
        int result = x * y;
        return result;
    }
}