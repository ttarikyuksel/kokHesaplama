using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kokBulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt1.Text);

            int b = Convert.ToInt32(txt2.Text);

            int c = Convert.ToInt32(txt3.Text);
            
             int diskriminant = b * b - 4 * a * c;

            if (diskriminant > 0)
            {
                textBox1.Text = Convert.ToString(b * b - 4 * a * c);
                textBox2.Text = " > 0";
            }
            else if(diskriminant == 0)
            {
                textBox1.Text = Convert.ToString(b * b - 4 * a * c);
                textBox2.Text = " = 0";
            }
            else
            {
                textBox1.Text = Convert.ToString(b * b - 4 * a * c);
                textBox2.Text = " < 0";
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt1.Text);

            int b = Convert.ToInt32(txt2.Text);

            int c = Convert.ToInt32(txt3.Text);

            int diskriminant = b * b - 4 * a * c;

            if (diskriminant > 0)
            {
                textBox3.Text = "Δ > 0 ise birbirinden farklı iki kök vardır";
            }
            else if (diskriminant == 0)
            {
                textBox3.Text = "Δ = 0 ise birbirine eşit iki kök vardır.";
            }
            else
            {
                textBox3.Text = "Δ < 0 ise denklemin reel sayılarda çözümü yoktur.";
            }

            double kok1 = (-b + Math.Sqrt(diskriminant)) /2 * a;
            double kok2 = (-b - Math.Sqrt(diskriminant)) /2 * a;

            txt4.Text = Convert.ToString(kok1);
            txt5.Text = Convert.ToString(kok2);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
            txt5.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }

}
