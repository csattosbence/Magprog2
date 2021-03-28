using System;
namespace TriangleProject
{
    public enum TriangleType
    {
        EGYENLOSZARU,
        SZABALYOS,
        NEMMEGHATAROZOTT
    }
    public class coordinate
    {
        private int x;
        private int y;

        public coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int Y { get => y; set => y = value; }
        public int X { get => x; set => x = value; }


    }
    public class Triangle
    {
        

        private coordinate a;
        private coordinate b;
        private coordinate c;
        private double ac;
        private double ab;
        private double cb;
        private double triangleArea;
        private double trianlePerimeter;
        private TriangleType triangleType;
        
        

        

        public double TriangleSection(coordinate a, coordinate b)
        {
            double lenght;
            return lenght = Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }
        public double TrianglePerimeter(double a, double b, double c)
        {
            return a + b + c;
        }
        public double TriangleArea(double a, double b, double c)
        {
            double s = TrianglePerimeter(a, b, c);
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
        public TriangleType TriangleTypeDetermin(double a, double b, double c)
        {


            if (a == b && b == c && c == a)
            {
                return TriangleType.SZABALYOS;
            }

            if (a == b || a == c || b == c)
            {
                return TriangleType.EGYENLOSZARU;
            }
            else return TriangleType.NEMMEGHATAROZOTT;
        }
        public void ShowInfo()
        {
            Console.WriteLine("A háromszög oldalainak hossza: a = {0}, b = {1}, c = {2} \n" +
                "A háromszög Kerülete: {3} \n" +
                "A háromszög Területe: {4} \n" +
                "A háromszög Típusa:{5}",Ab,Ac,Cb,GetTrianglePerimeter,GetTriangleArea,TriangleType
                
                );
        }
        


        public Triangle(coordinate coordinateA,coordinate coordinateB, coordinate coordinateC)
        {
            this.a = coordinateA;
            this.b = coordinateB;
            this.c = coordinateC;
            this.Ab = TriangleSection(this.a, this.b);
            this.Ac = TriangleSection(this.a, this.c);
            this.Cb = TriangleSection(this.c, this.b);
            this.GetTrianglePerimeter = TrianglePerimeter(Ab, Ac, Cb);
            this.GetTriangleArea = TriangleArea(this.Ab, this.Ac, this.Cb);
            this.TriangleType = TriangleTypeDetermin(this.Ab, this.Ac, this.Cb);
        }

        public double Ac { get => ac; set => ac = value; }
        public double Ab { get => ab; set => ab = value; }
        public double Cb { get => cb; set => cb = value; }
        public double GetTriangleArea { get => triangleArea; set => triangleArea = value; }
        public double GetTrianglePerimeter { get => trianlePerimeter; set => trianlePerimeter = value; }
        public TriangleType TriangleType { get => triangleType; set => triangleType = value; }
    }
}
