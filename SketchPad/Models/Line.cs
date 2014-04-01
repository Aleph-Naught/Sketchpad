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

         override public Shape clone()
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

        override public void draw(Graphics g, Pen p)
        {
            Pen i = new Pen(color, penWidth);
            g.DrawLine(i, points[0], points[1]);
           
        }

        override public void set(int[] paramaters)
        {
            points[0] = new Point(paramaters[0], paramaters[1]);
            points[1] = new Point(paramaters[2], paramaters[3]);
        }

        override public bool clicked(Point p)
        {
            return false;
        }

        override public void setColor(Color c)
        {
            color = c;
        }

        public override void move(Point mouse)
        {
            int dx = points[1].X - points[0].X,
                dy = points[1].Y - points[0].Y;
            points[0] = new Point(mouse.X, mouse.Y);
            points[1] = new Point(mouse.X + dx, mouse.Y + dy);
        }

        public override Point getPos()
        {
            throw new NotImplementedException();
        }

    }
}
