using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SketchPad.Models
{
    class Polygon : Brush, Shape
    {
        List<PointF> points;
   
        public Polygon()
        {
            points = new List<PointF>();
        }

        public Polygon(List<PointF> p, Color c, int w)
        {
            points = p;

            color = c;
            penWidth = w;
        }

        public void draw(System.Drawing.Graphics g, System.Drawing.Pen p)
        {
            if(points.Count > 1)
                g.DrawCurve(p, points.ToArray());
        }

        public void set(int[] paramaters)
        {
            points.Add(new Point(paramaters[2], paramaters[3]));
        }

        public Shape clone()
        {
            Shape clone = new Free_Hand(points, color, penWidth);
            return clone;
        }
    }
}
