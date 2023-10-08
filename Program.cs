namespace Circle
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Circle c1 = new(5);       //instantiate objects 
            Circle c2 = new(6);
            Triangle t = new(5, 6);


            c1.GetArea(5);


            // Call our methods
            Console.WriteLine($"Radius of circle1 is: {c1.Radius}cm");
            Console.WriteLine($"Radius of circle2 is: {c2.Radius}cm");
            Console.WriteLine($"Triangle has a base of {t.Base}cm and a height of {t.Height}cm");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Area of circle1 is: {c1.GetArea(c1.Radius)}cm²");
            Console.WriteLine($"Area of circle2 is: {c2.GetArea(c2.Radius)}cm²");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"The circumference of circle1 is: {c1.GetCircumference(c1.Radius)}cm");
            Console.WriteLine($"The circumference of circle2 is: {c2.GetCircumference(c2.Radius)}cm");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Surface area of a sphere with radius 6cm is: {c2.GetSphereArea(c2.Radius)}cm²");
            Console.WriteLine($"Volume of a sphere with radius 6cm is: {c2.GetSphereVolume(c2.Radius)}cm³");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Area of triangle is: {t.GetArea(t.Height, t.Base)}cm²");
            Console.WriteLine($"Circumference of a right triangle is: {t.GetCircumference(t.Height, t.Base)}cm");





            Console.ReadKey();
        }
    }
}