using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_CSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;
            FileStream stream = null;
            try
            {
                stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            }
            catch (Exception ex)
            {
                textBox1.Text = ex.Message;
            }
            StreamReader reader = new StreamReader(stream);
            string text = reader.ReadToEnd();
            int count = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            string result = "";
            foreach (string word in text.Split())
            {
                if (int.TryParse(word, out int n))
                {
                    if (n > max)
                        max = n;
                    if (n < min)
                        min = n;
                    count++;
                }
                if (!int.TryParse(word, out int w))
                {
                    result += word + " ";
                }
            }
            textBox1.Text += "Count of numbers = " + count.ToString() + "\r\nMax = " + max.ToString() + "\r\nMin = " + min.ToString() + "\r\n" + result;
            stream.Close();

            string path = @"D:\Programming\C_Projects\Lab2_CS\output.txt";
            try
            {
                stream = File.Open(path, FileMode.Truncate);
            }
            catch (Exception ex)
            {
                textBox1.Text = ex.Message;
            }
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(textBox1.Text);
            writer.Flush();
            stream.Close();
        }
    }
}
