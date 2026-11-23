/* Write a program in C# Sharp for addition of two Matrices of same size.

Test Data :

Input the size of the square matrix (less than 5): 2

Input elements in the first matrix :

element - [0],[0] : 1

element - [0],[1] : 2

element - [1],[0] : 3

element - [1],[1] : 4

Input elements in the second matrix :

element - [0],[0] : 5

element - [0],[1] : 6

element - [1],[0] : 7

element - [1],[1] : 8

Expected Output:

The First matrix is:

1 2

3 4

The Second matrix is :

5 6

7 8

The Addition of two matrix is :

6 8

10 12

*/



int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
int[,] matrix2 = { { 5, 6 }, { 7, 8 } };
int[,] sum = new int[2, 2];

// Add the two matrices
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        sum[i, j] = matrix1[i, j] + matrix2[i, j];
    }
}

// Display first matrix
Console.WriteLine("The First matrix is:");

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write(matrix1[i, j] + " ");
    }
    Console.WriteLine();
}

// Display second matrix
Console.WriteLine("\nThe Second matrix is:");

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write(matrix2[i, j] + " ");
    }
    Console.WriteLine();
}

// Display addition
Console.WriteLine("\nThe Addition of two matrix is:");

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write(sum[i, j] + " ");
    }
    Console.WriteLine();
}
