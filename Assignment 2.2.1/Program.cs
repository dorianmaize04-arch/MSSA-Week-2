/* Write a abstract base class: ‘Shape’ and add properties like id, name and color and method ‘calculate area’ .

Inherit circle shape from base class and add properties like radius. override calculate area logic for circle.

Inherit square class from shape and change the calculate area logic. Add property like side of square.

Take the input from user to select circle or square and display the calculated area . no hard coded values! */
Circle circle1 = new Circle();
Square square1 = new Square();




Console.WriteLine("Welcome to the Shape Area Calculator!");
Console.WriteLine();
Console.WriteLine("Select a shape");
Console.WriteLine("1. Circle");
Console.WriteLine("2. Square");
Console.WriteLine();
Console.WriteLine("Enter your choice:");

int choice = Convert.ToInt32(Console.ReadLine());



switch (choice)
{
    case 1:
        Console.WriteLine("Please input the radius of the circle");
         circle1.circleRadius = Convert.ToDouble(Console.ReadLine());
        circle1.ShapeArea();
        Console.WriteLine($"The area of the circle is : {circle1.ShapeArea()}");
  break;

    case 2:
        Console.WriteLine("Please enter your shape's side:");
        square1.squareSide = Convert.ToInt32(Console.ReadLine());
        square1.ShapeArea();
        Console.WriteLine($"The area of the square is : {square1.ShapeArea()}");
        break;



}





abstract class Shape
{
    public int shapeID;
    public string shapeColor;
    public string shapeName;

    public abstract double ShapeArea();
    
}

class Circle : Shape

{
    public double circleRadius;

    public override double ShapeArea()
    {
        return Math.PI * circleRadius * circleRadius;
        
    }

}

class Square : Shape
{
    public double squareSide;
    public override double ShapeArea()
    {
        return squareSide * squareSide;


    }

}



