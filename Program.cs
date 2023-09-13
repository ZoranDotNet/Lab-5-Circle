namespace Circle
{
    class Circle
    {
        public const float Pi = 3.141f;
        public int Radius { get; set; }

        public Circle(int radius)  //constructor
        {
            Radius = radius;
        }

        public double GetArea(int radius)  //method - calculate area of circle
        {
            double area = Math.Pow(radius, 2) * Pi;
            return Math.Round(area, 2);
        }

        public double GetCircumference(int radius) //method - calculate circumference of circle
        {
            double circumference = radius * 2 * Pi;
            return Math.Round(circumference, 2);
        }
        public double GetSphereArea(int radius)  // method - calculate area of sphere
        {
            double area = 4 * Pi * Math.Pow(Radius, 2);
            return Math.Round(area, 2);
        }
        public double GetSphereVolume(double radius)
        {
            double volume = (4 * Pi) * Math.Pow(radius, 3) / 3;
            return Math.Round(volume, 2);
        }


    }

    class Triangle
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double triangleBase, double triangleHeight) // constructor
        {
            Base = triangleBase;
            Height = triangleHeight;
        }

        public double GetArea(double triangleBase, double triangleHeight)  //method - calculate area of triangle
        {
            return triangleBase * triangleHeight / 2;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Circle circle1 = new(5);
            Circle circle2 = new(6);
            Triangle triangle = new(5, 7);

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
            Console.WriteLine($"Area of the triangle is: {triangle.GetArea(triangle.Height, triangle.Base)}cm²");




            Console.ReadKey();
        }
    }
}