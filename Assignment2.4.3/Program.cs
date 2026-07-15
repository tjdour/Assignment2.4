Console.WriteLine("Hello, World!");

Console.WriteLine("Input the value for X coordinate: ");
int xPosition = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the value for Y coordinate: ");
int yPosition = Convert.ToInt32(Console.ReadLine());

switch(xPosition, yPosition)
{
    case (> 0, > 0):
        Console.WriteLine($"The coordinate point ({xPosition},{yPosition}) lies in the First quadrant.");
        break;
    case(< 0, > 0):
        Console.WriteLine($"The coordinate point ({xPosition},{yPosition}) lies in the Second quadrant.");
        break;
    case ( < 0, < 0):
        Console.WriteLine($"The coordinate point ({xPosition},{yPosition}) lies in the Third quadrant.");
        break;
    case ( > 0, < 0):
        Console.WriteLine($"The coordinate point ({xPosition},{yPosition}) lies in the Fourth quadrant.");
        break;

}

//Quad1: x > 0 && y > 0

//quad2 x<0 && y > 0

//quad 3 x< 0 && y < 0

//quad 4 x > 0 && y< 0