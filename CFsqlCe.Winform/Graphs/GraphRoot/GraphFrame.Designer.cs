namespace CFSqlCe.Winform.Graphs.GraphRoot
{
    partial class GraphFrame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart = new CFSqlCe.Winform.Graphs.GraphRoot.MainGraph();
            this.patientCard1 = new CFSqlCe.Winform.Base.PatientCard();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.patientCard1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 76);
            this.panel1.TabIndex = 17;
            // 
            // chart
            // 
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Location = new System.Drawing.Point(5, 81);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(719, 314);
            this.chart.TabIndex = 0;
            // 
            // patientCard1
            // 
            this.patientCard1.Dock = System.Windows.Forms.DockStyle.Left;
            this.patientCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientCard1.Location = new System.Drawing.Point(0, 0);
            this.patientCard1.Margin = new System.Windows.Forms.Padding(4);
            this.patientCard1.Name = "patientCard1";
            this.patientCard1.Size = new System.Drawing.Size(516, 76);
            this.patientCard1.TabIndex = 15;
            // 
            // GraphFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GraphFrame";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.Size = new System.Drawing.Size(724, 395);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MainGraph chart;
        private System.Windows.Forms.Panel panel1;
        private Base.PatientCard patientCard1;
    }
}