namespace Apli5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                label1.Text = radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                label1.Text = radioButton3.Text;
            }
        }
    }
}
