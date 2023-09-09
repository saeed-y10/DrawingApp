using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Drawing_App
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Pen pen;

        private Point PointFrom;
        private Point PointTo;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = pbDrawBoard.CreateGraphics();

            PointFrom = new Point(1, 1);
            PointTo = new Point(1, 1);

            pen = new Pen(Color.Black, 4);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Flat;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Flat;

            comboBoxStartCap.SelectedIndex = 1;
            comboBoxEndCap.SelectedIndex = 1;

            comboBoxPenStyle.SelectedIndex = 0;
            comboBoxShapes.SelectedIndex = 0;
        }

        private void numFromX_ValueChanged(object sender, EventArgs e)
        {
            PointFrom.X = ((int)numFromX.Value);
        }

        private void numFromY_ValueChanged(object sender, EventArgs e)
        {
            PointFrom.Y = ((int)numFromY.Value);
        }

        private void numToX_ValueChanged(object sender, EventArgs e)
        {
            PointTo.X = ((int)numToX.Value);
        }

        private void numToY_ValueChanged(object sender, EventArgs e)
        {
            PointTo.Y = ((int)numToY.Value);
        }

        private void ClearBoard()
        {
            graphics.Clear(Color.White);
        }

        private void DrawLine()
        {
            graphics.DrawLine(pen, PointFrom, PointTo);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            switch (comboBoxShapes.SelectedItem.ToString())
            {
                case "Line":
                    graphics.DrawLine(pen, PointFrom, PointTo);
                    break;

                case "Rectangle":
                    graphics.DrawRectangle(pen, PointFrom.X, PointFrom.Y, PointTo.X, PointTo.Y);
                    break;

                case "Circle":
                    graphics.DrawEllipse(pen, PointFrom.X, PointFrom.Y, PointTo.X, PointTo.Y);
                    break;

                case "Arc":
                    Rectangle rec = new Rectangle(PointFrom.X, PointFrom.Y, PointTo.X, PointTo.Y);
                    graphics.DrawArc(pen, rec, 10, 5);
                    break;

                default:
                    ClearBoard();
                    break;
            }

        }

        private void numePenSize_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = ((int)numPenSize.Value);
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();

            colorDialog1.ShowDialog();

            pen.Color = colorDialog1.Color;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearBoard();
        }

        private void comboBoxPenStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxPenStyle.SelectedItem.ToString())
            {
                case "Solid":
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    break;

                case "Dash":
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    break;

                case "Dot":
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                    break;

                case "Dash Dot":
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
                    break;

                default:
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    break;
            }
        }

        private void comboBoxStartCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxStartCap.SelectedItem.ToString())
            {
                case "Round":
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    break;

                case "Square":
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.Square;
                    break;

                case "Triangle":
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.Triangle;
                    break;

                case "Round Anchor":
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
                    break;

                case "Square Anchor":
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.SquareAnchor;
                    break;

                case "Arrow Anchor":
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                    break;

                case "Diamond Anchor":
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;
                    break;

                case "No Anchor":
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.NoAnchor;
                    break;

                default:
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.Flat;
                    break;
            }

        }

        private void comboBoxEndCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxEndCap.SelectedItem.ToString())
            {
                case "Round":
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    break;
                
                case "Square":
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.Square;
                    break;

                case "Triangle":
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.Triangle;
                    break;

                case "Round Anchor":
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
                    break;

                case "Square Anchor":
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.SquareAnchor;
                    break;

                case "Arrow Anchor":
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                    break;

                case "Diamond Anchor":
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;
                    break;

                default:
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.Flat;
                    break;
            }
        }
    }
}
