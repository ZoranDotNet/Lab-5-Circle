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
            double area = (radius * radius) * Pi;
            return Math.Round(area, 2);
        }

        public double GetCircumference(int radius) //method - calculate circumference of circle
        {
            double circumference = radius * 2 * Pi;
            return Math.Round(circumference, 2);
        }
        public double GetSphereArea(int radius)  // method - calculate area of sphere
        {
            double area = 4 * Pi * (radius * radius);
            return Math.Round(area, 2);
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
            double area = triangleBase * triangleHeight / 2;
            return area;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Circle circle1 = new(5);
            Triangle triangle1 = new(5, 7);

            Console.WriteLine("Area of circle with radius 5cm is: " + circle1.GetArea(5) + " cm²");
            Console.WriteLine("Area of circle with radius 6cm is: " + circle1.GetArea(6) + " cm²");
            Console.WriteLine();
            Console.WriteLine("The circumference of circle with radius 5cm is: " + circle1.GetCircumference(5) + " cm.");
            Console.WriteLine("The circumference of circle with radius 6cm is: " + circle1.GetCircumference(6) + " cm.");
            Console.WriteLine();
            Console.WriteLine("Area of sphere with radius 5cm is: " + circle1.GetSphereArea(9) + " cm²");
            Console.WriteLine();
            Console.WriteLine("Area of triangle with base 5cm and height 7cm is: " + triangle1.GetArea(5, 7) + " cm²");




            Console.ReadKey();
        }
    }
}