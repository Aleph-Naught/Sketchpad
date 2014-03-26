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
            _controller = new Controllers.SketchPadController();
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

        private void splitContainer1_Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            _controller.mouseDown(sender, e);
        }

        private void splitContainer1_Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            _controller.mouseUp(sender, e);
        }

        private void splitContainer1_Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            _controller.mouseMove(sender, e);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            _controller.clearBtn_Click(sender, e);
        }
    }
}
