namespace CFSqlCe.Winform.Forms
{
    partial class Laudos
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
            this.view1 = new CFSqlCe.Winform.Base.View();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colLab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOk = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colFolder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.patientCard1 = new CFSqlCe.Winform.Base.PatientCard();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.view1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.colLab,
            this.descriptionDataGridViewTextBoxColumn,
            this.FileName,
            this.ReportData,
            this.colOk,
            this.colFolder});
            this.view1.DataSource = this.bs;
            this.view1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view1.Location = new System.Drawing.Point(219, 102);
            this.view1.Name = "view1";
            this.view1.RowHeadersVisible = false;
            this.view1.Size = new System.Drawing.Size(745, 297);
            this.view1.TabIndex = 6;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Width = 40;
            // 
            // colLab
            // 
            this.colLab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLab.HeaderText = "Laboratório";
            this.colLab.Name = "colLab";
            this.colLab.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLab.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FileName.DataPropertyName = "FileName";
            this.FileName.HeaderText = "Nome do Arquivo";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // ReportData
            // 
            this.ReportData.DataPropertyName = "ReportData";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.ReportData.DefaultCellStyle = dataGridViewCellStyle1;
            this.ReportData.HeaderText = "Data do Laudo";
            this.ReportData.Name = "ReportData";
            this.ReportData.Width = 130;
            // 
            // colOk
            // 
            this.colOk.HeaderText = "";
            this.colOk.Name = "colOk";
            this.colOk.Width = 40;
            // 
            // colFolder
            // 
            this.colFolder.HeaderText = "";
            this.colFolder.Name = "colFolder";
            this.colFolder.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFolder.Width = 40;
            // 
            // bs
            // 
            this.bs.DataSource = typeof(CFSqlCe.Domain.Model.Laudo);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 269);
            this.listBox1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.patientCard1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(9, 9);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel2.Size = new System.Drawing.Size(955, 93);
            this.panel2.TabIndex = 10;
            // 
            // patientCard1
            // 
            this.patientCard1.Dock = System.Windows.Forms.DockStyle.Left;
            this.patientCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientCard1.Location = new System.Drawing.Point(0, 0);
            this.patientCard1.Margin = new System.Windows.Forms.Padding(4);
            this.patientCard1.Name = "patientCard1";
            this.patientCard1.Size = new System.Drawing.Size(510, 88);
            this.patientCard1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Image = global::CFSqlCe.Winform.Properties.Resources.add;
            this.button3.Location = new System.Drawing.Point(803, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 34);
            this.button3.TabIndex = 1;
            this.button3.Text = "Adicionar Laudo";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(209, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 297);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.listBox1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(9, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 297);
            this.panel4.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Laboratórios";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Laudos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 458);
            this.Controls.Add(this.view1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Laudos";
            this.Text = "Exam PRO";
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.view1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.view1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bs;
        private Base.View view1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLab;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportData;
        private System.Windows.Forms.DataGridViewButtonColumn colOk;
        private System.Windows.Forms.DataGridViewButtonColumn colFolder;
        private Base.PatientCard patientCard1;
    }
}