namespace Drawing_App
{
    partial class Form1
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
            this.pnlToolBox = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbCoordinates = new System.Windows.Forms.GroupBox();
            this.numToY = new System.Windows.Forms.NumericUpDown();
            this.numToX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numFromY = new System.Windows.Forms.NumericUpDown();
            this.numFromX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxShapes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPen = new System.Windows.Forms.GroupBox();
            this.comboBoxPenStyle = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.numPenSize = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pbDrawBoard = new System.Windows.Forms.PictureBox();
            this.groupBoxLineCap = new System.Windows.Forms.GroupBox();
            this.comboBoxEndCap = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxStartCap = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlToolBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbCoordinates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numToY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numToX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFromY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFromX)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbPen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPenSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawBoard)).BeginInit();
            this.groupBoxLineCap.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolBox
            // 
            this.pnlToolBox.BackColor = System.Drawing.Color.LightGray;
            this.pnlToolBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlToolBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlToolBox.Controls.Add(this.panel1);
            this.pnlToolBox.Controls.Add(this.gbCoordinates);
            this.pnlToolBox.Controls.Add(this.groupBox1);
            this.pnlToolBox.Controls.Add(this.gbPen);
            this.pnlToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBox.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBox.Name = "pnlToolBox";
            this.pnlToolBox.Size = new System.Drawing.Size(1099, 140);
            this.pnlToolBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDraw);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(965, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 138);
            this.panel1.TabIndex = 17;
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDraw.Location = new System.Drawing.Point(13, 17);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(108, 42);
            this.btnDraw.TabIndex = 16;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(13, 65);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 42);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbCoordinates
            // 
            this.gbCoordinates.Controls.Add(this.numToY);
            this.gbCoordinates.Controls.Add(this.numToX);
            this.gbCoordinates.Controls.Add(this.label4);
            this.gbCoordinates.Controls.Add(this.label5);
            this.gbCoordinates.Controls.Add(this.numFromY);
            this.gbCoordinates.Controls.Add(this.numFromX);
            this.gbCoordinates.Controls.Add(this.label3);
            this.gbCoordinates.Controls.Add(this.label2);
            this.gbCoordinates.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbCoordinates.Location = new System.Drawing.Point(517, 0);
            this.gbCoordinates.Name = "gbCoordinates";
            this.gbCoordinates.Size = new System.Drawing.Size(394, 138);
            this.gbCoordinates.TabIndex = 16;
            this.gbCoordinates.TabStop = false;
            this.gbCoordinates.Text = "Coordinates";
            // 
            // numToY
            // 
            this.numToY.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.numToY.Location = new System.Drawing.Point(272, 53);
            this.numToY.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numToY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numToY.Name = "numToY";
            this.numToY.Size = new System.Drawing.Size(120, 28);
            this.numToY.TabIndex = 17;
            this.numToY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numToY.ValueChanged += new System.EventHandler(this.numToY_ValueChanged);
            // 
            // numToX
            // 
            this.numToX.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.numToX.Location = new System.Drawing.Point(272, 20);
            this.numToX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numToX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numToX.Name = "numToX";
            this.numToX.Size = new System.Drawing.Size(120, 28);
            this.numToX.TabIndex = 16;
            this.numToX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numToX.ValueChanged += new System.EventHandler(this.numToX_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(218, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "To (y)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(218, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "To (x)";
            // 
            // numFromY
            // 
            this.numFromY.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.numFromY.Location = new System.Drawing.Point(92, 53);
            this.numFromY.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numFromY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFromY.Name = "numFromY";
            this.numFromY.Size = new System.Drawing.Size(120, 28);
            this.numFromY.TabIndex = 13;
            this.numFromY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFromY.ValueChanged += new System.EventHandler(this.numFromY_ValueChanged);
            // 
            // numFromX
            // 
            this.numFromX.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.numFromX.Location = new System.Drawing.Point(92, 20);
            this.numFromX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numFromX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFromX.Name = "numFromX";
            this.numFromX.Size = new System.Drawing.Size(120, 28);
            this.numFromX.TabIndex = 12;
            this.numFromX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFromX.ValueChanged += new System.EventHandler(this.numFromX_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(17, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "From (y)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(17, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "From (x)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxShapes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(324, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 138);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Draw Shapes";
            // 
            // comboBoxShapes
            // 
            this.comboBoxShapes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShapes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxShapes.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.comboBoxShapes.Items.AddRange(new object[] {
            "Line",
            "Rectangle",
            "Circle",
            "Arc"});
            this.comboBoxShapes.Location = new System.Drawing.Point(69, 26);
            this.comboBoxShapes.Name = "comboBoxShapes";
            this.comboBoxShapes.Size = new System.Drawing.Size(121, 29);
            this.comboBoxShapes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shape";
            // 
            // gbPen
            // 
            this.gbPen.Controls.Add(this.groupBoxLineCap);
            this.gbPen.Controls.Add(this.comboBoxPenStyle);
            this.gbPen.Controls.Add(this.label7);
            this.gbPen.Controls.Add(this.btnChangeColor);
            this.gbPen.Controls.Add(this.numPenSize);
            this.gbPen.Controls.Add(this.label6);
            this.gbPen.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbPen.Location = new System.Drawing.Point(0, 0);
            this.gbPen.Name = "gbPen";
            this.gbPen.Size = new System.Drawing.Size(324, 138);
            this.gbPen.TabIndex = 11;
            this.gbPen.TabStop = false;
            this.gbPen.Text = "Pen Properties";
            // 
            // comboBoxPenStyle
            // 
            this.comboBoxPenStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPenStyle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxPenStyle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.comboBoxPenStyle.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "Dash Dot"});
            this.comboBoxPenStyle.Location = new System.Drawing.Point(197, 16);
            this.comboBoxPenStyle.Name = "comboBoxPenStyle";
            this.comboBoxPenStyle.Size = new System.Drawing.Size(121, 29);
            this.comboBoxPenStyle.TabIndex = 9;
            this.comboBoxPenStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxPenStyle_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(145, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Style";
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnChangeColor.Location = new System.Drawing.Point(19, 53);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(115, 34);
            this.btnChangeColor.TabIndex = 8;
            this.btnChangeColor.Text = "Color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // numPenSize
            // 
            this.numPenSize.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.numPenSize.Location = new System.Drawing.Point(73, 19);
            this.numPenSize.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numPenSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPenSize.Name = "numPenSize";
            this.numPenSize.Size = new System.Drawing.Size(61, 28);
            this.numPenSize.TabIndex = 6;
            this.numPenSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numPenSize.ValueChanged += new System.EventHandler(this.numePenSize_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(15, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Size";
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // pbDrawBoard
            // 
            this.pbDrawBoard.BackColor = System.Drawing.Color.White;
            this.pbDrawBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDrawBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDrawBoard.Location = new System.Drawing.Point(0, 140);
            this.pbDrawBoard.Name = "pbDrawBoard";
            this.pbDrawBoard.Size = new System.Drawing.Size(1099, 576);
            this.pbDrawBoard.TabIndex = 2;
            this.pbDrawBoard.TabStop = false;
            // 
            // groupBoxLineCap
            // 
            this.groupBoxLineCap.Controls.Add(this.comboBoxEndCap);
            this.groupBoxLineCap.Controls.Add(this.label9);
            this.groupBoxLineCap.Controls.Add(this.comboBoxStartCap);
            this.groupBoxLineCap.Controls.Add(this.label8);
            this.groupBoxLineCap.Location = new System.Drawing.Point(140, 48);
            this.groupBoxLineCap.Name = "groupBoxLineCap";
            this.groupBoxLineCap.Size = new System.Drawing.Size(184, 92);
            this.groupBoxLineCap.TabIndex = 11;
            this.groupBoxLineCap.TabStop = false;
            this.groupBoxLineCap.Text = "Line Cap";
            // 
            // comboBoxEndCap
            // 
            this.comboBoxEndCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEndCap.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxEndCap.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.comboBoxEndCap.Items.AddRange(new object[] {
            "Round",
            "Flat",
            "Square",
            "Triangle",
            "Round Anchor",
            "Square Anchor",
            "Arrow Anchor",
            "Diamond Anchor"});
            this.comboBoxEndCap.Location = new System.Drawing.Point(57, 56);
            this.comboBoxEndCap.Name = "comboBoxEndCap";
            this.comboBoxEndCap.Size = new System.Drawing.Size(121, 29);
            this.comboBoxEndCap.TabIndex = 17;
            this.comboBoxEndCap.SelectedIndexChanged += new System.EventHandler(this.comboBoxEndCap_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "End";
            // 
            // comboBoxStartCap
            // 
            this.comboBoxStartCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStartCap.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxStartCap.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.comboBoxStartCap.Items.AddRange(new object[] {
            "Round",
            "Flat",
            "Square",
            "Triangle",
            "Round Anchor",
            "Square Anchor",
            "Arrow Anchor",
            "Diamond Anchor"});
            this.comboBoxStartCap.Location = new System.Drawing.Point(57, 21);
            this.comboBoxStartCap.Name = "comboBoxStartCap";
            this.comboBoxStartCap.Size = new System.Drawing.Size(121, 29);
            this.comboBoxStartCap.TabIndex = 15;
            this.comboBoxStartCap.SelectedIndexChanged += new System.EventHandler(this.comboBoxStartCap_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Start";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 716);
            this.Controls.Add(this.pbDrawBoard);
            this.Controls.Add(this.pnlToolBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Draw";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlToolBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbCoordinates.ResumeLayout(false);
            this.gbCoordinates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numToY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numToX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFromY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFromX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbPen.ResumeLayout(false);
            this.gbPen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPenSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawBoard)).EndInit();
            this.groupBoxLineCap.ResumeLayout(false);
            this.groupBoxLineCap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolBox;
        private System.Windows.Forms.GroupBox gbPen;
        private System.Windows.Forms.NumericUpDown numPenSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.PictureBox pbDrawBoard;
        private System.Windows.Forms.GroupBox gbCoordinates;
        private System.Windows.Forms.NumericUpDown numToY;
        private System.Windows.Forms.NumericUpDown numToX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numFromY;
        private System.Windows.Forms.NumericUpDown numFromX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox comboBoxShapes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPenStyle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxLineCap;
        private System.Windows.Forms.ComboBox comboBoxEndCap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxStartCap;
        private System.Windows.Forms.Label label8;
    }
}

