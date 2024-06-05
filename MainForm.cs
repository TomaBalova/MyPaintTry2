using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Windows.Forms;

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

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            toolsChange();
            g.DrawLine(pen, startPoint.X, startPoint.Y, e.X, e.Y);
            pictureBox1.Image = bitmap;
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
    }
}
