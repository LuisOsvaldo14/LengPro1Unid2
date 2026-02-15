namespace Apli4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Numero1 = Convert.ToInt32(textBox1.Text);
            int Numero2 = Convert.ToInt32(textBox2.Text);

            int Suma = Numero1 + Numero2;
            
            label1.Text = Suma.ToString();
        }
    }
}
