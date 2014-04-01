using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SketchPad
{
    public partial class mainForm : Form
    {
        private SketchPad.Controllers.SketchPadController _controller;

        public mainForm()
        {
            InitializeComponent();
            _controller = new Controllers.SketchPadController(this);

            selectedShapeLabel.Text = "Double Click to Copy";
        }

        public ColorDialog getColourDialog()
        {
            return this.colourDialog;
        }

        private void shapeBtn_Click(object sender, EventArgs e)
        {
            _controller.shapeBtn_Click(sender, e);
        }

        private void colourBtn_Click(object sender, EventArgs e)
        {
            _controller.colourBtn_Click(sender, e);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            _controller.clearBtn_Click(sender, e);
        }

        private void canvas1_MouseDown(object sender, MouseEventArgs e)
        {
            _controller.mouseDown(sender, e);
        }

        private void canvas1_MouseUp(object sender, MouseEventArgs e)
        {
            _controller.mouseUp(sender, e);
        }

        private void canvas1_MouseMove(object sender, MouseEventArgs e)
        {
            _controller.mouseMove(sender, e);
        }

        private void canvas1_Paint(object sender, PaintEventArgs e)
        {
            _controller.paint(sender, e);
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            _controller.selectBtn();
        }

        private void selCheck_CheckedChanged(object sender, EventArgs e)
        {
            _controller.selectBtn();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _controller.selectBtn();
        }

        private void mainForm_ResizeEnd(object sender, EventArgs e)
        {
            _controller.reSize();
        }


    }


}
