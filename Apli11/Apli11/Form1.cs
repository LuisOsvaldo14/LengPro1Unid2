namespace Apli11
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
            string formatofecha = fecha.ToLongDateString() + " " + fecha.ToLongTimeString();
            label1.Text = formatofecha;

        }
    }
}
