using PolygonAreaCalculator.Interfaces;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace PolygonAreaCalculator.Implementations
{
    public class ConvexPolygonConverter : IConvexPolygonConverter
    {
        public IList<Point> СreatingHullСonvexPolygon(IList<Point> points)       
        {
            var hullPoints = new List<Point>();
            var peakOnHull = points.Where(p => p.X == points.Min(min => min.X)).First();
            Point lastPoint;
            do
            {
                hullPoints.Add(peakOnHull);
                lastPoint = points[0];
                for (int i = 1; i < points.Count; i++)
                {
                    if ((peakOnHull == lastPoint) || (GetOrientation(peakOnHull, lastPoint, points[i]) == -1))                   
                        lastPoint = points[i];
                }
                peakOnHull = lastPoint;
            }
            while (lastPoint != hullPoints[0]);
            return hullPoints;
        }

        private int GetOrientation(Point p1, Point p2, Point p)
        {
            int orientation = (p2.X - p1.X) * (p.Y - p1.Y) - (p.X - p1.X) * (p2.Y - p1.Y);
            if (orientation > 0)
                return -1; // левая
            if (orientation < 0)
                return 1; //правая
            return 0; // нейтральная
        }
    }
}
