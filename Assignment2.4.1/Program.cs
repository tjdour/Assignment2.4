
//Assignment 2.4.1
Console.WriteLine("Calculating sum of an array.\nEnter size of array: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int [arraySize];

Console.WriteLine($"Enter {arraySize} elements in the array:");

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Element - {i}: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

int sum = 0;
foreach (int n in numbers)
{
    sum += n;
}
Console.WriteLine($"The sum of the array is: {sum}");
