using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SketchPad.Models
{
    class Square : Shape
    {   

        int x;
        int y;
        int width;
        int height;

        override public Shape clone()
        {
            Shape clone = new Square(x, y, width, height, color, penWidth);
            return clone;
        }

        public Square(Color c, int w)
        {
            x = y = width = height = 0;

            color = c;
            penWidth = w;
        }

        public Square(int init_x, int init_y, int _x, int _y, Color c, int w)
        {
            x = init_x;
            y = init_y;
            width = _x;
            height = _x;
            color = c;
            penWidth = w;

            area = new System.Drawing.Rectangle(new Point(x, y), new Size(width, height));
        }

        override public void draw(Graphics g, System.Drawing.Pen p)
        {
            Pen i = new Pen(color, penWidth);

            g.DrawRectangle(i, new System.Drawing.Rectangle(x, y, width, height));
        }

        override public void set(int[] paramaters)
        {
            x = paramaters[0];
            y = paramaters[1];
            width = paramaters[2] - x;
            height = width;
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
            this.x = mouse.X;
            this.y = mouse.Y;
        }

        public override Point getPos()
        {
            throw new NotImplementedException();
        }
    }
}
