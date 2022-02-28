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
            if (SideA < 1 || SideB < 1)
                throw new RectangleSideIsNullOrZero("Nulla oldalú téglalapot nem lehet létrehozni!");

            this.a = SideA;
            this.b = SideB;
            
        }

        public double SideA {
            set
            {
                if (value < 1)
                    throw new RectangleSideIsNullOrZero("Nulla oldalú téglalapot nem lehet létrehozni!");
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
                if (value < 1)
                    throw new RectangleSideIsNullOrZero("Nulla oldalú téglalapot nem lehet létrehozni!");
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
