using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SketchPad.Models
{
    class Line : Shape
    {

        List<Point> points;

        public Shape clone()
        {
            Shape clone = new Line(points[0], points[1]);
            return clone;
        }

        public Line(Point p1, Point p2)
        {
            points = new List<Point>();
            points.Add(p1);
            points.Add(p2);
        }

        public Line()
        {
            points = new List<Point>();
            points.Add(new Point(0, 0));
            points.Add(new Point(0, 0));
        }

        public Line(int init_x, int init_y, int x, int y)
        {
            points = new List<Point>();
            points.Add(new Point(init_x, init_y));
            points.Add(new Point(x, y));
        }

        public void draw(Graphics g, Pen p)
        {
            g.DrawLine(p, points[0], points[1]);
           
        }

        public void set(int[] paramaters)
        {
            points[0] = new Point(paramaters[0], paramaters[1]);
            points[1] = new Point(paramaters[2], paramaters[3]);
        }
    }
}
