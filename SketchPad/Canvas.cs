using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SketchPad
{
    public class Canvas : Panel
    {
        public Canvas() 
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
        }

    }
}
