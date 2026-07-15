//Assignmetn 2.4.2
Console.WriteLine("Find Largest of 3 numbers");
Console.WriteLine("Enter first number: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int second = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number: ");
int third = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"You entered the numbers: {first}, {second}, {third}");

int largest = first;
string pos = "1st";

if (second > largest)
{
    largest = second;
    pos = "2nd";
}

if (third > largest)
{ 
    largest=third;
    pos = "3rd";
}

Console.WriteLine($"The {pos} Number is the greatest among three: {largest}");



//if (first >= second && first >= third)
//{
//    Console.WriteLine("First largest");
//}
//else if (second >= first && second >= third)
//{
//    Console.WriteLine("Second is largest");
//}
//else
//{ 
//    Console.WriteLine("Third is largest");
//}