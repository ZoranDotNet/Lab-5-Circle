namespace Circle
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Circle circle1 = new(5);       //instantiate object 
            Circle circle2 = new(6);
            Triangle triangle = new(3, 4);


            // Call our methods
            Console.WriteLine($"Radius of circle1 is: {circle1.Radius}cm");
            Console.WriteLine($"Radius of circle2 is: {circle2.Radius}cm");
            Console.WriteLine($"Triangle has a base of {triangle.Base}cm and a height of {triangle.Height}cm");
            Console.WriteLine();
            Console.WriteLine($"Area of circle1 is: {circle1.GetArea(circle1.Radius)}cm²");
            Console.WriteLine($"Area of circle2 is: {circle2.GetArea(circle2.Radius)}cm²");
            Console.WriteLine();
            Console.WriteLine($"The circumference of circle1 is: {circle1.GetCircumference(circle1.Radius)}cm");
            Console.WriteLine($"The circumference of circle2 is: {circle2.GetCircumference(circle2.Radius)}cm");
            Console.WriteLine();
            Console.WriteLine($"Surface area of a sphere with radius 6cm is: {circle2.GetSphereArea(circle2.Radius)}cm²");
            Console.WriteLine($"Volume of a sphere with radius 6cm is: {circle2.GetSphereVolume(circle2.Radius)}cm³");
            Console.WriteLine();
            Console.WriteLine($"Area of triangle is: {triangle.GetArea(triangle.Height, triangle.Base)}cm²");
            Console.WriteLine($"Circumference of a right triangle is: {triangle.GetCircumference(triangle.Height, triangle.Base)}cm");





            Console.ReadKey();
        }
    }
}