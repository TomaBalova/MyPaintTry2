using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MyPaintTry2
{
    enum Shapes
    {
        Line,
        Ellipse,
        Rectangle,
        Text,
        Image,
        PaintBrush
    }


    public partial class MainForm : Form
    {
        Stack<Bitmap> history = new Stack<Bitmap>();

        private Pen pen;
        private Brush brush;

        private Shapes shape = Shapes.Line;

        private Color LineColor = Color.Black;
        private Color FillColor = Color.White;
        private HatchStyle hatchStyle;

        private Point startPoint;
        private Graphics g;
        private Bitmap bitmap;

        public MainForm()
        {
            InitializeComponent();

            InitalizeTools();
            InitalizeCB();
        }

        private void InitalizeTools()
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);

            pen = new Pen(LineColor, 1);
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            brush = new SolidBrush(FillColor);
        }

        private void InitalizeCB()
        {
            comboBoxHatchBrushes.Items.Add("No Style");
            comboBoxHatchBrushes.SelectedItem = "No Style";

            var t = Enum.GetNames(typeof(HatchStyle)).ToArray();
            comboBoxHatchBrushes.Items.AddRange(t);

            using (InstalledFontCollection all = new InstalledFontCollection())
            {
                foreach (FontFamily fa in all.Families)
                {
                    comboBoxFontType.Items.Add(fa.Name);
                }
            }
            comboBoxFontType.SelectedIndex = 1;
        }

        private void toolsChange()
        {
            pen = new Pen(LineColor, (int)numericUpDownLineThickness.Value);
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;

            if (Enum.TryParse(comboBoxHatchBrushes.SelectedItem.ToString(), out hatchStyle))
            {
                brush = new HatchBrush(hatchStyle, LineColor, FillColor);
            }
            else
            {
                brush = new SolidBrush(FillColor);
            }
        }

        private void drawingShape(Point endPoint)
        {
            //toolsChange();
            int width = Math.Abs(endPoint.X - startPoint.X);
            int heigth = Math.Abs(endPoint.Y - startPoint.Y);

            int minX = Math.Min(startPoint.X, endPoint.X);
            int minY = Math.Min(startPoint.Y, endPoint.Y);

            switch (shape)
            {
                case Shapes.Line:
                    g.DrawLine(pen, startPoint.X, startPoint.Y, endPoint.X, endPoint.Y);
                    break;
                case Shapes.Rectangle:
                    if (checkBoxFill.Checked) g.FillRectangle(brush, minX, minY, width, heigth);
                    g.DrawRectangle(pen, minX, minY, width, heigth);
                    break;
                case Shapes.Ellipse:
                    if (checkBoxFill.Checked) g.FillEllipse(brush, minX, minY, width, heigth);
                    g.DrawEllipse(pen, minX, minY, width, heigth);
                    break;
                case Shapes.Image:
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        using (Bitmap bit = new Bitmap($@"{openFileDialog1.FileName}"))
                        {
                            g.DrawImage(bit, new Point(minX, minY));
                        }
                    }
                    break;
                case Shapes.Text:
                    g.DrawString(textBoxText.Text, new Font(comboBoxFontType.Text, (int)numericUpDownFontSize.Value), new SolidBrush(LineColor), minX, minY);
                    break;
                default: break;

            }


            pictureBox1.Image = bitmap;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            drawingShape(p);
        }

        private void radioButtonLine_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLine.Checked) shape = Shapes.Line;
        }

        private void radioButtonRectangle_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRectangle.Checked) shape = Shapes.Rectangle;
        }

        private void radioButtonEllipse_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEllipse.Checked) shape = Shapes.Ellipse;
        }

        private void radioButtonPaintBrush_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPaintBrush.Checked) shape = Shapes.PaintBrush;
        }

        private void radioButtonImage_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonImage.Checked) shape = Shapes.Image;
        }

        private void radioButtonText_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonText.Checked) shape = Shapes.Text;
        }

        private void numericUpDownLineThickness_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = (int)numericUpDownLineThickness.Value;
        }

        private void panelFGColor_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == colorDialog1.ShowDialog())
            {
                LineColor = colorDialog1.Color;
                pen.Color = colorDialog1.Color;
                panelFGColor.BackColor = LineColor;
            }
        }

        private void panelBGColor_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == colorDialog1.ShowDialog())
            {
                FillColor = colorDialog1.Color;
                toolsChange();
                panelBGColor.BackColor = FillColor;
            }
        }

        private void comboBoxHatchBrushes_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolsChange();
        }
    }
}
