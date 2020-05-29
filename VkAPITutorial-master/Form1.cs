using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VkAPITutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void проверкаДрузейВВконтактеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm GetToken = new MainForm(IDVK.Text);
            GetToken.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "00.00.0000";
            
                }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm GetToken = new MainForm(IDVK.Text);
            GetToken.ShowDialog();
        }

        private void проверкаЧерезЧерныйСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // BDTER BD = new BDTER(Imya.Text, Family.Text, Otchestvo.Text, maskedTextBox1.Text);
            //BD.ShowDialog();
            // BD.Visible = false;
           Form3 Proverka = new Form3(Imya.Text, Family.Text, Otchestvo.Text, maskedTextBox1.Text);
            Proverka.ShowDialog();
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Imya.Text = "";
            Family.Text = "";
            Otchestvo.Text = "";
            maskedTextBox1.Text = "";
            IDVK.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Proverka = new Form3(Imya.Text, Family.Text, Otchestvo.Text, maskedTextBox1.Text);
            Proverka.ShowDialog();
        }
    }
}
