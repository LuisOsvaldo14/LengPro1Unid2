namespace Apli15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string ruta = openFileDialog1.FileName;
                textBox1.Text = File.ReadAllText(ruta);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string ruta = saveFileDialog1.FileName;
                File.WriteAllText(ruta, textBox1.Text);

                MessageBox.Show("Archivo guardado con éxito.");
            }
        }
    }
}