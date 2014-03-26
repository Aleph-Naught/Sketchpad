using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SketchPad.Models
{
    class SketchPadState
    {
        public string _selected_shape { get; set; }
        public Color _selected_colour { get; set; }
        public Boolean _isMouseDown { get; set; }
        private List<Graphics> _shapes;
        private Pen pen;
        private float width = 5;

        public SketchPadState()
        {
            _selected_shape = "Free Hand";
            _selected_colour = Color.Black;
            _isMouseDown = false;
            _shapes = new List<Graphics>();
        }

        public void addShape(Graphics g)
        {
            _shapes.Add(g);
        }

        public List<Graphics> getShapes()
        {
            return _shapes;
        }

        public void clearShapes()
        {
            _shapes.Clear();
        }

        public Pen getPen()
        {
            return new Pen(_selected_colour, width);
        }
    }
}
