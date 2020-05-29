namespace VkAPITutorial
{
    partial class BDTER
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.база_данных1DataSet = new VkAPITutorial.База_данных1DataSet();
            this.террористыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Террористы_TableAdapter = new VkAPITutorial.База_данных1DataSetTableAdapters._Террористы_TableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.втораяФамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.второеИмяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.второеОтчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.террористыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.втораяФамилияDataGridViewTextBoxColumn,
            this.второеИмяDataGridViewTextBoxColumn,
            this.второеОтчествоDataGridViewTextBoxColumn,
            this.датаРожденияDataGridViewTextBoxColumn,
            this.местоРожденияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.террористыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(798, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // база_данных1DataSet
            // 
            this.база_данных1DataSet.DataSetName = "База_данных1DataSet";
            this.база_данных1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // террористыBindingSource
            // 
            this.террористыBindingSource.DataMember = "\"Террористы\"";
            this.террористыBindingSource.DataSource = this.база_данных1DataSet;
            // 
            // _Террористы_TableAdapter
            // 
            this._Террористы_TableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // втораяФамилияDataGridViewTextBoxColumn
            // 
            this.втораяФамилияDataGridViewTextBoxColumn.DataPropertyName = "Вторая фамилия";
            this.втораяФамилияDataGridViewTextBoxColumn.HeaderText = "Вторая фамилия";
            this.втораяФамилияDataGridViewTextBoxColumn.Name = "втораяФамилияDataGridViewTextBoxColumn";
            // 
            // второеИмяDataGridViewTextBoxColumn
            // 
            this.второеИмяDataGridViewTextBoxColumn.DataPropertyName = "Второе Имя";
            this.второеИмяDataGridViewTextBoxColumn.HeaderText = "Второе Имя";
            this.второеИмяDataGridViewTextBoxColumn.Name = "второеИмяDataGridViewTextBoxColumn";
            // 
            // второеОтчествоDataGridViewTextBoxColumn
            // 
            this.второеОтчествоDataGridViewTextBoxColumn.DataPropertyName = "Второе отчество";
            this.второеОтчествоDataGridViewTextBoxColumn.HeaderText = "Второе отчество";
            this.второеОтчествоDataGridViewTextBoxColumn.Name = "второеОтчествоDataGridViewTextBoxColumn";
            // 
            // датаРожденияDataGridViewTextBoxColumn
            // 
            this.датаРожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
            // 
            // местоРожденияDataGridViewTextBoxColumn
            // 
            this.местоРожденияDataGridViewTextBoxColumn.DataPropertyName = "Место рождения";
            this.местоРожденияDataGridViewTextBoxColumn.HeaderText = "Место рождения";
            this.местоРожденияDataGridViewTextBoxColumn.Name = "местоРожденияDataGridViewTextBoxColumn";
            // 
            // BDTER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BDTER";
            this.Text = "BDTER";
            this.Load += new System.EventHandler(this.BDTER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.террористыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private База_данных1DataSet база_данных1DataSet;
        private System.Windows.Forms.BindingSource террористыBindingSource;
        private База_данных1DataSetTableAdapters._Террористы_TableAdapter _Террористы_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn втораяФамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn второеИмяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn второеОтчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоРожденияDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}