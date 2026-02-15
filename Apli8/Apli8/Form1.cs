namespace Apli8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int contador = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            contador = contador + 1;
            label1.Text = contador.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
