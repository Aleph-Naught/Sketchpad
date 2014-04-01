using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SketchPad.Models
{
    class Line : Brush, Shape
    {

        List<Point> points;

        public Shape clone()
        {
            Shape clone = new Line(points[0], points[1], color, penWidth);
            return clone;
        }

        public Line(Point p1, Point p2, Color c, int w)
        {
            points = new List<Point>();
            points.Add(p1);
            points.Add(p2);
            color = c;
            penWidth = w;
        }

        public Line(Color c, int w)
        {
            points = new List<Point>();
            points.Add(new Point(0, 0));
            points.Add(new Point(0, 0));

            color = c;
            penWidth = w;
        }

        public Line(int init_x, int init_y, int x, int y)
        {
            points = new List<Point>();
            points.Add(new Point(init_x, init_y));
            points.Add(new Point(x, y));
        }

        public void draw(Graphics g, Pen p)
        {
            Pen i = new Pen(color, penWidth);
            g.DrawLine(i, points[0], points[1]);
           
        }

        public void set(int[] paramaters)
        {
            points[0] = new Point(paramaters[0], paramaters[1]);
            points[1] = new Point(paramaters[2], paramaters[3]);
        }

        public bool clicked(Point p)
        {
            return false;
        }

        public void setColor(Color c)
        {
            color = c;
        }
    }
}
