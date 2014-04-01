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
            points = new List<PointF>(p);
            color = c;
            penWidth = w;
            calculateArea();
        }

        public void calculateArea()
        {
            float xMin = 0;
            float xMax = 0;
            float yMin = 0 ;
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
            area = new System.Drawing.Rectangle((int)xMin,(int)yMin,(int)(xMax-xMin),(int)(yMax-yMin));
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

            points.Add(new Point(paramaters[0], paramaters[1]));
        }

        override public Shape clone()
        {
            Shape clone = new Polygon(points, color, penWidth);
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
             float dx = points[0].X - mouse.X,
                   dy = points[0].Y - mouse.Y;

             for (int i = 0; i < points.Count;i++ )
             {
                 points[i] = new PointF(this.points[i].X - dx, this.points[i].Y - dy);
             }

         }
         public override Point getPos()
         {
             return new Point((int)points[0].X, (int)points[0].Y);
         }

    }
}
