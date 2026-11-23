/* Create a 2D array to store integers and print them in matrix format with proper formatting.

e. g:

| 2 | 3 | 4 |

| 1 | 4 | 6 | */

int[,] numbers =
{
  { 2, 3, 4},
  { 1, 4, 8}


};

for (int i = 0; i < numbers.GetLength(0); i++)
{
  for (int j = 0; j < numbers.GetLength(1); j++)
  {
    Console.Write($"| {numbers[i, j]} ");

  }
Console.WriteLine("|");
  
}