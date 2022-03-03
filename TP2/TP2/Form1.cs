namespace TP2
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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Halo" + " " + textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}