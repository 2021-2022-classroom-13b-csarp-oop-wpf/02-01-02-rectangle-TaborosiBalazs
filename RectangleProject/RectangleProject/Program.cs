using System;
using RectangleProject.Models;

namespace RectangleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(2.3, 1.4);
            Rectangle r2 = new Rectangle(5.6, 2.1);

            if (r1.Area > r2.Area)
            {
                Console.WriteLine($"az első a nagyobb! kerülete: {r1.Perimeter}");
            }else if(r1.Area < r2.Area)
            {
                Console.WriteLine($"a második a nagyobb! kerülete: {r2.Perimeter}");
            }else
            {
                Console.WriteLine($"Egyenlőek! kerületük: {r2.Perimeter}");
            }
        }
    }
}
