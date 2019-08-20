using System.Collections.Generic;
using System.Drawing;

namespace PolygonAreaCalculator.Interfaces
{
    public interface IConvexPolygonConverter
    {
        /// <summary>
        /// метод преобразования набора точек в выпуклый многоугольник(алгоритм Джарвиса) 
        /// </summary>
        /// <param name="points">входящие точки</param>
        /// <returns>координаты точек выпуклого многоугольника</returns>
        IList<Point> СreatingHullСonvexPolygon(IList<Point> points);
    }
}
