using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PolygonAreaCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private List<Point> _points;



        private void OnPaint(object sender, PaintEventArgs e)
        {

            if (_points != null)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                if (_points.Count < 3)
                {
                    foreach (var point in _points)
                    {
                        e.Graphics.FillEllipse(Brushes.DarkGreen, point.X - 2, point.Y - 2, 4, 4);
                    }
                }
                else
                {
                    e.Graphics.DrawPolygon(Pens.DarkGreen, _points.ToArray());
                }
            }
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            AddPoint(e.Location);
        }

        private void AddPoint(Point point)
        {
            if (_points == null)
                _points = new List<Point>();
            _points.Add(point);
            listViewPoints.Items.Add($"(" + point.X.ToString() + "; " + point.Y.ToString() + ")");
            pictureBox.Invalidate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDrawingArea();
        }

        private void ClearDrawingArea()
        {
            _points?.Clear();
            pictureBox.Invalidate();
            lblResult.Text = string.Empty;
            listViewPoints.Items.Clear();
        }

        private void btnCalculateArea_Click(object sender, EventArgs e)
        {
            if(_points.Count > 3)
            {
                var hull = СreatingСonvexPolygon(_points);
                ClearDrawingArea();
                foreach (var p in hull)
                    AddPoint(p);
            }
             double area = CalculateArea(_points);
            lblResult.Text = area.ToString("0.00");
        }

        private double CalculateArea(List<Point> points)
        {
            double area=0, perimeter, a,b,c;
            var point1 = points[0];
            var point2 = points[1];
            for(int i=2;i<points.Count;i++)
            {
                var point3 = points[i];
                a = Math.Sqrt(Math.Pow((point3.X - point2.X),2) + Math.Pow((point3.Y - point2.Y),2));
                b = Math.Sqrt(Math.Pow((point3.X - point1.X), 2) + Math.Pow((point3.Y - point1.Y), 2));
                c = Math.Sqrt(Math.Pow((point2.X - point1.X), 2) + Math.Pow((point2.Y - point1.Y), 2));
                perimeter = (a + b + c) / 2;
                area += Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
                point2 = points[i];
            }
            return area;
        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            int x, y;
            if (int.TryParse(txbX.Text, out x) && int.TryParse(txbY.Text, out y))
            {
                AddPoint(new Point(x, y));
            }
            ClearEntryXY();
        }

        private void ClearEntryXY()
        {
            txbX.Text = string.Empty;
            txbY.Text = string.Empty;
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;
            //цифра или BackSpace
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }






        private List<Point> СreatingСonvexPolygon(List<Point> points)
        {
                List<Point> hull = new List<Point>();           
                // get leftmost point
                Point vPointOnHull = points.Where(p => p.X == points.Min(min => min.X)).First();
                Point vEndpoint;
                do
                {
                    hull.Add(vPointOnHull);
                    vEndpoint = points[0];

                    for (int i = 1; i < points.Count; i++)
                    {
                        if ((vPointOnHull == vEndpoint) || (Orientation(vPointOnHull, vEndpoint, points[i]) == -1))
                        {
                            vEndpoint = points[i];
                        }
                    }
                    vPointOnHull = vEndpoint;
                }
                while (vEndpoint != hull[0]);                    
            return hull;
        }

        private int Orientation(Point p1, Point p2, Point p)
        {            
            int Orin = (p2.X - p1.X) * (p.Y - p1.Y) - (p.X - p1.X) * (p2.Y - p1.Y);
            if (Orin > 0)
                return -1; //          (* Orientation is to the left-hand side  *)
            if (Orin < 0)
                return 1; // (* Orientation is to the right-hand side *)
            return 0; //  (* Orientation is neutral aka collinear  *)
        }
    }
}

