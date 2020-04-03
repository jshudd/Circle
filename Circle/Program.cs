using System;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            var pi = 3.14;
            var radius = 0;

            Console.WriteLine("Input Circle Radius");
            radius = Convert.ToInt32(Console.ReadLine());

            var area = pi * (radius ^ 2);

            //$ gives string interpolation

            Console.WriteLine($"The area of the circle is {area}");
        }
    }
}
