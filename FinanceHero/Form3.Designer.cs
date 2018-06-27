namespace FinanceHero
{
    partial class Form3
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
            this.MoneytextBox = new System.Windows.Forms.TextBox();
            this.NTDlabel = new System.Windows.Forms.Label();
            this.Addpanel = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ClasscomboBox = new System.Windows.Forms.ComboBox();
            this.Confirmbutton = new System.Windows.Forms.Button();
            this.DescripttextBox = new System.Windows.Forms.TextBox();
            this.Descriptionlabel = new System.Windows.Forms.Label();
            this.classlabel = new System.Windows.Forms.Label();
            this.Timelabel = new System.Windows.Forms.Label();
            this.Toppanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Addpanel.SuspendLayout();
            this.Toppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoneytextBox
            // 
            this.MoneytextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.MoneytextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MoneytextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.MoneytextBox.Location = new System.Drawing.Point(98, 9);
            this.MoneytextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MoneytextBox.Multiline = true;
            this.MoneytextBox.Name = "MoneytextBox";
            this.MoneytextBox.Size = new System.Drawing.Size(240, 29);
            this.MoneytextBox.TabIndex = 8;
            // 
            // NTDlabel
            // 
            this.NTDlabel.AutoSize = true;
            this.NTDlabel.Font = new System.Drawing.Font("Good Times Rg", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NTDlabel.ForeColor = System.Drawing.Color.White;
            this.NTDlabel.Location = new System.Drawing.Point(14, 10);
            this.NTDlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NTDlabel.Name = "NTDlabel";
            this.NTDlabel.Size = new System.Drawing.Size(80, 34);
            this.NTDlabel.TabIndex = 7;
            this.NTDlabel.Text = "‎NT$";
            // 
            // Addpanel
            // 
            this.Addpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.Addpanel.Controls.Add(this.label1);
            this.Addpanel.Controls.Add(this.dateTimePicker1);
            this.Addpanel.Controls.Add(this.ClasscomboBox);
            this.Addpanel.Controls.Add(this.Confirmbutton);
            this.Addpanel.Controls.Add(this.DescripttextBox);
            this.Addpanel.Controls.Add(this.Descriptionlabel);
            this.Addpanel.Controls.Add(this.classlabel);
            this.Addpanel.Controls.Add(this.Timelabel);
            this.Addpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Addpanel.Location = new System.Drawing.Point(0, 46);
            this.Addpanel.Margin = new System.Windows.Forms.Padding(2);
            this.Addpanel.Name = "Addpanel";
            this.Addpanel.Size = new System.Drawing.Size(358, 299);
            this.Addpanel.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Gainsboro;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Gainsboro;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Gainsboro;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(318, 30);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // ClasscomboBox
            // 
            this.ClasscomboBox.BackColor = System.Drawing.Color.Gainsboro;
            this.ClasscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClasscomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ClasscomboBox.FormattingEnabled = true;
            this.ClasscomboBox.Items.AddRange(new object[] {
            "食",
            "衣",
            "住",
            "行",
            "育",
            "樂",
            "其他",
            "秘密"});
            this.ClasscomboBox.Location = new System.Drawing.Point(20, 109);
            this.ClasscomboBox.Name = "ClasscomboBox";
            this.ClasscomboBox.Size = new System.Drawing.Size(318, 33);
            this.ClasscomboBox.TabIndex = 12;
            // 
            // Confirmbutton
            // 
            this.Confirmbutton.Font = new System.Drawing.Font("Good Times Rg", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmbutton.Location = new System.Drawing.Point(94, 249);
            this.Confirmbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Confirmbutton.Name = "Confirmbutton";
            this.Confirmbutton.Size = new System.Drawing.Size(166, 29);
            this.Confirmbutton.TabIndex = 6;
            this.Confirmbutton.Text = "Modify";
            this.Confirmbutton.UseVisualStyleBackColor = true;
            this.Confirmbutton.Click += new System.EventHandler(this.Confirmbutton_Click);
            // 
            // DescripttextBox
            // 
            this.DescripttextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.DescripttextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescripttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripttextBox.Location = new System.Drawing.Point(20, 178);
            this.DescripttextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DescripttextBox.Multiline = true;
            this.DescripttextBox.Name = "DescripttextBox";
            this.DescripttextBox.Size = new System.Drawing.Size(318, 29);
            this.DescripttextBox.TabIndex = 3;
            // 
            // Descriptionlabel
            // 
            this.Descriptionlabel.AutoSize = true;
            this.Descriptionlabel.Font = new System.Drawing.Font("Good Times Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descriptionlabel.ForeColor = System.Drawing.Color.White;
            this.Descriptionlabel.Location = new System.Drawing.Point(16, 158);
            this.Descriptionlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Descriptionlabel.Name = "Descriptionlabel";
            this.Descriptionlabel.Size = new System.Drawing.Size(167, 23);
            this.Descriptionlabel.TabIndex = 2;
            this.Descriptionlabel.Text = "Description";
            // 
            // classlabel
            // 
            this.classlabel.AutoSize = true;
            this.classlabel.Font = new System.Drawing.Font("Good Times Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classlabel.ForeColor = System.Drawing.Color.White;
            this.classlabel.Location = new System.Drawing.Point(16, 88);
            this.classlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.classlabel.Name = "classlabel";
            this.classlabel.Size = new System.Drawing.Size(92, 23);
            this.classlabel.TabIndex = 1;
            this.classlabel.Text = "class";
            // 
            // Timelabel
            // 
            this.Timelabel.AutoSize = true;
            this.Timelabel.Font = new System.Drawing.Font("Good Times Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timelabel.ForeColor = System.Drawing.Color.White;
            this.Timelabel.Location = new System.Drawing.Point(16, 18);
            this.Timelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(64, 23);
            this.Timelabel.TabIndex = 0;
            this.Timelabel.Text = "Time";
            // 
            // Toppanel
            // 
            this.Toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(150)))), ((int)(((byte)(227)))));
            this.Toppanel.Controls.Add(this.MoneytextBox);
            this.Toppanel.Controls.Add(this.NTDlabel);
            this.Toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Toppanel.Location = new System.Drawing.Point(0, 0);
            this.Toppanel.Margin = new System.Windows.Forms.Padding(2);
            this.Toppanel.Name = "Toppanel";
            this.Toppanel.Size = new System.Drawing.Size(358, 46);
            this.Toppanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Good Times Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(272, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 14;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 345);
            this.Controls.Add(this.Addpanel);
            this.Controls.Add(this.Toppanel);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Addpanel.ResumeLayout(false);
            this.Addpanel.PerformLayout();
            this.Toppanel.ResumeLayout(false);
            this.Toppanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox MoneytextBox;
        private System.Windows.Forms.Label NTDlabel;
        private System.Windows.Forms.Panel Addpanel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox ClasscomboBox;
        private System.Windows.Forms.Button Confirmbutton;
        private System.Windows.Forms.TextBox DescripttextBox;
        private System.Windows.Forms.Label Descriptionlabel;
        private System.Windows.Forms.Label classlabel;
        private System.Windows.Forms.Label Timelabel;
        private System.Windows.Forms.Panel Toppanel;
        private System.Windows.Forms.Label label1;
    }
}