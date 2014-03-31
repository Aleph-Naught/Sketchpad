using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using SketchPad.Models;
using System.Reflection;

namespace SketchPad.Controllers
{
    class SketchPadController
    {
        private static mainForm _sketchpad;
        private SketchPad.Models.SketchPadState _state;

        private Graphics _current_shape;

        private Shape current_shape;

        private int init_x, init_y;

        public SketchPadController(mainForm form)
        {
            _sketchpad = form;
            _state = new Models.SketchPadState();

            _current_shape = _sketchpad.canvas1.CreateGraphics();

            current_shape = new Line();

        }

        public void shapeBtn_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;

            _state._selected_shape = clickedBtn.Text;

            
            String typeName = clickedBtn.Text;

            typeName = typeName.Replace(' ', '_');


            var assembly = Assembly.GetExecutingAssembly();

            var type = assembly.GetTypes()
                .First(t => t.Name == typeName);

            current_shape = (Shape)Activator.CreateInstance(type);

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
            _sketchpad.canvas1.Invalidate();
            _state.clearShapes();
        }

        public void mouseDown(object sender, MouseEventArgs e)
        {

            var assembly = Assembly.GetExecutingAssembly();

            var type = current_shape.GetType();

            current_shape = (Shape)Activator.CreateInstance(type);

            _state._isMouseDown = true;
            init_x = e.X;
            init_y = e.Y;
        }

        public void mouseUp(object sender, MouseEventArgs e)
        {
            Shape shape = current_shape.clone();
            _state._isMouseDown = false;
            _state.addShape(shape);
        }

        public void mouseMove(object sender, MouseEventArgs e)
        {
            if (_state._isMouseDown)
            {
                _sketchpad.canvas1.Refresh();

                current_shape.set(new int[]{init_x, init_y, e.X, e.Y});

                current_shape.draw(_sketchpad.canvas1.CreateGraphics(), _state.getPen());
            }
        }

        public void drawShape(int x1, int y1, int x2, int y2)
        {
            if (_state._selected_shape == "Free Hand")
            {
                
            }
            else if (_state._selected_shape == "Line")
            {
                _current_shape.DrawLine(_state.getPen(), x1, y1, x2, y2);
            }
            else if (_state._selected_shape == "Rectangle")
            {
                _current_shape = _sketchpad.canvas1.CreateGraphics();
                _current_shape.DrawRectangle(_state.getPen(), x1, y1, x2-x1, y2-y1);
            }
            else if (_state._selected_shape == "Ellipse")
            {
                _current_shape = _sketchpad.canvas1.CreateGraphics();
                _current_shape.DrawEllipse(_state.getPen(), x2, y2, x1 - x2, y2 - y1);
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

        public void paint(object sender, PaintEventArgs e)
        {
            foreach(var graphic in _state.getShapes())
            {
                graphic.draw(e.Graphics, _state.getPen());
            }

        }
    }
}
