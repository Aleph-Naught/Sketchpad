using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SketchPad.Models
{
    class Free_Hand : Shape
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
            points = new List<PointF>(p);
            color = c;
            penWidth = w;
            calculateArea();
        }
        public void calculateArea()
        {
            float xMin = 0;
            float xMax = 0;
            float yMin = 0;
            float yMax = 0;
            for (int i = 0; i < points.Count; i++)
            {
                if (i == 0)
                {
                    xMin = points[i].X;
                    xMax = xMin;
                    yMin = points[i].Y;
                    yMax = yMin;
                }
                else
                {
                    if (points[i].X < xMin)
                        xMin = points[i].X;
                    if (points[i].X > xMax)
                        xMax = points[i].X;
                    if (points[i].Y < yMin)
                        yMin = points[i].Y;
                    if (points[i].Y > yMax)
                        yMax = points[i].Y;
                }
            }
            area = new System.Drawing.Rectangle((int)xMin, (int)yMin, (int)(xMax - xMin), (int)(yMax - yMin));
        }

        override public void draw(System.Drawing.Graphics g, System.Drawing.Pen p)
        {
            Pen i = new Pen(color, penWidth);
            if(points.Count > 1)
                g.DrawCurve(i, points.ToArray());
        }

        override public void set(int[] paramaters)
        {
            points.Add(new Point(paramaters[2], paramaters[3]));
        }

        override public Shape clone()
        {
            Shape clone = new Free_Hand(points, color, penWidth);
            return clone;
        }

        override public bool clicked(Point p)
        {
            if (area.Contains(p))
                return true;
            else
                return false;
        }

        override public void setColor(Color c)
        {
            color = c;
        }
        public override void move(Point mouse)
        {
        }
        public override Point getPos()
        {
            throw new NotImplementedException();
        }
    }
}
