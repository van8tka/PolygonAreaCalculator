using PolygonAreaCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace PolygonAreaCalculator.Implementations
{
    public class Calculator : ICalculator
    {
        public double CalculateArea(List<Point> points)
        {
            try
            {
                double area = 0, perimeter, a, b, c;
                var point1 = points[0];
                var point2 = points[1];
                for (int i = 2; i < points.Count; i++)
                {
                    var point3 = points[i];
                    a = Math.Sqrt(Math.Pow((point3.X - point2.X), 2) + Math.Pow((point3.Y - point2.Y), 2));
                    b = Math.Sqrt(Math.Pow((point3.X - point1.X), 2) + Math.Pow((point3.Y - point1.Y), 2));
                    c = Math.Sqrt(Math.Pow((point2.X - point1.X), 2) + Math.Pow((point2.Y - point1.Y), 2));
                    perimeter = (a + b + c) / 2;
                    area += Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
                    point2 = points[i];
                }
                return area;
            }  
            catch(Exception e)
            {
                throw;
            }                          
        }
    }
}
