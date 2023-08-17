using System;

namespace CsharpDemo
{
    class DataTypes 
    {
        public static void Demo()
        {
            // Value Types
            // Integral data types
            Console.WriteLine("byte: 8-bit unsigned integer (0 to 255)");
            byte aByte = 255;
            Console.WriteLine($"byte value: {aByte}");

            Console.WriteLine("sbyte: 8-bit signed integer (-128 to 127)");
            sbyte aSByte = -127;
            Console.WriteLine($"sbyte value: {aSByte}");

            Console.WriteLine("short: 16-bit signed integer (-32,768 to 32,767)");
            short aShort = -32768;
            Console.WriteLine($"short value: {aShort}");

            Console.WriteLine("ushort: 16-bit unsigned integer (0 to 65,535)");
            ushort aUShort = 65535;
            Console.WriteLine($"ushort value: {aUShort}");

            Console.WriteLine("int: 32-bit signed integer (-2,147,483,648 to 2,147,483,647)");
            int anInt = 123456789;
            Console.WriteLine($"int value: {anInt}");

            Console.WriteLine("uint: 32-bit unsigned integer (0 to 4,294,967,295)");
            uint aUInt = 1234567890;
            Console.WriteLine($"uint value: {aUInt}");

            Console.WriteLine("long: 64-bit signed integer (-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807)");
            long aLong = -1234567890123456789;
            Console.WriteLine($"long value: {aLong}");

            Console.WriteLine("ulong: 64-bit unsigned integer (0 to 18,446,744,073,709,551,615)");
            ulong aULong = 12345678901234567890;
            Console.WriteLine($"ulong value: {aULong}");

            Console.WriteLine("char: 16-bit Unicode character (U+0000 to U+FFFF)");
            char aChar = 'A';
            Console.WriteLine($"char value: {aChar}");

            // Floating-point data types
            Console.WriteLine("float: 32-bit floating-point number (Approx. ±1.5 x 10^-45 to ±3.4 x 10^38)");
            float aFloat = 3.14F;
            Console.WriteLine($"float value: {aFloat}");

            Console.WriteLine("double: 64-bit floating-point number (Approx. ±5.0 x 10^-324 to ±1.7 x 10^308)");
            double aDouble = 3.141592653589793;
            Console.WriteLine($"double value: {aDouble}");

            // Decimal data type
            Console.WriteLine("decimal: 128-bit precise decimal values (Approx. ±1.0 x 10^-28 to ±7.9 x 10^28)");
            decimal aDecimal = 3.14159265358979323846M;
            Console.WriteLine($"decimal value: {aDecimal}");

            // Boolean data type
            Console.WriteLine("bool: Boolean value (true or false)");
            bool aBool = true;
            Console.WriteLine($"bool value: {aBool}");

            // Reference Types
            Console.WriteLine("string: Sequence of characters");
            string aString = "Hello, World!";
            Console.WriteLine($"string value: {aString}");

            Console.WriteLine("object: Base class for all data types in C#");
            object anObject = aString;
            Console.WriteLine($"object value: {anObject}");
        }
    }

    class Operators
    {
        public static void Demo()
        {
            // Arithmetic Operators
            Console.WriteLine($"================================  Arithmetic Operators  ================================");

            int a = 10, b = 20;
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"Addition (a + b): {a + b}");
            Console.WriteLine($"Subtraction (a - b): {a - b}");
            Console.WriteLine($"Multiplication (a * b): {a * b}");
            Console.WriteLine($"Division (a / b): {a / b}");
            Console.WriteLine($"Modulus (a % b): {a % b}");
            Console.WriteLine($"Increment (a++): {a++}");
            Console.WriteLine($"Decrement (b--): {b--}");

            // Comparison Operators
            Console.WriteLine($"================================  Comparison Operators  ================================");

            Console.WriteLine($"Equal to (a == b): {a == b}");
            Console.WriteLine($"Not equal to (a != b): {a != b}");
            Console.WriteLine($"Greater than (a > b): {a > b}");
            Console.WriteLine($"Less than (a < b): {a < b}");
            Console.WriteLine($"Greater than or equal to (a >= b): {a >= b}");
            Console.WriteLine($"Less than or equal to (a <= b): {a <= b}");

            // Logical Operators

            Console.WriteLine($"================================  Logical Operators  ================================");

            bool x = true, y = false;
            Console.WriteLine($"x = {x}, y = {y}");
            Console.WriteLine($"AND (x && y): {x && y}");
            Console.WriteLine($"OR (x || y): {x || y}");
            Console.WriteLine($"NOT (x): {!x}");
            Console.WriteLine($"NOT (y): {!y}");

            // Assignment Operators
            Console.WriteLine($"================================  Assignment Operators  ================================");

            int c = a;
            Console.WriteLine($" let say :::: c = {c} , a = {a}");
            Console.WriteLine($"Assignment (c = a): c = {c}");
            c += a;
            Console.WriteLine($"Add and assign (c += a): c = {c}");
            c -= a;
            Console.WriteLine($"Subtract and assign (c -= a): c = {c}");
            c *= a;
            Console.WriteLine($"Multiply and assign (c *= a): c = {c}");
            c /= a;
            Console.WriteLine($"Divide and assign (c /= a): c = {c}");
            c %= a;
            Console.WriteLine($"Modulus and assign (c %= a): c = {c}");

            int someVar = 0;
            Console.WriteLine("c = (1 > someVar) ? 20 : 10;");
            c = (1 > someVar) ? 20 : 10;
            Console.WriteLine($"c: {c}");
        }
    }


    class Logging{
        // method to demonistrate all feature of Console
        public static void Demo(){



        Console. Beep () ;
        Console. BackgroundColor = ConsoleColor. Green;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine ($"Windows Height: {Console. WindowHeight}");
        Console.WriteLine ($"Windows Width: {Console.WindowWidth}");

        Console. BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine ($"Windows max Height: {Console.LargestWindowWidth}");
        Console.WriteLine ($"Windows max Width: {Console.WindowWidth}");


        Console. CancelKeyPress += (x, y) => Console.WriteLine ("The input was cancelled");

        Console. WriteLine ("\n \nWhat is your age?");
        string inputAge = Console. ReadLine () ?? string. Empty;
        Console.WriteLine ($"The age entered was: {inputAge}");

        } 
    }

    class WorkingWithString{
           public static void Demo(){
            // string joining
string x = "Hello";
string y = "World!";
string helloWorld = x + " " + y;
string helloWorldTest2 = string.Concat(x, " ", y, " from space");

// string modifiedSetence2 = sentence. Replace (planet, star);
// Console.WriteLine ("modi fiedSetence2: " + modifiedSetence2) ;

// string interpolation
string helloWorldClean = $"{x} {y} from mars";
        }
    }
}
