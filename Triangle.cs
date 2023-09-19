namespace Circle
{
    class Triangle //private class Triangle
    {
        public double Base { get; set; } //Properties
        public double Height { get; set; }

        public Triangle(double triangleBase, double triangleHeight) // Constructor (since base is a keyword i named it a little bit different)
        {
            Base = triangleBase;
            Height = triangleHeight;
        }

        public double GetArea(double tBase, double tHeight)  //Method - calculate area of triangle
        {
            return tBase * tHeight / 2;
        }

        public double GetCircumference(double tBase, double tHeight)
        {
            double hypotenuse = 0;
            hypotenuse = Math.Sqrt(Math.Pow(tBase, 2) + Math.Pow(tHeight, 2));
            double circumference = hypotenuse + tBase + tHeight;
            return Math.Round(circumference, 2);
        }

    }
}