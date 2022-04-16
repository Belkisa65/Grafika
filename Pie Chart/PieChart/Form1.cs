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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Titles.Add("Pie Chart");

            int a = Int16.Parse(textBox1.Text);
            int b = Int16.Parse(textBox2.Text);
            int c = Int16.Parse(textBox3.Text);
            int d = Int16.Parse(textBox4.Text);
            int f = Int16.Parse(textBox5.Text); 
            chart1.Series["Series1"].Points.AddXY("1", a);

            chart1.Series["Series1"].Points.AddXY("2", b);
            chart1.Series["Series1"].Points.AddXY("3", c);
            chart1.Series["Series1"].Points.AddXY("4", d);
            chart1.Series["Series1"].Points.AddXY("5", f);
        }
    }
}
