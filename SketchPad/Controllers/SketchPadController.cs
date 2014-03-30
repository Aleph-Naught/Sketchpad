using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SketchPad.Controllers
{
    class SketchPadController
    {
        private static mainForm _sketchpad;
        private SketchPad.Models.SketchPadState _state;

        private Graphics _current_shape;
        private int init_x, init_y;

        public SketchPadController()
        {
            _state = new Models.SketchPadState();
        }

        public void shapeBtn_Click(object sender, EventArgs e)
        {
            _sketchpad = (mainForm)((Button)sender).FindForm();
            Button clickedBtn = (Button)sender;

            _state._selected_shape = clickedBtn.Text;
        }

        public void colourBtn_Click(object sender, EventArgs e)
        {
            _sketchpad = (mainForm)((Button)sender).FindForm();

            ColorDialog  colourDialog = _sketchpad.getColourDialog();
            colourDialog.Color = _state._selected_colour;

            if (colourDialog.ShowDialog() == DialogResult.OK)
            {
                _state._selected_colour = colourDialog.Color;
            }
        }

        public void clearBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _sketchpad.splitContainer1.Panel2.Invalidate();
                _state.clearShapes();
            }
            catch
            {

            }
        }

        public void mouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                _state._isMouseDown = true;
                init_x = e.X;
                init_y = e.Y;
                this.drawShape(e.X, e.Y, e.X, e.Y);
            }
            catch
            {

            }
        }

        public void mouseUp(object sender, MouseEventArgs e)
        {

            try
            {
                _state._isMouseDown = false;
                clearShape();
                this.drawShape(init_x, init_y, e.X, e.Y);
                _state.addShape(_current_shape);
                _current_shape = null;
            }
            catch
            {

            }
        }

        public void mouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (_state._isMouseDown)
                {
                    clearShape();
                    this.drawShape(init_x, init_y, e.X, e.Y);
                }
            }
            catch
            {

            }
        }

        public void drawShape(int x1, int y1, int x2, int y2)
        {
            if (_state._selected_shape == "Free Hand")
            {

            }
            else if (_state._selected_shape == "Line")
            {
                _current_shape = _sketchpad.splitContainer1.Panel2.CreateGraphics();
                _current_shape.DrawLine(_state.getPen(), x1, y1, x2, y2);
            }
            else if (_state._selected_shape == "Rectangle")
            {
                _current_shape = _sketchpad.splitContainer1.Panel2.CreateGraphics();
                _current_shape.DrawRectangle(_state.getPen(), x1, y1, Math.Abs(x2-x1), Math.Abs(y2-y1));
            }
            else if (_state._selected_shape == "Ellipse")
            {

            }
            else if (_state._selected_shape == "Square")
            {

            }
            else if (_state._selected_shape == "Circle")
            {

            }
            else if (_state._selected_shape == "Polygon")
            {

            }
        }

        public void clearShape()
        {
            //probably a bad way to clear the obj
            _current_shape.Clear(Color.White);
        }
    }
}
