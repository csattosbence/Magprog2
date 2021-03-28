using System;

namespace TriangleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            coordinate x = new coordinate(0,0);
            coordinate y = new coordinate(3,0);
            coordinate z = new coordinate(0, 3);

            Triangle haromszog = new Triangle(x,y,z);

            haromszog.ShowInfo();
            
        }
    }
}
