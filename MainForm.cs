using PolygonAreaCalculator.Implementations;
using PolygonAreaCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PolygonAreaCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            _calculator = new Calculator();
            _convexPolygonConverter = new ConvexPolygonConverter();
        }

        private readonly IConvexPolygonConverter _convexPolygonConverter;
        private readonly ICalculator _calculator;
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
                var hullPoints = _convexPolygonConverter.СreatingHullСonvexPolygon(_points);
                ClearDrawingArea();
                foreach (var p in hullPoints)
                    AddPoint(p);
            }
             double area = _calculator.CalculateArea(_points);
             lblResult.Text = area.ToString("0.00");
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
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }   
    }
}

