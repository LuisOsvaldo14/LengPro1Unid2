namespace Apli12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double celcius = Convert.ToDouble(textBox1.Text);
            double fahrenheit = (celcius * 9 / 5) + 32;

            label1.Text = "Es igual a " + fahrenheit.ToString() + " grados fahrenheit ";
            
        }
    }
}
