namespace Apli9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultado;
            bool esnumero = int.TryParse(textBox1.Text, out resultado);

            if (esnumero)
            {
                MessageBox.Show("Es un numero");
            }
            else
            {
                MessageBox.Show("No es un numero");
            }
        }
    }
}
