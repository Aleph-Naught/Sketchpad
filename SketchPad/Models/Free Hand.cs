using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SketchPad.Models
{
    class Free_Hand : Brush, Shape
    {

        List<PointF> points;
   

        public Free_Hand(Color c, int w)
        {
            points = new List<PointF>();
            color = c;
            penWidth = w;
        }

        public Free_Hand(List<PointF> p, Color c, int w)
        {
            points = p;
            color = c;
            penWidth = w;
        }

        public void draw(System.Drawing.Graphics g, System.Drawing.Pen p)
        {
            Pen i = new Pen(color, penWidth);
            if(points.Count > 1)
                g.DrawCurve(i, points.ToArray());
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
