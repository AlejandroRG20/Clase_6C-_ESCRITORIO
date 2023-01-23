namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ingr, il;
            ingr= double.Parse(textBox1.Text); 
            if(ingr>= 4800 && ingr <= 5000000)
            {
                il = ingr * 0.07;
                textBox2.Text = il.ToString();
            }
            else
            {
                MessageBox.Show("rango entre 4800 y 500000");
                textBox1.Text = "";
                textBox1.Focus();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
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