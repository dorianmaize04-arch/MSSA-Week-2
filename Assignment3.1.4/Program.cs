/* Write a function which takes an array as input and finds the first occurrence of 2 consecutive 1s and changes their value to 0.
1.
For e.g: Input : [0,2,1,1,9,1,1]

Output: [0,2,0,0,9,1,1] */


int[] numbers = { 0, 2, 1, 1, 9, 1, 1 };

ChangeConsecutiveOnes(numbers);

Console.WriteLine("[" + string.Join(",", numbers) + "]");


static void ChangeConsecutiveOnes(int[] numbers)
{
    int counter = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == 1)
        {
            counter++;
        }
        else
        {
            counter = 0;
        }

        if (counter == 2)
        {
            numbers[i] = 0;
            numbers[i - 1] = 0;
            break;
        }
    }
}
