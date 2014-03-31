using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SketchPad.Models
{
    interface Shape
    {

        void draw(Graphics g, Pen p);

        void set(int[] paramaters);

        Shape clone();
        
    }
}
