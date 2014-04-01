﻿using System;
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

        Point topLeft;
        Point topRight;
   

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

            for (int i = 0; i < points.Count; i++)
            {
                points[i] = new PointF(this.points[i].X - dx, this.points[i].Y - dy);
            }
        }
        public override Point getPos()
        {
            return new Point((int)points[0].X,(int)points[0].Y);
        }
    }
}
