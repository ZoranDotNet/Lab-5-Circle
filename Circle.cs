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

        public double GetArea(int radius)  //method - calculate area of circle
        {
            double area = Math.Pow(radius, 2) * Pi;
            return Math.Round(area, 2);         // return area rounded to 2 decimals
        }

        public double GetCircumference(int radius) //method - calculate circumference of circle
        {
            double circumference = radius * 2 * Pi;
            return Math.Round(circumference, 2);  //return circumference rounded to 2 decimals
        }
        public double GetSphereArea(int radius)  // method - calculate area of sphere
        {
            double area = 4 * Pi * Math.Pow(radius, 2);
            return Math.Round(area, 2); // return area rounded to 2 decimals
        }
        public double GetSphereVolume(double radius)  // method - calculate volume of spher
        {
            double volume = (4 * Pi) * Math.Pow(radius, 3) / 3;
            return Math.Round(volume, 2);  //return volume rounded to 2 decimals
        }


    }
}