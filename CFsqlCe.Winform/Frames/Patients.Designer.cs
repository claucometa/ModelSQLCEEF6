namespace CFSqlCe.Winform.Frames
{
    partial class Patients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button3 = new System.Windows.Forms.Button();
            this.searchBox1 = new CFSqlCe.Winform.Base.SearchBox();
            this.view1 = new CFSqlCe.Winform.Base.View();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaudos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colOk = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colChart = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.view1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(755, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "Gerenciar Laudos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // searchBox1
            // 
            this.searchBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox1.Location = new System.Drawing.Point(157, 11);
            this.searchBox1.Name = "searchBox1";
            this.searchBox1.Size = new System.Drawing.Size(302, 22);
            this.searchBox1.TabIndex = 3;
            // 
            // view1
            // 
            this.view1.AllowUserToAddRows = false;
            this.view1.AllowUserToResizeColumns = false;
            this.view1.AllowUserToResizeRows = false;
            this.view1.AutoGenerateColumns = false;
            this.view1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDelete,
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.Age,
            this.colLaudos,
            this.createdDataGridViewTextBoxColumn,
            this.colEdit,
            this.colOk,
            this.colChart});
            this.view1.DataSource = this.bs;
            this.view1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view1.Location = new System.Drawing.Point(0, 5);
            this.view1.Name = "view1";
            this.view1.ReadOnly = true;
            this.view1.RowHeadersVisible = false;
            this.view1.Size = new System.Drawing.Size(895, 413);
            this.view1.TabIndex = 2;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Width = 40;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 120;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Age.DefaultCellStyle = dataGridViewCellStyle1;
            this.Age.HeaderText = "Idade";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 60;
            // 
            // colLaudos
            // 
            this.colLaudos.DataPropertyName = "TotalLaudos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colLaudos.DefaultCellStyle = dataGridViewCellStyle2;
            this.colLaudos.HeaderText = "Laudos";
            this.colLaudos.Name = "colLaudos";
            this.colLaudos.ReadOnly = true;
            this.colLaudos.Width = 60;
            // 
            // createdDataGridViewTextBoxColumn
            // 
            this.createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn.HeaderText = "Log";
            this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            this.createdDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdDataGridViewTextBoxColumn.Width = 130;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "";
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Width = 40;
            // 
            // colOk
            // 
            this.colOk.HeaderText = "";
            this.colOk.Name = "colOk";
            this.colOk.ReadOnly = true;
            this.colOk.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colOk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colOk.Width = 40;
            // 
            // colChart
            // 
            this.colChart.HeaderText = "";
            this.colChart.Name = "colChart";
            this.colChart.ReadOnly = true;
            this.colChart.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colChart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colChart.Width = 40;
            // 
            // bs
            // 
            this.bs.DataSource = typeof(CFSqlCe.Domain.Model.Patient);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.view1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(13, 56);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.panel2.Size = new System.Drawing.Size(900, 418);
            this.panel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 290F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.searchBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btNovo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 44);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btNovo
            // 
            this.btNovo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btNovo.Image = global::CFSqlCe.Winform.Properties.Resources.flatAdd;
            this.btNovo.Location = new System.Drawing.Point(4, 4);
            this.btNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(146, 36);
            this.btNovo.TabIndex = 1;
            this.btNovo.Text = "Novo Paciente";
            this.btNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 486);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Patients";
            this.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.Text = "Pacientes";
            ((System.ComponentModel.ISupportInitialize)(this.view1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Base.View view1;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Panel panel2;
        private Base.SearchBox searchBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaudos;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colOk;
        private System.Windows.Forms.DataGridViewButtonColumn colChart;
    }
}