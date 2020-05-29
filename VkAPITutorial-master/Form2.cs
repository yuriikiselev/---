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
    public partial class BDTER : Form
    {
        public string str1,str2,str3,str4;
        public BDTER()
        {
            InitializeComponent();
       
        }

        private void BDTER_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных1DataSet.__Террористы_". При необходимости она может быть перемещена или удалена.
            this._Террористы_TableAdapter.Fill(this.база_данных1DataSet.@__Террористы_);
            // BDTER BD = new BDTER();
           
        }
    }
}
