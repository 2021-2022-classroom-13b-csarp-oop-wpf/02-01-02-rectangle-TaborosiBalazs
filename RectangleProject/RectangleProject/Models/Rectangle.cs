using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleProject.Models
{
    public class Rectangle
    {
        private double a;
        private double b;

        public Rectangle(double SideA, double SideB)
        {
            this.a = SideA;
            this.b = SideB;
        }

        public double SideA {
            set
            {
                a = value;
            }
            get
            {
                return a;
            }
        }
        public double SideB
        {
            set
            {
                b = value;
            }
            get
            {
                return b;
            }
        }

        public double Area { get => a * b; }
        public double Perimeter { get => 2 * (a + b); }

        public override string ToString()
        {
            return $"Az a oldal {a}, a b oldal {b}, a téglalat kerülete: {Math.Round(Perimeter,2)}, területe: {Math.Round(Area, 2)}";
        }
    }
}
