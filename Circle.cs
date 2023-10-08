namespace Circle
{
    class Circle  // private class Circle
    {
        public const float Pi = 3.141f;  //This will never change so its a const
        public int Radius { get; set; }   //property


        public Circle(int radius)  //constructor, we set Radius when we create object
        {
            Radius = radius;
        }

        // Method - calculate area of circle
        public double GetArea(int radius)
        {
            double area = Math.Pow(radius, 2) * Pi;
            return Math.Round(area, 2);       // return area rounded to 2 decimals
        }

        // Method - calculate circumference of circle
        public double GetCircumference(int radius)
        {
            double circumference = radius * 2 * Pi;
            return Math.Round(circumference, 2);
        }

        // Method - calculate area of sphere
        public double GetSphereArea(int radius)
        {
            double area = 4 * Pi * Math.Pow(radius, 2);
            return Math.Round(area, 2);
        }

        // Method - calculate volume of spher
        public double GetSphereVolume(double radius)
        {
            double volume = (4 * Pi) * Math.Pow(radius, 3) / 3;
            return Math.Round(volume, 2);
        }


    }
}