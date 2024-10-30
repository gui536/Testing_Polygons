namespace AulaXUnit
{
    public class Rectangle
    {
        public double[] Sides { get; set; }
        public double Area { get; set; }
        public double Perimeter { get; set; }

        public Rectangle(double a, double b)
        {
            Sides = new double[4];
            Sides[0] = a;
            Sides[1] = a;
            Sides[2] = b;
            Sides[3] = b;
            Array.Sort(Sides);
        }

        public double getArea()
        {
            //Retorna a área de um retângulo.
            return Sides[0] * Sides[3];
        }

        public double getPerimeter()
        {
            return (Sides[0] + Sides[1] + Sides[2] + Sides[3]);
        }
    }

}
