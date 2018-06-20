namespace FinanceHero
{
    partial class AddForm
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
            this.Toppanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NTDlabel = new System.Windows.Forms.Label();
            this.Addpanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Confirmbutton = new System.Windows.Forms.Button();
            this.TimetextBox = new System.Windows.Forms.TextBox();
            this.TypetextBox = new System.Windows.Forms.TextBox();
            this.DescripttextBox = new System.Windows.Forms.TextBox();
            this.Descriptionlabel = new System.Windows.Forms.Label();
            this.classlabel = new System.Windows.Forms.Label();
            this.Timelabel = new System.Windows.Forms.Label();
            this.Toppanel.SuspendLayout();
            this.Addpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Toppanel
            // 
            this.Toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(150)))), ((int)(((byte)(227)))));
            this.Toppanel.Controls.Add(this.textBox1);
            this.Toppanel.Controls.Add(this.NTDlabel);
            this.Toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Toppanel.Location = new System.Drawing.Point(0, 0);
            this.Toppanel.Name = "Toppanel";
            this.Toppanel.Size = new System.Drawing.Size(457, 58);
            this.Toppanel.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Good Times", 15F);
            this.textBox1.Location = new System.Drawing.Point(131, 11);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 36);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "500";
            // 
            // NTDlabel
            // 
            this.NTDlabel.AutoSize = true;
            this.NTDlabel.Font = new System.Drawing.Font("Greek Diner Inline TT", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NTDlabel.ForeColor = System.Drawing.Color.White;
            this.NTDlabel.Location = new System.Drawing.Point(19, 12);
            this.NTDlabel.Name = "NTDlabel";
            this.NTDlabel.Size = new System.Drawing.Size(89, 43);
            this.NTDlabel.TabIndex = 7;
            this.NTDlabel.Text = "‎NT$";
            // 
            // Addpanel
            // 
            this.Addpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.Addpanel.Controls.Add(this.dataGridView1);
            this.Addpanel.Controls.Add(this.textBox2);
            this.Addpanel.Controls.Add(this.Confirmbutton);
            this.Addpanel.Controls.Add(this.TimetextBox);
            this.Addpanel.Controls.Add(this.TypetextBox);
            this.Addpanel.Controls.Add(this.DescripttextBox);
            this.Addpanel.Controls.Add(this.Descriptionlabel);
            this.Addpanel.Controls.Add(this.classlabel);
            this.Addpanel.Controls.Add(this.Timelabel);
            this.Addpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Addpanel.Location = new System.Drawing.Point(0, 58);
            this.Addpanel.Name = "Addpanel";
            this.Addpanel.Size = new System.Drawing.Size(457, 585);
            this.Addpanel.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 369);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(422, 179);
            this.dataGridView1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Good Times", 15F);
            this.textBox2.Location = new System.Drawing.Point(27, 311);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(93, 36);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "4";
            // 
            // Confirmbutton
            // 
            this.Confirmbutton.Font = new System.Drawing.Font("Good Times", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmbutton.Location = new System.Drawing.Point(126, 311);
            this.Confirmbutton.Name = "Confirmbutton";
            this.Confirmbutton.Size = new System.Drawing.Size(221, 36);
            this.Confirmbutton.TabIndex = 6;
            this.Confirmbutton.Text = "Confirm";
            this.Confirmbutton.UseVisualStyleBackColor = true;
            this.Confirmbutton.Click += new System.EventHandler(this.Confirmbutton_Click);
            // 
            // TimetextBox
            // 
            this.TimetextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.TimetextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimetextBox.Font = new System.Drawing.Font("Good Times", 15F);
            this.TimetextBox.Location = new System.Drawing.Point(27, 49);
            this.TimetextBox.Multiline = true;
            this.TimetextBox.Name = "TimetextBox";
            this.TimetextBox.Size = new System.Drawing.Size(422, 36);
            this.TimetextBox.TabIndex = 5;
            this.TimetextBox.Text = "20180618";
            // 
            // TypetextBox
            // 
            this.TypetextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.TypetextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TypetextBox.Font = new System.Drawing.Font("Good Times", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypetextBox.Location = new System.Drawing.Point(26, 136);
            this.TypetextBox.Multiline = true;
            this.TypetextBox.Name = "TypetextBox";
            this.TypetextBox.Size = new System.Drawing.Size(422, 36);
            this.TypetextBox.TabIndex = 4;
            this.TypetextBox.Text = "drink";
            // 
            // DescripttextBox
            // 
            this.DescripttextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.DescripttextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescripttextBox.Font = new System.Drawing.Font("Good Times", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripttextBox.Location = new System.Drawing.Point(27, 223);
            this.DescripttextBox.Multiline = true;
            this.DescripttextBox.Name = "DescripttextBox";
            this.DescripttextBox.Size = new System.Drawing.Size(422, 36);
            this.DescripttextBox.TabIndex = 3;
            this.DescripttextBox.Text = "tea";
            // 
            // Descriptionlabel
            // 
            this.Descriptionlabel.AutoSize = true;
            this.Descriptionlabel.Font = new System.Drawing.Font("Good Times", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descriptionlabel.ForeColor = System.Drawing.Color.White;
            this.Descriptionlabel.Location = new System.Drawing.Point(22, 197);
            this.Descriptionlabel.Name = "Descriptionlabel";
            this.Descriptionlabel.Size = new System.Drawing.Size(215, 23);
            this.Descriptionlabel.TabIndex = 2;
            this.Descriptionlabel.Text = "Description";
            // 
            // classlabel
            // 
            this.classlabel.AutoSize = true;
            this.classlabel.Font = new System.Drawing.Font("Good Times", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classlabel.ForeColor = System.Drawing.Color.White;
            this.classlabel.Location = new System.Drawing.Point(22, 110);
            this.classlabel.Name = "classlabel";
            this.classlabel.Size = new System.Drawing.Size(113, 23);
            this.classlabel.TabIndex = 1;
            this.classlabel.Text = "class";
            // 
            // Timelabel
            // 
            this.Timelabel.AutoSize = true;
            this.Timelabel.Font = new System.Drawing.Font("Good Times", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timelabel.ForeColor = System.Drawing.Color.White;
            this.Timelabel.Location = new System.Drawing.Point(22, 23);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(83, 23);
            this.Timelabel.TabIndex = 0;
            this.Timelabel.Text = "Time";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(457, 643);
            this.Controls.Add(this.Addpanel);
            this.Controls.Add(this.Toppanel);
            this.Name = "AddForm";
            this.Text = "Add";
            this.Toppanel.ResumeLayout(false);
            this.Toppanel.PerformLayout();
            this.Addpanel.ResumeLayout(false);
            this.Addpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Toppanel;
        private System.Windows.Forms.Panel Addpanel;
        private System.Windows.Forms.Label classlabel;
        private System.Windows.Forms.Label Timelabel;
        private System.Windows.Forms.TextBox TimetextBox;
        private System.Windows.Forms.TextBox TypetextBox;
        private System.Windows.Forms.TextBox DescripttextBox;
        private System.Windows.Forms.Label Descriptionlabel;
        private System.Windows.Forms.Label NTDlabel;
        private System.Windows.Forms.Button Confirmbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}