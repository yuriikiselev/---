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
    public partial class Form3 : Form
    {
        void activator()
        {
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
        }
        void deactivator()
        {
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
        }
        public string c;
        bool Prof()
        {
            if (dataGridView1 != null)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[1].Selected = false;
                    if (dataGridView1.Rows[i].Cells[1].Value != null)
                    {

                        if (dataGridView1.Rows[i].Cells[1].Value.ToString().Equals(textBox1.Text)
                        || dataGridView1.Rows[i].Cells[4].Value.ToString().Equals(textBox1.Text))
                        {
                            label4.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                            if (dataGridView1.Rows[i].Cells[2].Value.ToString().Equals(textBox2.Text)
                            || dataGridView1.Rows[i].Cells[5].Value.ToString().Equals(textBox2.Text))
                            {
                                label5.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                                if (dataGridView1.Rows[i].Cells[3].Value.ToString().Equals(textBox3.Text)
                                || dataGridView1.Rows[i].Cells[6].Value.ToString().Equals(textBox3.Text))
                                {
                                    label6.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                                    label7.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
                                    label8.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
                                    //if (dataGridView1.Rows[i].Cells[7].Value.ToString().Contains(maskedTextBox1.Text))
                                    // {
                                    // c = i;
                                    return true; 
                                  //  }
                                   
                                }


                            }

                        }

                    }

                }

            }
            c = "";
            return false;

        }
        public Form3(String imya, String famyli, String otchestvo, String DataB )
        {
            
            InitializeComponent();
            maskedTextBox1.Mask = "00.00.0000";
            textBox1.Text += famyli;
            textBox2.Text += imya;
            textBox3.Text += otchestvo;
            maskedTextBox1.Text += DataB;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Prof())
            {
                label1.Text = "В базе экстремистов и терростиво есть совпадение: ";
                activator();
            }
            else
            {
                label1.Text = "Совпадений в базе не обнаружено";
                deactivator();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных1DataSet.__Террористы_". При необходимости она может быть перемещена или удалена.
            this._Террористы_TableAdapter.Fill(this.база_данных1DataSet.@__Террористы_);
            // BDTER BD = new BDTER();
            //BD.ShowDialog();
            // BD.Visible = false;
            deactivator();
            if (Prof()&& textBox1.Text!="")
            {
                label1.Text = "В базе экстремистов и терростиво есть совпадение: ";
                activator();
            }
            else
            {
                label1.Text = "Совпадений в базе не обнаружено";
                deactivator();
            }
            }

        private void проверкаДрузейВВконтактеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm GetToken = new MainForm("");
            GetToken.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
