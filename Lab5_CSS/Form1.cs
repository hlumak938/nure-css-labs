using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_CSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th1 = new Thread(new ThreadStart(MyTask));
            th1.Start();
            th1.Join();
            FileStream stream = null;
            string path = @"C:\Users\vglum\Desktop\output.txt";
            try
            {
                stream = File.Create(path);
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
        public void MyTask()
        {
            StringBuilder str = new StringBuilder();
            int min = int.MaxValue;
            int max = int.MinValue;
            Random random = new Random();
            for (int i = 0; i < 10000; i++)
            {
                str.Append($"{random.Next(0, 10000)} ");
            }
            foreach (string num in str.ToString().Split())
            {
                if (int.TryParse(num, out int n))
                {
                    if (n < min) { min = n; }
                    if (n > max) { max = n; }
                }
            }
            str.Append($"\nMin = {min}\nMax = {max}");
            textBox1.Text = str.ToString();
        }

    }
}
