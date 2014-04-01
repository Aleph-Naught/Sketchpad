namespace SketchPad
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.clearBtn = new System.Windows.Forms.Button();
            this.colourBtn = new System.Windows.Forms.Button();
            this.shapeGroupBox = new System.Windows.Forms.GroupBox();
            this.freeHandBtn = new System.Windows.Forms.Button();
            this.polygonBtn = new System.Windows.Forms.Button();
            this.lineBtn = new System.Windows.Forms.Button();
            this.circleBtn = new System.Windows.Forms.Button();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.squareBtn = new System.Windows.Forms.Button();
            this.ellipseBtn = new System.Windows.Forms.Button();
            this.canvas1 = new System.Windows.Forms.PictureBox();
            this.colourDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.shapeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.clearBtn);
            this.splitContainer1.Panel1.Controls.Add(this.colourBtn);
            this.splitContainer1.Panel1.Controls.Add(this.shapeGroupBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.canvas1);
            this.splitContainer1.Size = new System.Drawing.Size(768, 495);
            this.splitContainer1.SplitterDistance = 125;
            this.splitContainer1.TabIndex = 0;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(21, 299);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // colourBtn
            // 
            this.colourBtn.Location = new System.Drawing.Point(21, 269);
            this.colourBtn.Name = "colourBtn";
            this.colourBtn.Size = new System.Drawing.Size(75, 23);
            this.colourBtn.TabIndex = 7;
            this.colourBtn.Text = "Colour";
            this.colourBtn.UseVisualStyleBackColor = true;
            this.colourBtn.Click += new System.EventHandler(this.colourBtn_Click);
            // 
            // shapeGroupBox
            // 
            this.shapeGroupBox.Controls.Add(this.freeHandBtn);
            this.shapeGroupBox.Controls.Add(this.polygonBtn);
            this.shapeGroupBox.Controls.Add(this.lineBtn);
            this.shapeGroupBox.Controls.Add(this.circleBtn);
            this.shapeGroupBox.Controls.Add(this.rectangleButton);
            this.shapeGroupBox.Controls.Add(this.squareBtn);
            this.shapeGroupBox.Controls.Add(this.ellipseBtn);
            this.shapeGroupBox.Location = new System.Drawing.Point(3, 11);
            this.shapeGroupBox.Name = "shapeGroupBox";
            this.shapeGroupBox.Size = new System.Drawing.Size(119, 238);
            this.shapeGroupBox.TabIndex = 8;
            this.shapeGroupBox.TabStop = false;
            this.shapeGroupBox.Text = "Shapes";
            // 
            // freeHandBtn
            // 
            this.freeHandBtn.Location = new System.Drawing.Point(18, 19);
            this.freeHandBtn.Name = "freeHandBtn";
            this.freeHandBtn.Size = new System.Drawing.Size(75, 23);
            this.freeHandBtn.TabIndex = 0;
            this.freeHandBtn.Text = "Free Hand";
            this.freeHandBtn.UseVisualStyleBackColor = true;
            this.freeHandBtn.Click += new System.EventHandler(this.shapeBtn_Click);
            // 
            // polygonBtn
            // 
            this.polygonBtn.Location = new System.Drawing.Point(18, 193);
            this.polygonBtn.Name = "polygonBtn";
            this.polygonBtn.Size = new System.Drawing.Size(75, 23);
            this.polygonBtn.TabIndex = 6;
            this.polygonBtn.Text = "Polygon";
            this.polygonBtn.UseVisualStyleBackColor = true;
            this.polygonBtn.Click += new System.EventHandler(this.shapeBtn_Click);
            // 
            // lineBtn
            // 
            this.lineBtn.Location = new System.Drawing.Point(18, 48);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(75, 23);
            this.lineBtn.TabIndex = 1;
            this.lineBtn.Text = "Line";
            this.lineBtn.UseVisualStyleBackColor = true;
            this.lineBtn.Click += new System.EventHandler(this.shapeBtn_Click);
            // 
            // circleBtn
            // 
            this.circleBtn.Location = new System.Drawing.Point(18, 164);
            this.circleBtn.Name = "circleBtn";
            this.circleBtn.Size = new System.Drawing.Size(75, 23);
            this.circleBtn.TabIndex = 5;
            this.circleBtn.Text = "Circle";
            this.circleBtn.UseVisualStyleBackColor = true;
            this.circleBtn.Click += new System.EventHandler(this.shapeBtn_Click);
            // 
            // rectangleButton
            // 
            this.rectangleButton.Location = new System.Drawing.Point(18, 77);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(75, 23);
            this.rectangleButton.TabIndex = 2;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.shapeBtn_Click);
            // 
            // squareBtn
            // 
            this.squareBtn.Location = new System.Drawing.Point(18, 135);
            this.squareBtn.Name = "squareBtn";
            this.squareBtn.Size = new System.Drawing.Size(75, 23);
            this.squareBtn.TabIndex = 4;
            this.squareBtn.Text = "Square";
            this.squareBtn.UseVisualStyleBackColor = true;
            this.squareBtn.Click += new System.EventHandler(this.shapeBtn_Click);
            // 
            // ellipseBtn
            // 
            this.ellipseBtn.Location = new System.Drawing.Point(18, 106);
            this.ellipseBtn.Name = "ellipseBtn";
            this.ellipseBtn.Size = new System.Drawing.Size(75, 23);
            this.ellipseBtn.TabIndex = 3;
            this.ellipseBtn.Text = "Ellipse";
            this.ellipseBtn.UseVisualStyleBackColor = true;
            this.ellipseBtn.Click += new System.EventHandler(this.shapeBtn_Click);
            // 
            // canvas1
            // 
            this.canvas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas1.Location = new System.Drawing.Point(0, 0);
            this.canvas1.Name = "canvas1";
            this.canvas1.Size = new System.Drawing.Size(639, 495);
            this.canvas1.TabIndex = 0;
            this.canvas1.TabStop = false;
            this.canvas1.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas1_Paint);
            this.canvas1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas1_MouseDown);
            this.canvas1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas1_MouseMove);
            this.canvas1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas1_MouseUp);
            // 
            // colourDialog
            // 
            this.colourDialog.AllowFullOpen = false;
            this.colourDialog.SolidColorOnly = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(768, 495);
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.Name = "mainForm";
            this.Text = "SketchPad";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.shapeGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button polygonBtn;
        private System.Windows.Forms.Button circleBtn;
        private System.Windows.Forms.Button squareBtn;
        private System.Windows.Forms.Button ellipseBtn;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Button lineBtn;
        private System.Windows.Forms.Button freeHandBtn;
        private System.Windows.Forms.ColorDialog colourDialog;
        private System.Windows.Forms.Button colourBtn;
        private System.Windows.Forms.GroupBox shapeGroupBox;
        private System.Windows.Forms.Button clearBtn;
        public System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.PictureBox canvas1;
    }
}

