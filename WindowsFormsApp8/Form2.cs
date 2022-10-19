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

namespace WindowsFormsApp8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Multiselect = true;
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in OPF.FileNames)
                {
                    StreamReader ofd = new StreamReader(file);
                    textBox1.Text = ofd.ReadToEnd();
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
                textBox1.ForeColor = Color.MediumBlue;
            else if (listBox1.SelectedIndex == 1)
                textBox1.ForeColor = Color.Red;
            else if (listBox1.SelectedIndex == 2)
                textBox1.ForeColor = Color.Black;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {


            textBox1.Font = new Font(textBox1.Font.FontFamily, trackBar1.Value);
            textBox1.ScrollBars = ScrollBars.Both;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string lines = textBox1.Text;
            System.IO.File.WriteAllText("C:/Users/oleg4/OneDrive/Desktop/Папка со всем/g.txt", lines);


        }
    }
}
