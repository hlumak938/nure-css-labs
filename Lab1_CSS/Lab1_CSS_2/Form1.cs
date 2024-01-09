using System;
using System.Windows.Forms;

namespace Lab1_CSS_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            text = text.Replace("моє", "наше");
            textBox2.Text = text;
        }
    }
}
