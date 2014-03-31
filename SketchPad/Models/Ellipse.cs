using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SketchPad.Models
{
    class Ellipse : Shape
    {
        int x;
        int y;
        int width;
        int height;

        public Shape clone()
        {
            Shape clone = new Ellipse(x, y, width, height);
            return clone;
        }

        public Ellipse()
        {
            x = y = width = height = 0;
        }

        public Ellipse(int init_x, int init_y, int _x, int _y)
        {
            x = init_x;
            y = init_y;
            width = _x;
            height = _y;
        }

        public void draw(Graphics g, System.Drawing.Pen p)
        {
            g.DrawEllipse(p, new System.Drawing.Rectangle(x, y, width, height));
        }

        public void set(int[] paramaters)
        {
            x = paramaters[0];
            y = paramaters[1];
            width = paramaters[2] - x;
            height = paramaters[3] - y;
        }
    }
}
