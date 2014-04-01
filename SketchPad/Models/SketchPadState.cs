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
        private List<Shape> _shapes;
        private Pen pen;
        private float width = 5;

        public SketchPadState()
        {
            _selected_shape = "Free Hand";
            _selected_colour = Color.Black;
            _isMouseDown = false;
            _shapes = new List<Shape>();
        }

        public void addShape(Shape g)
        {
            _shapes.Add(g);
        }

        public List<Shape> getShapes()
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

        public void removeShape(Shape s)
        {
            foreach (Shape el in _shapes)
            {
                if (s.Equals(el))
                {
                    _shapes.Remove(el);
                    return;
                }
            }
        }
    }
}
