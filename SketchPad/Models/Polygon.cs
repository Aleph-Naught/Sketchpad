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

        public void draw(System.Drawing.Graphics g, System.Drawing.Pen p)
        {
            Pen i = new Pen(color, penWidth);

            if(points.Count > 1)
                g.DrawLines(i, points.ToArray());
        }

        public void set(int[] paramaters)
        {
            if(paramaters[0] == -1)
            {
                points.Add(points[0]);
                return;
            }

            points.Add(new Point(paramaters[0], paramaters[1]));
        }

        public Shape clone()
        {
            Shape clone = new Polygon(points, color, penWidth);
            return clone;
        }
    }
}
