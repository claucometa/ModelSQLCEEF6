namespace ExamPro.Winform.Frames
{
    partial class FormExams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExams));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.view1 = new ExamPro.Winform.Base.View();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.searchBox1 = new ExamPro.Winform.Base.SearchBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.images = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAcessoRestrito = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExams = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cVSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparTudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maleMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maleMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.femaleMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.femaleMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SymCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.view1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // view1
            // 
            this.view1.AllowUserToAddRows = false;
            this.view1.AllowUserToDeleteRows = false;
            this.view1.AllowUserToResizeColumns = false;
            this.view1.AllowUserToResizeRows = false;
            this.view1.AutoGenerateColumns = false;
            this.view1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDelete,
            this.colIndex,
            this.nomeDataGridViewTextBoxColumn,
            this.maleMinDataGridViewTextBoxColumn,
            this.maleMaxDataGridViewTextBoxColumn,
            this.femaleMinDataGridViewTextBoxColumn,
            this.femaleMaxDataGridViewTextBoxColumn,
            this.colUnit,
            this.SymCount,
            this.colEdit});
            this.view1.DataSource = this.bs;
            this.view1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view1.Location = new System.Drawing.Point(9, 69);
            this.view1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.view1.Name = "view1";
            this.view1.ReadOnly = true;
            this.view1.RowHeadersVisible = false;
            this.view1.Size = new System.Drawing.Size(722, 224);
            this.view1.TabIndex = 4;
            // 
            // bs
            // 
            this.bs.DataSource = typeof(ExamPro.Domain.Models.Exam);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Controls.Add(this.searchBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 33);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(722, 36);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // searchBox1
            // 
            this.searchBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchBox1.Location = new System.Drawing.Point(335, 8);
            this.searchBox1.Name = "searchBox1";
            this.searchBox1.Size = new System.Drawing.Size(294, 21);
            this.searchBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(634, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Exames";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // images
            // 
            this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
            this.images.TransparentColor = System.Drawing.Color.Transparent;
            this.images.Images.SetKeyName(0, "male.png");
            this.images.Images.SetKeyName(1, "female.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAcessoRestrito,
            this.menuExams});
            this.menuStrip1.Location = new System.Drawing.Point(9, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(722, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAcessoRestrito
            // 
            this.menuAcessoRestrito.Name = "menuAcessoRestrito";
            this.menuAcessoRestrito.Size = new System.Drawing.Size(99, 20);
            this.menuAcessoRestrito.Text = "Acesso Restrito";
            this.menuAcessoRestrito.Click += new System.EventHandler(this.menuAcessoRestrito_Click);
            // 
            // menuExams
            // 
            this.menuExams.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarItemToolStripMenuItem,
            this.importarDadosToolStripMenuItem,
            this.limparTudoToolStripMenuItem});
            this.menuExams.Enabled = false;
            this.menuExams.Name = "menuExams";
            this.menuExams.Size = new System.Drawing.Size(58, 20);
            this.menuExams.Text = "Exames";
            // 
            // adicionarItemToolStripMenuItem
            // 
            this.adicionarItemToolStripMenuItem.Name = "adicionarItemToolStripMenuItem";
            this.adicionarItemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.adicionarItemToolStripMenuItem.Text = "Adicionar Item";
            this.adicionarItemToolStripMenuItem.Click += new System.EventHandler(this.adicionarItemToolStripMenuItem_Click);
            // 
            // importarDadosToolStripMenuItem
            // 
            this.importarDadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem,
            this.cVSToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.importarDadosToolStripMenuItem.Name = "importarDadosToolStripMenuItem";
            this.importarDadosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importarDadosToolStripMenuItem.Text = "Importar";
            this.importarDadosToolStripMenuItem.Click += new System.EventHandler(this.importarDadosToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            // 
            // cVSToolStripMenuItem
            // 
            this.cVSToolStripMenuItem.Name = "cVSToolStripMenuItem";
            this.cVSToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.cVSToolStripMenuItem.Text = "CVS";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // limparTudoToolStripMenuItem
            // 
            this.limparTudoToolStripMenuItem.Name = "limparTudoToolStripMenuItem";
            this.limparTudoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.limparTudoToolStripMenuItem.Text = "Limpar Tudo";
            this.limparTudoToolStripMenuItem.Click += new System.EventHandler(this.limparTudoToolStripMenuItem_Click);
            // 
            // btSave
            // 
            this.btSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSave.Location = new System.Drawing.Point(586, 4);
            this.btSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(136, 31);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "Fechar modo restrito";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(9, 293);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.panel1.Size = new System.Drawing.Size(722, 35);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // colDelete
            // 
            this.colDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colDelete.HeaderText = "";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Visible = false;
            this.colDelete.Width = 30;
            // 
            // colIndex
            // 
            this.colIndex.DataPropertyName = "Index";
            dataGridViewCellStyle7.NullValue = null;
            this.colIndex.DefaultCellStyle = dataGridViewCellStyle7;
            this.colIndex.HeaderText = "Index";
            this.colIndex.Name = "colIndex";
            this.colIndex.ReadOnly = true;
            this.colIndex.Width = 50;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maleMinDataGridViewTextBoxColumn
            // 
            this.maleMinDataGridViewTextBoxColumn.DataPropertyName = "MaleMin";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.maleMinDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.maleMinDataGridViewTextBoxColumn.HeaderText = "Min";
            this.maleMinDataGridViewTextBoxColumn.Name = "maleMinDataGridViewTextBoxColumn";
            this.maleMinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maleMaxDataGridViewTextBoxColumn
            // 
            this.maleMaxDataGridViewTextBoxColumn.DataPropertyName = "MaleMax";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.maleMaxDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.maleMaxDataGridViewTextBoxColumn.HeaderText = "Max";
            this.maleMaxDataGridViewTextBoxColumn.Name = "maleMaxDataGridViewTextBoxColumn";
            this.maleMaxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // femaleMinDataGridViewTextBoxColumn
            // 
            this.femaleMinDataGridViewTextBoxColumn.DataPropertyName = "FemaleMin";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.femaleMinDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.femaleMinDataGridViewTextBoxColumn.HeaderText = "Min";
            this.femaleMinDataGridViewTextBoxColumn.Name = "femaleMinDataGridViewTextBoxColumn";
            this.femaleMinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // femaleMaxDataGridViewTextBoxColumn
            // 
            this.femaleMaxDataGridViewTextBoxColumn.DataPropertyName = "FemaleMax";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.femaleMaxDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.femaleMaxDataGridViewTextBoxColumn.HeaderText = "Max";
            this.femaleMaxDataGridViewTextBoxColumn.Name = "femaleMaxDataGridViewTextBoxColumn";
            this.femaleMaxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colUnit
            // 
            this.colUnit.DataPropertyName = "Unidade";
            this.colUnit.HeaderText = "Unidade";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            // 
            // SymCount
            // 
            this.SymCount.DataPropertyName = "SymCount";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SymCount.DefaultCellStyle = dataGridViewCellStyle12;
            this.SymCount.HeaderText = "Sin";
            this.SymCount.Name = "SymCount";
            this.SymCount.ReadOnly = true;
            this.SymCount.Width = 40;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "";
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Width = 30;
            // 
            // FormExams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.view1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormExams";
            this.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.Size = new System.Drawing.Size(740, 337);
            ((System.ComponentModel.ISupportInitialize)(this.view1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Base.View view1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Base.SearchBox searchBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.ImageList images;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAcessoRestrito;
        private System.Windows.Forms.ToolStripMenuItem menuExams;
        private System.Windows.Forms.ToolStripMenuItem adicionarItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparTudoToolStripMenuItem;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cVSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maleMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maleMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn femaleMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn femaleMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SymCount;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
    }
}