namespace Circle
{
    class Triangle
    {
        // Properties
        public double Base { get; set; }
        public double Height { get; set; }

        // Constructor
        public Triangle(double triangleBase, double triangleHeight)
        {
            Base = triangleBase;
            Height = triangleHeight;
        }
<<<<<<< HEAD

        // Method - calculate area of triangle
=======
        //METHOD - Calculate area of triangle
>>>>>>> 66cfc823ae47c67c50e851039d81b65904b51153
        public double GetArea(double tBase, double tHeight)
        {
            return tBase * tHeight / 2;
        }
<<<<<<< HEAD

        // Method - calculate circumference of a right triangle
=======
        //METHOD - Calculate the circumference 
>>>>>>> 66cfc823ae47c67c50e851039d81b65904b51153
        public double GetCircumference(double tBase, double tHeight)
        {
            double hypotenuse = 0;
            hypotenuse = Math.Sqrt(Math.Pow(tBase, 2) + Math.Pow(tHeight, 2));
            double circumference = hypotenuse + tBase + tHeight;
            return Math.Round(circumference, 2);
        }

    }
}