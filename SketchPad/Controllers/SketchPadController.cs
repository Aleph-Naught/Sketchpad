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

        private bool poly = false;
        private bool polyStart = true;

        Bitmap bm;

        Graphics g;

        public SketchPadController(mainForm form)
        {
            _sketchpad = form;
            _state = new Models.SketchPadState();

            _current_shape = _sketchpad.canvas1.CreateGraphics();

            current_shape = new Line(Color.Black, 5);

            bm = new Bitmap(_sketchpad.Width, _sketchpad.Height);

            _sketchpad.canvas1.Image = bm;

            g = Graphics.FromImage(_sketchpad.canvas1.Image);

        }

        public void shapeBtn_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;

            _state._selected_shape = clickedBtn.Text;

            
            String typeName = clickedBtn.Text;

            if (typeName == "Polygon")
            {
                poly = true;
                polyStart = true;
            }
            else
                poly = false;

            typeName = typeName.Replace(' ', '_');


            var assembly = Assembly.GetExecutingAssembly();

            var type = assembly.GetTypes()
                .First(t => t.Name == typeName);

            current_shape = (Shape)Activator.CreateInstance(type, _state._selected_colour, 5);

        }

        public void colourBtn_Click(object sender, EventArgs e)
        {
            _sketchpad = (mainForm)((Button)sender).FindForm();

            ColorDialog colourDialog = _sketchpad.getColourDialog();
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

            if(polyStart)
            {
                var assembly = Assembly.GetExecutingAssembly();

                var type = current_shape.GetType();

                current_shape = (Shape)Activator.CreateInstance(type, _state._selected_colour, 5);
            }

            if(e.Button == MouseButtons.Middle && poly)
            {
                enterPressed();
                return;
            }

            if(e.Button == MouseButtons.Right && poly)
            {
                current_shape.set(new int[] { e.X, e.Y });

                Shape shape = current_shape.clone();
                _state._isMouseDown = false;
                _state.addShape(shape);

                var assembly = Assembly.GetExecutingAssembly();

                var type = current_shape.GetType();

                current_shape = (Shape)Activator.CreateInstance(type, _state._selected_colour, 5);

                polyStart = true;

                return;
            }


            if (!poly)
            {
                var assembly = Assembly.GetExecutingAssembly();

                var type = current_shape.GetType();

                current_shape = (Shape)Activator.CreateInstance(type, _state._selected_colour, 5);

                _state._isMouseDown = true;
                init_x = e.X;
                init_y = e.Y;
            }
            else
            {
                init_x = e.X;
                init_y = e.Y;

                polyStart = false;

                current_shape.set(new int[]{e.X, e.Y});
                current_shape.draw(g, _state.getPen());
            }
        }

        public void enterPressed()
        {
            if(poly)
            {
                current_shape.set(new int[] { -1, -1 });

                Shape shape = current_shape.clone();
                _state._isMouseDown = false;
                _state.addShape(shape);

                current_shape.draw(g, _state.getPen());

                var assembly = Assembly.GetExecutingAssembly();

                var type = current_shape.GetType();

                current_shape = (Shape)Activator.CreateInstance(type, _state._selected_colour, 5);

                _sketchpad.canvas1.Refresh();

                polyStart = true;

                return;
            }

        }

        public void mouseUp(object sender, MouseEventArgs e)
        {
            if (!poly)
            {
                Shape shape = current_shape.clone();
                _state._isMouseDown = false;
                _state.addShape(shape);
            }
        }

        public void mouseMove(object sender, MouseEventArgs e)
        {
            if (_state._isMouseDown)
            {
                _sketchpad.canvas1.Refresh();

                current_shape.set(new int[]{init_x, init_y, e.X, e.Y});

                current_shape.draw(_sketchpad.canvas1.CreateGraphics(), _state.getPen());
            }
            else if(poly && !polyStart)
            {

                _sketchpad.canvas1.Refresh();

                current_shape.draw(g, _state.getPen());

               _sketchpad.canvas1.CreateGraphics().DrawLine(_state.getPen(), new Point(init_x, init_y), new Point(e.X, e.Y));

            }
        }

        public void paint(object sender, PaintEventArgs e)
        {
            foreach(var graphic in _state.getShapes())
            {
                graphic.draw(g, _state.getPen());
            }

        }
    }
}
