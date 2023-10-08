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


        // Method - calculate area of triangle

        //METHOD - Calculate area of triangle

        public double GetArea(double tBase, double tHeight)
        {
            return tBase * tHeight / 2;
        }


        // Method - calculate circumference of a right triangle
        public double GetCircumference(double tBase, double tHeight)
        {
            double hypotenuse = 0;
            hypotenuse = Math.Sqrt(Math.Pow(tBase, 2) + Math.Pow(tHeight, 2));
            double circumference = hypotenuse + tBase + tHeight;
            return Math.Round(circumference, 2);
        }

    }
}