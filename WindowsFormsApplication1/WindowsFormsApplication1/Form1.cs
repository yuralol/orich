using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            Int32.TryParse(textBox1.Text, out x);
            float c = (float)Math.Log(0.08);
            float b = (float)Math.Pow(x, 2) + c;
            float a = (float)0.5 * c + (float)Math.Pow(x, 2);
            float y = (float)(Math.Pow(Math.Sin(a * x), 3) + b) / (float)(Math.Pow(Math.Cos(x), 2));
            label3.Text = y.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
