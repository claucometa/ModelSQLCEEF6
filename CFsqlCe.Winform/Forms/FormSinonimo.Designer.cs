namespace CFSqlCe.Winform.Forms
{
    partial class FormSinonimo
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
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.view1 = new CFSqlCe.Winform.Base.View();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.symDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1)).BeginInit();
            this.SuspendLayout();
            // 
            // bs
            // 
            this.bs.DataSource = typeof(CFSqlCe.Domain.Model.Sinonimo);
            // 
            // view1
            // 
            this.view1.AllowUserToResizeColumns = false;
            this.view1.AllowUserToResizeRows = false;
            this.view1.AutoGenerateColumns = false;
            this.view1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view1.ColumnHeadersVisible = false;
            this.view1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDelete,
            this.symDataGridViewTextBoxColumn});
            this.view1.DataSource = this.bs;
            this.view1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view1.Location = new System.Drawing.Point(12, 11);
            this.view1.Name = "view1";
            this.view1.RowHeadersVisible = false;
            this.view1.Size = new System.Drawing.Size(397, 214);
            this.view1.TabIndex = 5;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "";
            this.colDelete.Name = "colDelete";
            this.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colDelete.Width = 30;
            // 
            // symDataGridViewTextBoxColumn
            // 
            this.symDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.symDataGridViewTextBoxColumn.DataPropertyName = "Sym";
            this.symDataGridViewTextBoxColumn.HeaderText = "Sym";
            this.symDataGridViewTextBoxColumn.Name = "symDataGridViewTextBoxColumn";
            // 
            // FormSinonimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 286);
            this.ControlBox = true;
            this.Controls.Add(this.view1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSinonimo";
            this.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.Text = "Sinônimos";
            this.Controls.SetChildIndex(this.view1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bs;
        private Base.View view1;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn symDataGridViewTextBoxColumn;



    }
}