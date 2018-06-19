﻿namespace FinanceHero
{
    partial class Home
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Toppanel = new System.Windows.Forms.Panel();
            this.coinlabel = new System.Windows.Forms.Label();
            this.Coinicon = new System.Windows.Forms.PictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.Homepanel = new System.Windows.Forms.Panel();
            this.Addlabel = new System.Windows.Forms.Label();
            this.Recentspendlabel = new System.Windows.Forms.Label();
            this.datelabel3 = new System.Windows.Forms.Label();
            this.datelabel2 = new System.Windows.Forms.Label();
            this.datelabel1 = new System.Windows.Forms.Label();
            this.Addbutton = new System.Windows.Forms.Button();
            this.totalspend = new System.Windows.Forms.Label();
            this.examplelabel = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.databuttond3 = new System.Windows.Forms.Button();
            this.databuttond2 = new System.Windows.Forms.Button();
            this.databuttond1 = new System.Windows.Forms.Button();
            this.buttontitle = new System.Windows.Forms.Button();
            this.Homelabel = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Homebutton = new System.Windows.Forms.Button();
            this.Shopbutton = new System.Windows.Forms.Button();
            this.Herobutton = new System.Windows.Forms.Button();
            this.Statisbutton = new System.Windows.Forms.Button();
            this.Shoppanel = new System.Windows.Forms.Panel();
            this.Shoplabel = new System.Windows.Forms.Label();
            this.Heropanel = new System.Windows.Forms.Panel();
            this.Herolabel = new System.Windows.Forms.Label();
            this.Statispanel = new System.Windows.Forms.Panel();
            this.Chartlabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Statislabel = new System.Windows.Forms.Label();
            this.Spacepic = new System.Windows.Forms.PictureBox();
            this.Alienpic = new System.Windows.Forms.PictureBox();
            this.Toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Coinicon)).BeginInit();
            this.Homepanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.Shoppanel.SuspendLayout();
            this.Heropanel.SuspendLayout();
            this.Statispanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spacepic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alienpic)).BeginInit();
            this.SuspendLayout();
            // 
            // Toppanel
            // 
            this.Toppanel.BackColor = System.Drawing.Color.Gainsboro;
            this.Toppanel.Controls.Add(this.coinlabel);
            this.Toppanel.Controls.Add(this.Coinicon);
            this.Toppanel.Controls.Add(this.label_title);
            this.Toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Toppanel.Location = new System.Drawing.Point(0, 0);
            this.Toppanel.Margin = new System.Windows.Forms.Padding(2);
            this.Toppanel.Name = "Toppanel";
            this.Toppanel.Size = new System.Drawing.Size(512, 59);
            this.Toppanel.TabIndex = 0;
            // 
            // coinlabel
            // 
            this.coinlabel.AutoSize = true;
            this.coinlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinlabel.ForeColor = System.Drawing.Color.Coral;
            this.coinlabel.Location = new System.Drawing.Point(300, 16);
            this.coinlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.coinlabel.Name = "coinlabel";
            this.coinlabel.Size = new System.Drawing.Size(56, 25);
            this.coinlabel.TabIndex = 2;
            this.coinlabel.Text = "9527";
            // 
            // Coinicon
            // 
            this.Coinicon.Image = global::FinanceHero.Properties.Resources.coins__3_;
            this.Coinicon.Location = new System.Drawing.Point(256, 8);
            this.Coinicon.Margin = new System.Windows.Forms.Padding(2);
            this.Coinicon.Name = "Coinicon";
            this.Coinicon.Size = new System.Drawing.Size(40, 38);
            this.Coinicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Coinicon.TabIndex = 1;
            this.Coinicon.TabStop = false;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(9, 7);
            this.label_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(209, 37);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Finance Hero";
            // 
            // Homepanel
            // 
            this.Homepanel.BackColor = System.Drawing.Color.White;
            this.Homepanel.Controls.Add(this.Addlabel);
            this.Homepanel.Controls.Add(this.Recentspendlabel);
            this.Homepanel.Controls.Add(this.datelabel3);
            this.Homepanel.Controls.Add(this.datelabel2);
            this.Homepanel.Controls.Add(this.datelabel1);
            this.Homepanel.Controls.Add(this.Addbutton);
            this.Homepanel.Controls.Add(this.totalspend);
            this.Homepanel.Controls.Add(this.examplelabel);
            this.Homepanel.Controls.Add(this.datelabel);
            this.Homepanel.Controls.Add(this.databuttond3);
            this.Homepanel.Controls.Add(this.databuttond2);
            this.Homepanel.Controls.Add(this.databuttond1);
            this.Homepanel.Controls.Add(this.buttontitle);
            this.Homepanel.Controls.Add(this.Homelabel);
            this.Homepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Homepanel.Location = new System.Drawing.Point(0, 59);
            this.Homepanel.Margin = new System.Windows.Forms.Padding(2);
            this.Homepanel.Name = "Homepanel";
            this.Homepanel.Size = new System.Drawing.Size(512, 396);
            this.Homepanel.TabIndex = 2;
            // 
            // Addlabel
            // 
            this.Addlabel.AutoSize = true;
            this.Addlabel.Font = new System.Drawing.Font("Good Times Rg", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.Addlabel.Location = new System.Drawing.Point(255, 219);
            this.Addlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Addlabel.Name = "Addlabel";
            this.Addlabel.Size = new System.Drawing.Size(244, 25);
            this.Addlabel.TabIndex = 13;
            this.Addlabel.Text = "Add Your Spend";
            // 
            // Recentspendlabel
            // 
            this.Recentspendlabel.AutoSize = true;
            this.Recentspendlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Recentspendlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.Recentspendlabel.Location = new System.Drawing.Point(9, 58);
            this.Recentspendlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Recentspendlabel.Name = "Recentspendlabel";
            this.Recentspendlabel.Size = new System.Drawing.Size(148, 25);
            this.Recentspendlabel.TabIndex = 12;
            this.Recentspendlabel.Text = "Recent Spend";
            // 
            // datelabel3
            // 
            this.datelabel3.AutoSize = true;
            this.datelabel3.Font = new System.Drawing.Font("Good Times Rg", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabel3.Location = new System.Drawing.Point(14, 266);
            this.datelabel3.Name = "datelabel3";
            this.datelabel3.Size = new System.Drawing.Size(55, 14);
            this.datelabel3.TabIndex = 11;
            this.datelabel3.Text = "date3";
            // 
            // datelabel2
            // 
            this.datelabel2.AutoSize = true;
            this.datelabel2.Font = new System.Drawing.Font("Good Times Rg", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabel2.Location = new System.Drawing.Point(14, 206);
            this.datelabel2.Name = "datelabel2";
            this.datelabel2.Size = new System.Drawing.Size(55, 14);
            this.datelabel2.TabIndex = 10;
            this.datelabel2.Text = "date2";
            // 
            // datelabel1
            // 
            this.datelabel1.AutoSize = true;
            this.datelabel1.Font = new System.Drawing.Font("Good Times Rg", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabel1.Location = new System.Drawing.Point(13, 146);
            this.datelabel1.Name = "datelabel1";
            this.datelabel1.Size = new System.Drawing.Size(50, 14);
            this.datelabel1.TabIndex = 9;
            this.datelabel1.Text = "date1";
            // 
            // Addbutton
            // 
            this.Addbutton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.Addbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Addbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbutton.Font = new System.Drawing.Font("Good Times Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Addbutton.Location = new System.Drawing.Point(281, 279);
            this.Addbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(178, 44);
            this.Addbutton.TabIndex = 8;
            this.Addbutton.Text = " add new";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // totalspend
            // 
            this.totalspend.AutoSize = true;
            this.totalspend.Font = new System.Drawing.Font("Good Times Rg", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalspend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.totalspend.Location = new System.Drawing.Point(283, 57);
            this.totalspend.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalspend.Name = "totalspend";
            this.totalspend.Size = new System.Drawing.Size(208, 28);
            this.totalspend.TabIndex = 7;
            this.totalspend.Text = "Spend Total";
            // 
            // examplelabel
            // 
            this.examplelabel.AutoSize = true;
            this.examplelabel.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.examplelabel.Location = new System.Drawing.Point(136, 12);
            this.examplelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.examplelabel.Name = "examplelabel";
            this.examplelabel.Size = new System.Drawing.Size(148, 25);
            this.examplelabel.TabIndex = 6;
            this.examplelabel.Text = "用途/名稱/金額";
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.datelabel.Location = new System.Drawing.Point(138, 0);
            this.datelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(85, 15);
            this.datelabel.TabIndex = 5;
            this.datelabel.Text = "2018/6/16 (六)";
            // 
            // databuttond3
            // 
            this.databuttond3.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.databuttond3.Location = new System.Drawing.Point(16, 279);
            this.databuttond3.Margin = new System.Windows.Forms.Padding(2);
            this.databuttond3.Name = "databuttond3";
            this.databuttond3.Size = new System.Drawing.Size(178, 44);
            this.databuttond3.TabIndex = 4;
            this.databuttond3.Text = "data3";
            this.databuttond3.UseVisualStyleBackColor = true;
            // 
            // databuttond2
            // 
            this.databuttond2.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.databuttond2.Location = new System.Drawing.Point(16, 219);
            this.databuttond2.Margin = new System.Windows.Forms.Padding(2);
            this.databuttond2.Name = "databuttond2";
            this.databuttond2.Size = new System.Drawing.Size(178, 44);
            this.databuttond2.TabIndex = 3;
            this.databuttond2.Text = "data2";
            this.databuttond2.UseVisualStyleBackColor = true;
            // 
            // databuttond1
            // 
            this.databuttond1.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.databuttond1.Location = new System.Drawing.Point(16, 159);
            this.databuttond1.Margin = new System.Windows.Forms.Padding(2);
            this.databuttond1.Name = "databuttond1";
            this.databuttond1.Size = new System.Drawing.Size(178, 44);
            this.databuttond1.TabIndex = 2;
            this.databuttond1.Text = "data1";
            this.databuttond1.UseVisualStyleBackColor = true;
            // 
            // buttontitle
            // 
            this.buttontitle.Enabled = false;
            this.buttontitle.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttontitle.Location = new System.Drawing.Point(16, 97);
            this.buttontitle.Margin = new System.Windows.Forms.Padding(2);
            this.buttontitle.Name = "buttontitle";
            this.buttontitle.Size = new System.Drawing.Size(178, 44);
            this.buttontitle.TabIndex = 1;
            this.buttontitle.Text = "buttontitle";
            this.buttontitle.UseVisualStyleBackColor = true;
            // 
            // Homelabel
            // 
            this.Homelabel.AutoSize = true;
            this.Homelabel.Font = new System.Drawing.Font("Good Times Rg", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Homelabel.Location = new System.Drawing.Point(9, 7);
            this.Homelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Homelabel.Name = "Homelabel";
            this.Homelabel.Size = new System.Drawing.Size(131, 37);
            this.Homelabel.TabIndex = 0;
            this.Homelabel.Text = "Home";
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.BottomPanel.Controls.Add(this.Homebutton);
            this.BottomPanel.Controls.Add(this.Shopbutton);
            this.BottomPanel.Controls.Add(this.Herobutton);
            this.BottomPanel.Controls.Add(this.Statisbutton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 455);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(2);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(512, 67);
            this.BottomPanel.TabIndex = 1;
            // 
            // Homebutton
            // 
            this.Homebutton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.Homebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Homebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Homebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Homebutton.Font = new System.Drawing.Font("Good Times Rg", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Homebutton.Location = new System.Drawing.Point(2, 2);
            this.Homebutton.Margin = new System.Windows.Forms.Padding(2);
            this.Homebutton.Name = "Homebutton";
            this.Homebutton.Size = new System.Drawing.Size(122, 65);
            this.Homebutton.TabIndex = 0;
            this.Homebutton.Text = "Home";
            this.Homebutton.UseVisualStyleBackColor = true;
            this.Homebutton.Click += new System.EventHandler(this.Homebutton_Click);
            // 
            // Shopbutton
            // 
            this.Shopbutton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.Shopbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Shopbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Shopbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Shopbutton.Font = new System.Drawing.Font("Good Times Rg", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shopbutton.Location = new System.Drawing.Point(128, 2);
            this.Shopbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Shopbutton.Name = "Shopbutton";
            this.Shopbutton.Size = new System.Drawing.Size(122, 65);
            this.Shopbutton.TabIndex = 1;
            this.Shopbutton.Text = "Shop";
            this.Shopbutton.UseVisualStyleBackColor = true;
            this.Shopbutton.Click += new System.EventHandler(this.Shopbutton_Click);
            // 
            // Herobutton
            // 
            this.Herobutton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.Herobutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Herobutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Herobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Herobutton.Font = new System.Drawing.Font("Good Times Rg", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Herobutton.Location = new System.Drawing.Point(254, 2);
            this.Herobutton.Margin = new System.Windows.Forms.Padding(2);
            this.Herobutton.Name = "Herobutton";
            this.Herobutton.Size = new System.Drawing.Size(122, 65);
            this.Herobutton.TabIndex = 2;
            this.Herobutton.Text = "Hero";
            this.Herobutton.UseVisualStyleBackColor = true;
            this.Herobutton.Click += new System.EventHandler(this.Herobutton_Click);
            // 
            // Statisbutton
            // 
            this.Statisbutton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.Statisbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Statisbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Statisbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Statisbutton.Font = new System.Drawing.Font("Good Times Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statisbutton.Location = new System.Drawing.Point(380, 2);
            this.Statisbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Statisbutton.Name = "Statisbutton";
            this.Statisbutton.Size = new System.Drawing.Size(127, 65);
            this.Statisbutton.TabIndex = 3;
            this.Statisbutton.Text = "statistical ";
            this.Statisbutton.UseVisualStyleBackColor = true;
            this.Statisbutton.Click += new System.EventHandler(this.Statisbutton_Click);
            // 
            // Shoppanel
            // 
            this.Shoppanel.BackColor = System.Drawing.Color.White;
            this.Shoppanel.Controls.Add(this.Shoplabel);
            this.Shoppanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Shoppanel.Location = new System.Drawing.Point(0, 59);
            this.Shoppanel.Margin = new System.Windows.Forms.Padding(2);
            this.Shoppanel.Name = "Shoppanel";
            this.Shoppanel.Size = new System.Drawing.Size(512, 396);
            this.Shoppanel.TabIndex = 3;
            // 
            // Shoplabel
            // 
            this.Shoplabel.AutoSize = true;
            this.Shoplabel.Font = new System.Drawing.Font("Good Times Rg", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shoplabel.Location = new System.Drawing.Point(9, 7);
            this.Shoplabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Shoplabel.Name = "Shoplabel";
            this.Shoplabel.Size = new System.Drawing.Size(127, 37);
            this.Shoplabel.TabIndex = 0;
            this.Shoplabel.Text = "Shop";
            // 
            // Heropanel
            // 
            this.Heropanel.BackColor = System.Drawing.Color.Transparent;
            this.Heropanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Heropanel.BackgroundImage")));
            this.Heropanel.Controls.Add(this.Alienpic);
            this.Heropanel.Controls.Add(this.Spacepic);
            this.Heropanel.Controls.Add(this.Herolabel);
            this.Heropanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Heropanel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Heropanel.Location = new System.Drawing.Point(0, 59);
            this.Heropanel.Margin = new System.Windows.Forms.Padding(2);
            this.Heropanel.Name = "Heropanel";
            this.Heropanel.Size = new System.Drawing.Size(512, 396);
            this.Heropanel.TabIndex = 4;
            // 
            // Herolabel
            // 
            this.Herolabel.AutoSize = true;
            this.Herolabel.BackColor = System.Drawing.Color.Transparent;
            this.Herolabel.Font = new System.Drawing.Font("Good Times Rg", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Herolabel.ForeColor = System.Drawing.Color.White;
            this.Herolabel.Location = new System.Drawing.Point(9, 7);
            this.Herolabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Herolabel.Name = "Herolabel";
            this.Herolabel.Size = new System.Drawing.Size(125, 37);
            this.Herolabel.TabIndex = 0;
            this.Herolabel.Text = "Hero";
            // 
            // Statispanel
            // 
            this.Statispanel.BackColor = System.Drawing.Color.White;
            this.Statispanel.Controls.Add(this.Chartlabel);
            this.Statispanel.Controls.Add(this.chart1);
            this.Statispanel.Controls.Add(this.Statislabel);
            this.Statispanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Statispanel.Location = new System.Drawing.Point(0, 59);
            this.Statispanel.Margin = new System.Windows.Forms.Padding(2);
            this.Statispanel.Name = "Statispanel";
            this.Statispanel.Size = new System.Drawing.Size(512, 396);
            this.Statispanel.TabIndex = 5;
            // 
            // Chartlabel
            // 
            this.Chartlabel.AutoSize = true;
            this.Chartlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chartlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.Chartlabel.Location = new System.Drawing.Point(11, 81);
            this.Chartlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Chartlabel.Name = "Chartlabel";
            this.Chartlabel.Size = new System.Drawing.Size(191, 29);
            this.Chartlabel.TabIndex = 14;
            this.Chartlabel.Text = "See Your Spend";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(15, 112);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(269, 280);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // Statislabel
            // 
            this.Statislabel.AutoSize = true;
            this.Statislabel.Font = new System.Drawing.Font("Good Times Rg", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statislabel.Location = new System.Drawing.Point(0, 0);
            this.Statislabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Statislabel.Name = "Statislabel";
            this.Statislabel.Size = new System.Drawing.Size(255, 37);
            this.Statislabel.TabIndex = 0;
            this.Statislabel.Text = "Statistical";
            // 
            // Spacepic
            // 
            this.Spacepic.Location = new System.Drawing.Point(224, 279);
            this.Spacepic.Name = "Spacepic";
            this.Spacepic.Size = new System.Drawing.Size(72, 65);
            this.Spacepic.TabIndex = 1;
            this.Spacepic.TabStop = false;
            // 
            // Alienpic
            // 
            this.Alienpic.Location = new System.Drawing.Point(179, 69);
            this.Alienpic.Name = "Alienpic";
            this.Alienpic.Size = new System.Drawing.Size(168, 151);
            this.Alienpic.TabIndex = 2;
            this.Alienpic.TabStop = false;
            this.Alienpic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Alienpic_MouseDown);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 522);
            this.Controls.Add(this.Heropanel);
            this.Controls.Add(this.Homepanel);
            this.Controls.Add(this.Shoppanel);
            this.Controls.Add(this.Statispanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.Toppanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "Home";
            this.Toppanel.ResumeLayout(false);
            this.Toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Coinicon)).EndInit();
            this.Homepanel.ResumeLayout(false);
            this.Homepanel.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.Shoppanel.ResumeLayout(false);
            this.Shoppanel.PerformLayout();
            this.Heropanel.ResumeLayout(false);
            this.Heropanel.PerformLayout();
            this.Statispanel.ResumeLayout(false);
            this.Statispanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spacepic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alienpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Toppanel;
        private System.Windows.Forms.Panel Homepanel;
        private System.Windows.Forms.Label Homelabel;
        private System.Windows.Forms.FlowLayoutPanel BottomPanel;
        private System.Windows.Forms.Button Homebutton;
        private System.Windows.Forms.Button Shopbutton;
        private System.Windows.Forms.Button Herobutton;
        private System.Windows.Forms.Button Statisbutton;
        private System.Windows.Forms.Panel Shoppanel;
        private System.Windows.Forms.Label Shoplabel;
        private System.Windows.Forms.Panel Heropanel;
        private System.Windows.Forms.Label Herolabel;
        private System.Windows.Forms.Panel Statispanel;
        private System.Windows.Forms.Label Statislabel;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.PictureBox Coinicon;
        private System.Windows.Forms.Label coinlabel;
        private System.Windows.Forms.Button buttontitle;
        private System.Windows.Forms.Button databuttond2;
        private System.Windows.Forms.Button databuttond1;
        private System.Windows.Forms.Button databuttond3;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Label examplelabel;
        private System.Windows.Forms.Label totalspend;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Label datelabel3;
        private System.Windows.Forms.Label datelabel2;
        private System.Windows.Forms.Label datelabel1;
        private System.Windows.Forms.Label Recentspendlabel;
        private System.Windows.Forms.Label Addlabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label Chartlabel;
        private System.Windows.Forms.PictureBox Alienpic;
        private System.Windows.Forms.PictureBox Spacepic;
    }
}

