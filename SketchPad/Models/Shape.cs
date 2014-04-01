using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SketchPad.Models
{
    abstract class Shape
    {
        public Color color = Color.Black;

        public int penWidth = 5; 

        public abstract void draw(Graphics g, Pen p);

        public abstract void set(int[] paramaters);

        public abstract void move(Point mouse);

        public abstract Shape clone();

        public abstract bool clicked(Point p);

        public abstract void setColor(Color color);

        public abstract Point getPos();
        
    }
}
