namespace CFSqlCe.Winform.Forms
{
    partial class PatientEdit
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
            System.Windows.Forms.Label birthDayLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label label1;
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.birthDayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            birthDayLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // birthDayLabel
            // 
            birthDayLabel.AutoSize = true;
            birthDayLabel.Location = new System.Drawing.Point(16, 48);
            birthDayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            birthDayLabel.Name = "birthDayLabel";
            birthDayLabel.Size = new System.Drawing.Size(80, 16);
            birthDayLabel.TabIndex = 0;
            birthDayLabel.Text = "Nascimento";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(51, 19);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(45, 16);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(255, 78);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 16);
            label1.TabIndex = 7;
            label1.Text = "Sexo";
            // 
            // bs
            // 
            this.bs.DataSource = typeof(CFSqlCe.Domain.Model.Patient);
            // 
            // birthDayDateTimePicker
            // 
            this.birthDayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bs, "BirthDay", true));
            this.birthDayDateTimePicker.Location = new System.Drawing.Point(104, 44);
            this.birthDayDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.birthDayDateTimePicker.Name = "birthDayDateTimePicker";
            this.birthDayDateTimePicker.Size = new System.Drawing.Size(374, 22);
            this.birthDayDateTimePicker.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(104, 13);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(374, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(302, 76);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 20);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Masculino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(397, 76);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(81, 20);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Feminino";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Idade";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(103, 78);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(45, 16);
            this.ageLabel.TabIndex = 9;
            this.ageLabel.Text = "label3";
            // 
            // PatientEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 194);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(birthDayLabel);
            this.Controls.Add(this.birthDayDateTimePicker);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PatientEdit";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.nameTextBox, 0);
            this.Controls.SetChildIndex(nameLabel, 0);
            this.Controls.SetChildIndex(this.birthDayDateTimePicker, 0);
            this.Controls.SetChildIndex(birthDayLabel, 0);
            this.Controls.SetChildIndex(this.radioButton1, 0);
            this.Controls.SetChildIndex(this.radioButton2, 0);
            this.Controls.SetChildIndex(label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.ageLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.DateTimePicker birthDayDateTimePicker;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ageLabel;
    }
}