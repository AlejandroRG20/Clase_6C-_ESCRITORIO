using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ingr,egr, ut;
            ingr = double.Parse(textBox1.Text);
            egr = double.Parse(textBox2.Text);
            if ((ingr >= 4800 && ingr <= 5000000)&& egr<ingr)
            {
                ut = ingr - egr;
                textBox3.Text = ut.ToString();
            }
            else
            {
                MessageBox.Show("rango entre 4800 y 500000");
                textBox1.Text = "";
                textBox1.Focus();
                textBox2.Text = "";
                textBox2.Focus();
                textBox3.Text = "";
                textBox3.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Handled = true;
                return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Handled = true;
                return;
            }
        }
    }
}
