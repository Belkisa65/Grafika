using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);
            Rectangle r = new Rectangle(50, 50, 150, 30);
            g.DrawEllipse(p, r);
            Font f = new Font(FontFamily.GenericSerif, 14, FontStyle.Bold);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("START", f, b, 90, 55);

            p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(p, 125, 80, 125, 100);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);
            Point[] po = { new Point(50, 100), new Point(200, 100), new Point(180, 130), new Point(70, 130) };
            g.DrawPolygon(p, po);
            String s = this.textBox1.Text;
            Font f = new Font(FontFamily.GenericSerif, 14, FontStyle.Bold);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString(s, f, b, 100, 100);

            p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(p, 125, 130, 125, 160);

        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);
            Point[] po = { new Point(50, 160), new Point(200, 160), new Point(200, 190), new Point(50, 190) };
            g.DrawPolygon(p, po);
            String s = this.textBox1.Text;
            Font f = new Font(FontFamily.GenericSerif, 14, FontStyle.Bold);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString(s, f, b, 100, 160);

            p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(p, 125, 190, 125, 220);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 1);
            Rectangle r = new Rectangle(50, 220, 150, 40);
            g.DrawEllipse(p, r);
            Font f = new Font(FontFamily.GenericSerif, 14, FontStyle.Bold);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("END", f, b, 100, 230);

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
