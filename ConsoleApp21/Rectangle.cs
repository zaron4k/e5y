﻿using System;

namespace ConsoleApp21
{
    class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double Method1() // Площадь
        {
            return side1 * side2;
        }

        public double Method2() // Периметр
        {
            return 2 * (side1 + side2);
        }
    }
}