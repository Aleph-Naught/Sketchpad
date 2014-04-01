using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SketchPad.Models
{
    class Polygon : Shape
    {
        List<PointF> points;
   
        public Polygon(Color c, int w)
        {
            points = new List<PointF>();
            color = c;
            penWidth = w;
        }

        public Polygon(List<PointF> p, Color c, int w)
        {
            points = p;
            color = c;
            penWidth = w;
        }

        override public void draw(System.Drawing.Graphics g, System.Drawing.Pen p)
        {
            Pen i = new Pen(color, penWidth);

            if(points.Count > 1)
                g.DrawLines(i, points.ToArray());
        }

        override public void set(int[] paramaters)
        {
            if(paramaters[0] == -1)
            {
                points.Add(points[0]);
                return;
            }
        }

        override public Shape clone()
        {
            Shape clone = new Polygon(points, color, penWidth);
            return clone;
        }

        override public bool clicked(Point p)
        {
            return false;
        }

         override public void setColor(Color c)
        {
            color = c;
        }
    }
}
