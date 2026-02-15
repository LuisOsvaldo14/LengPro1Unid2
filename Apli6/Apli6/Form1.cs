namespace Apli6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = comboBox1.SelectedItem.ToString();

            if (color == "Rojo")
            {
                BackColor = Color.Red;
            }
            else if (color == "Azul")
            {
                BackColor = Color.Blue;
            }
            else if (color == "Verde")
            {
                BackColor = Color.Green;
            }
            else
            {
                BackColor = Color.White;
            }
        }
    }
}
