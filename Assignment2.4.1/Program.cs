/* Write a program in C# Sharp to find the sum of all array elements.

Test Data :

Input the number of elements to be stored in the array :3

Input 3 elements in the array :

element - 0 : 2

element - 1 : 5

element - 2 : 8

Expected Output :

Sum of all elements stored in the array is : 15 */



int sum = 0;
int arraySize = 0;

Console.WriteLine("Please write the number of elements you would like to store in your array:");
arraySize = Convert.ToInt32(Console.ReadLine());
int[] arrayElements = new int[arraySize];

Console.WriteLine($"You input {arraySize} elements in to the array :");


for (int i = 0; i < arraySize; i++)
{
  Console.WriteLine($"Enter element {i}:");
  arrayElements[i] = Convert.ToInt32(Console.ReadLine());
  sum += arrayElements[i];

}

Console.WriteLine($"Your total sum is {sum}");








