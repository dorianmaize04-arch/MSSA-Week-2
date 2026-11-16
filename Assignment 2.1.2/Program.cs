/* Overloading: Write a simple Maths class ( don’t use the keyword Math, it will be a conflict with standard class from system). Write overloaded methods with logic and give choice to user to call different methods :
a. Add(int num1, int num2)
b. Add(decimal num1, decimal num2, decimal num3)
c. Multiply(float num1, float num2)
d. Multiply( float num1, float num2, float num3)
Declare these methods as public and static. */



using System.ComponentModel;
using System.Diagnostics;
int num1 = 0;
int num2 = 0;
decimal decimalNum1;
decimal decimalNum2;
decimal decimalNum3;
float floatNum1;
float floatNum2;
float floatNum3;
    




Console.WriteLine("Hello");




    Console.WriteLine("What would you like to do");
    Console.WriteLine("A: Add 2 numbers");
    Console.WriteLine("B: Add 3 numbers");
    Console.WriteLine("C: Multiply 2 numbers");
Console.WriteLine("D: Multply 3 numbers");
Console.WriteLine("E: End Program");

string choice = Console.ReadLine().ToUpper();

switch (choice)
{
    case "A":
        Console.WriteLine("Please input first number");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please input second number");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Your answer is {Maths.Add(num1, num2)}");
        break;

    case "B":
        Console.WriteLine("Please input first number");
        decimalNum1 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Please input second number");
        decimalNum2 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Please input third number");
        decimalNum3 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine($"Your answer is {Maths.Add(decimalNum1, decimalNum2, decimalNum3)}");
        break;

    case "C":
        Console.WriteLine("Please input first number");
        floatNum1 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Please input second number");
        floatNum2 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine($"Your answer is {Maths.Multiply(floatNum1, floatNum2)}");
        break;

    case "D":
        Console.WriteLine("Please input first number");
        floatNum1 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Please input second number");
        floatNum2 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Please input third number");
        floatNum3 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine($"Your answer is {Maths.Multiply(floatNum1, floatNum2, floatNum3)}");
        break;

    case "E":
        Console.WriteLine("Goodbye!");
        break;

    default:
        Console.WriteLine("Invalid option");
        break;











}




class Maths
{

    public static int Add(int num1, int num2)

    { return num1 + num2; }

    public static decimal Add(decimal decimalNum1, decimal decimalNum2, decimal decimalNum3)
    { return (decimal)(decimalNum1 + decimalNum2 + decimalNum3); }

    public static float Multiply(float floatNum1, float floatNum2)
    { return (float)(floatNum1 * floatNum2); }

    public static float Multiply(float floatNum1, float floatNum2, float floatNum3)
    { return (float)(floatNum1 * floatNum2 * floatNum3); }


}











