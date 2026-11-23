/* . Create a function that finds the index of a given item in the array

Examples

Search([1, 5, 3], 5) ➞ 1

Search([9, 8, 3], 3) ➞ 2

Search([1, 2, 3], 4) ➞ -1

Notes

If the item is not present, return -1. */


int[] numbers1 = { 1, 5, 3 };
int[] numbers2 = { 9, 8, 3 };
int[] numbers3 = { 1, 2, 3 };

Console.WriteLine(Search(numbers1, 5));
Console.WriteLine(Search(numbers2, 3));
Console.WriteLine(Search(numbers3, 4));

static int Search(int[] numbers, int target)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == target)
        {
            return i;
        }
    }

    return -1;
}
