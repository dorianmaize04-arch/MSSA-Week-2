/* Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string.
Test Data :
Please input a string : This is a test string.
Expected Output :
"This is a test string." contains 4 spaces */


/*
Write a program to input a string and
count the number of spaces in the string.
*/

Console.WriteLine("Please input a string:");
string userInput = Console.ReadLine() ?? "";

int spaceCount = CountSpaces(userInput);

Console.WriteLine($"\"{userInput}\" contains {spaceCount} spaces");


static int CountSpaces(string text)
{
    int count = 0;

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == ' ')
        {
            count++;
        }
    }

    return count;
}
