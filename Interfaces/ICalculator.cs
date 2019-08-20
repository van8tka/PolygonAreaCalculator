using System.Collections.Generic;
using System.Drawing;

namespace PolygonAreaCalculator.Interfaces
{
    public interface ICalculator
    {
        /// <summary>
        /// расчет площади многоугольника
        /// </summary>
        /// <param name="points">точки вершин многоугольника</param>
        /// <returns>площадь многоугольника</returns>
        double CalculateArea(List<Point> points);
    }
}
