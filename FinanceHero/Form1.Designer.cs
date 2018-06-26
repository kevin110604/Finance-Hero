namespace FinanceHero
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Toppanel = new System.Windows.Forms.Panel();
            this.coinlabel = new System.Windows.Forms.Label();
            this.Coinicon = new System.Windows.Forms.PictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.Homepanel = new System.Windows.Forms.Panel();
            this.Addlabel = new System.Windows.Forms.Label();
            this.Addbutton = new System.Windows.Forms.Button();
            this.totalspend = new System.Windows.Forms.Label();
            this.examplelabel = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Homebutton = new System.Windows.Forms.Button();
            this.Shopbutton = new System.Windows.Forms.Button();
            this.Herobutton = new System.Windows.Forms.Button();
            this.Statisbutton = new System.Windows.Forms.Button();
            this.Shoppanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Buybutton = new System.Windows.Forms.Button();
            this.NextBuypic = new System.Windows.Forms.PictureBox();
            this.Shoplabel = new System.Windows.Forms.Label();
            this.Heropanel = new System.Windows.Forms.Panel();
            this.HPlabel = new System.Windows.Forms.Label();
            this.Alienpic = new System.Windows.Forms.PictureBox();
            this.Spacepic = new System.Windows.Forms.PictureBox();
            this.Herolabel = new System.Windows.Forms.Label();
            this.Statispanel = new System.Windows.Forms.Panel();
            this.Chartlabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Statislabel = new System.Windows.Forms.Label();
            this.NextLevellabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NextATKlabel = new System.Windows.Forms.Label();
            this.Nowpic = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NowLevellabel = new System.Windows.Forms.Label();
            this.NowATKlabel = new System.Windows.Forms.Label();
            this.Toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Coinicon)).BeginInit();
            this.Homepanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.Shoppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NextBuypic)).BeginInit();
            this.Heropanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Alienpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spacepic)).BeginInit();
            this.Statispanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nowpic)).BeginInit();
            this.SuspendLayout();
            // 
            // Toppanel
            // 
            this.Toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(150)))), ((int)(((byte)(227)))));
            this.Toppanel.Controls.Add(this.coinlabel);
            this.Toppanel.Controls.Add(this.Coinicon);
            this.Toppanel.Controls.Add(this.label_title);
            this.Toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Toppanel.Location = new System.Drawing.Point(0, 0);
            this.Toppanel.Margin = new System.Windows.Forms.Padding(2);
            this.Toppanel.Name = "Toppanel";
            this.Toppanel.Size = new System.Drawing.Size(512, 59);
            this.Toppanel.TabIndex = 0;
            this.Toppanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Toppanel_Paint);
            // 
            // coinlabel
            // 
            this.coinlabel.AutoSize = true;
            this.coinlabel.Font = new System.Drawing.Font("Good Times Rg", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinlabel.ForeColor = System.Drawing.Color.Coral;
            this.coinlabel.Location = new System.Drawing.Point(360, 20);
            this.coinlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.coinlabel.Name = "coinlabel";
            this.coinlabel.Size = new System.Drawing.Size(77, 24);
            this.coinlabel.TabIndex = 2;
            this.coinlabel.Text = "9527";
            // 
            // Coinicon
            // 
            this.Coinicon.Image = global::FinanceHero.Properties.Resources.coins__3_;
            this.Coinicon.Location = new System.Drawing.Point(316, 7);
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
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.label_title.Location = new System.Drawing.Point(9, 7);
            this.label_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(209, 37);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Finance Hero";
            // 
            // Homepanel
            // 
            this.Homepanel.AutoScroll = true;
            this.Homepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.Homepanel.Controls.Add(this.Addlabel);
            this.Homepanel.Controls.Add(this.Addbutton);
            this.Homepanel.Controls.Add(this.totalspend);
            this.Homepanel.Controls.Add(this.examplelabel);
            this.Homepanel.Controls.Add(this.datelabel);
            this.Homepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Homepanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.Homepanel.Location = new System.Drawing.Point(0, 59);
            this.Homepanel.Margin = new System.Windows.Forms.Padding(2);
            this.Homepanel.Name = "Homepanel";
            this.Homepanel.Size = new System.Drawing.Size(512, 396);
            this.Homepanel.TabIndex = 2;
            this.Homepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Homepanel_Paint);
            // 
            // Addlabel
            // 
            this.Addlabel.AutoSize = true;
            this.Addlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.Addlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addlabel.ForeColor = System.Drawing.Color.White;
            this.Addlabel.Location = new System.Drawing.Point(11, 84);
            this.Addlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Addlabel.Name = "Addlabel";
            this.Addlabel.Size = new System.Drawing.Size(208, 29);
            this.Addlabel.TabIndex = 13;
            this.Addlabel.Text = "Show Your Spend";
            // 
            // Addbutton
            // 
            this.Addbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Addbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Addbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.ForeColor = System.Drawing.Color.White;
            this.Addbutton.Location = new System.Drawing.Point(356, 66);
            this.Addbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(110, 44);
            this.Addbutton.TabIndex = 8;
            this.Addbutton.Text = "Add Spend";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // totalspend
            // 
            this.totalspend.AutoSize = true;
            this.totalspend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.totalspend.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalspend.ForeColor = System.Drawing.Color.White;
            this.totalspend.Location = new System.Drawing.Point(3, 7);
            this.totalspend.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalspend.Name = "totalspend";
            this.totalspend.Size = new System.Drawing.Size(153, 73);
            this.totalspend.TabIndex = 7;
            this.totalspend.Text = "‎NT$";
            // 
            // examplelabel
            // 
            this.examplelabel.AutoSize = true;
            this.examplelabel.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.examplelabel.Location = new System.Drawing.Point(134, 20);
            this.examplelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.examplelabel.Name = "examplelabel";
            this.examplelabel.Size = new System.Drawing.Size(0, 25);
            this.examplelabel.TabIndex = 6;
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.datelabel.Location = new System.Drawing.Point(136, 7);
            this.datelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(0, 15);
            this.datelabel.TabIndex = 5;
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(150)))), ((int)(((byte)(227)))));
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
            this.Homebutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(150)))), ((int)(((byte)(227)))));
            this.Homebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Homebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Homebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Homebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Shopbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(150)))), ((int)(((byte)(227)))));
            this.Shopbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Shopbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Shopbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Shopbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Herobutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(150)))), ((int)(((byte)(227)))));
            this.Herobutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Herobutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Herobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Herobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Statisbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(150)))), ((int)(((byte)(227)))));
            this.Statisbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Statisbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Statisbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Statisbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Shoppanel.Controls.Add(this.NowATKlabel);
            this.Shoppanel.Controls.Add(this.NowLevellabel);
            this.Shoppanel.Controls.Add(this.label6);
            this.Shoppanel.Controls.Add(this.Nowpic);
            this.Shoppanel.Controls.Add(this.NextATKlabel);
            this.Shoppanel.Controls.Add(this.label4);
            this.Shoppanel.Controls.Add(this.label3);
            this.Shoppanel.Controls.Add(this.NextLevellabel);
            this.Shoppanel.Controls.Add(this.label1);
            this.Shoppanel.Controls.Add(this.Buybutton);
            this.Shoppanel.Controls.Add(this.NextBuypic);
            this.Shoppanel.Controls.Add(this.Shoplabel);
            this.Shoppanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Shoppanel.Font = new System.Drawing.Font("Good Times Rg", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shoppanel.Location = new System.Drawing.Point(0, 59);
            this.Shoppanel.Margin = new System.Windows.Forms.Padding(2);
            this.Shoppanel.Name = "Shoppanel";
            this.Shoppanel.Size = new System.Drawing.Size(512, 396);
            this.Shoppanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Good Times Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // Buybutton
            // 
            this.Buybutton.Font = new System.Drawing.Font("Good Times Rg", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buybutton.Location = new System.Drawing.Point(171, 350);
            this.Buybutton.Margin = new System.Windows.Forms.Padding(2);
            this.Buybutton.Name = "Buybutton";
            this.Buybutton.Size = new System.Drawing.Size(166, 29);
            this.Buybutton.TabIndex = 7;
            this.Buybutton.Text = "Buy";
            this.Buybutton.UseVisualStyleBackColor = true;
            this.Buybutton.Click += new System.EventHandler(this.Buybutton_Click);
            // 
            // NextBuypic
            // 
            this.NextBuypic.Location = new System.Drawing.Point(150, 61);
            this.NextBuypic.Name = "NextBuypic";
            this.NextBuypic.Size = new System.Drawing.Size(200, 200);
            this.NextBuypic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NextBuypic.TabIndex = 1;
            this.NextBuypic.TabStop = false;
            // 
            // Shoplabel
            // 
            this.Shoplabel.AutoSize = true;
            this.Shoplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shoplabel.Location = new System.Drawing.Point(9, 7);
            this.Shoplabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Shoplabel.Name = "Shoplabel";
            this.Shoplabel.Size = new System.Drawing.Size(87, 35);
            this.Shoplabel.TabIndex = 0;
            this.Shoplabel.Text = "Shop";
            // 
            // Heropanel
            // 
            this.Heropanel.BackColor = System.Drawing.Color.Transparent;
            this.Heropanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Heropanel.BackgroundImage")));
            this.Heropanel.Controls.Add(this.HPlabel);
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
            this.Heropanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Heropanel_MouseDown);
            // 
            // HPlabel
            // 
            this.HPlabel.AutoSize = true;
            this.HPlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HPlabel.Location = new System.Drawing.Point(345, 29);
            this.HPlabel.Name = "HPlabel";
            this.HPlabel.Size = new System.Drawing.Size(79, 29);
            this.HPlabel.TabIndex = 3;
            this.HPlabel.Text = "label1";
            // 
            // Alienpic
            // 
            this.Alienpic.Location = new System.Drawing.Point(192, 12);
            this.Alienpic.Name = "Alienpic";
            this.Alienpic.Size = new System.Drawing.Size(128, 78);
            this.Alienpic.TabIndex = 2;
            this.Alienpic.TabStop = false;
            this.Alienpic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Heropanel_MouseDown);
            // 
            // Spacepic
            // 
            this.Spacepic.Location = new System.Drawing.Point(221, 317);
            this.Spacepic.Name = "Spacepic";
            this.Spacepic.Size = new System.Drawing.Size(63, 52);
            this.Spacepic.TabIndex = 1;
            this.Spacepic.TabStop = false;
            // 
            // Herolabel
            // 
            this.Herolabel.AutoSize = true;
            this.Herolabel.BackColor = System.Drawing.Color.Transparent;
            this.Herolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Herolabel.ForeColor = System.Drawing.Color.White;
            this.Herolabel.Location = new System.Drawing.Point(9, 7);
            this.Herolabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Herolabel.Name = "Herolabel";
            this.Herolabel.Size = new System.Drawing.Size(81, 35);
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
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(15, 112);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series5.BorderColor = System.Drawing.Color.Transparent;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series5.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.IsXValueIndexed = true;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(269, 280);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // Statislabel
            // 
            this.Statislabel.AutoSize = true;
            this.Statislabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statislabel.Location = new System.Drawing.Point(8, 7);
            this.Statislabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Statislabel.Name = "Statislabel";
            this.Statislabel.Size = new System.Drawing.Size(150, 35);
            this.Statislabel.TabIndex = 0;
            this.Statislabel.Text = "Statistical";
            // 
            // NextLevellabel
            // 
            this.NextLevellabel.AutoSize = true;
            this.NextLevellabel.Font = new System.Drawing.Font("Good Times Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextLevellabel.Location = new System.Drawing.Point(218, 264);
            this.NextLevellabel.Name = "NextLevellabel";
            this.NextLevellabel.Size = new System.Drawing.Size(71, 19);
            this.NextLevellabel.TabIndex = 9;
            this.NextLevellabel.Text = "Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Good Times Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "ATK:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Good Times Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Price:";
            // 
            // NextATKlabel
            // 
            this.NextATKlabel.AutoSize = true;
            this.NextATKlabel.Font = new System.Drawing.Font("Good Times Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextATKlabel.Location = new System.Drawing.Point(233, 322);
            this.NextATKlabel.Name = "NextATKlabel";
            this.NextATKlabel.Size = new System.Drawing.Size(87, 19);
            this.NextATKlabel.TabIndex = 12;
            this.NextATKlabel.Text = "label5";
            // 
            // Nowpic
            // 
            this.Nowpic.Location = new System.Drawing.Point(428, 12);
            this.Nowpic.Name = "Nowpic";
            this.Nowpic.Size = new System.Drawing.Size(70, 70);
            this.Nowpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Nowpic.TabIndex = 13;
            this.Nowpic.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Good Times Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(428, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "ATK:";
            // 
            // NowLevellabel
            // 
            this.NowLevellabel.AutoSize = true;
            this.NowLevellabel.Font = new System.Drawing.Font("Good Times Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NowLevellabel.Location = new System.Drawing.Point(439, 85);
            this.NowLevellabel.Name = "NowLevellabel";
            this.NowLevellabel.Size = new System.Drawing.Size(50, 13);
            this.NowLevellabel.TabIndex = 16;
            this.NowLevellabel.Text = "Level";
            // 
            // NowATKlabel
            // 
            this.NowATKlabel.AutoSize = true;
            this.NowATKlabel.Font = new System.Drawing.Font("Good Times Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NowATKlabel.Location = new System.Drawing.Point(474, 112);
            this.NowATKlabel.Name = "NowATKlabel";
            this.NowATKlabel.Size = new System.Drawing.Size(15, 13);
            this.NowATKlabel.TabIndex = 17;
            this.NowATKlabel.Text = "l";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 522);
            this.Controls.Add(this.Homepanel);
            this.Controls.Add(this.Shoppanel);
            this.Controls.Add(this.Heropanel);
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
            ((System.ComponentModel.ISupportInitialize)(this.NextBuypic)).EndInit();
            this.Heropanel.ResumeLayout(false);
            this.Heropanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Alienpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spacepic)).EndInit();
            this.Statispanel.ResumeLayout(false);
            this.Statispanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nowpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Toppanel;
        private System.Windows.Forms.Panel Homepanel;
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
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Label examplelabel;
        private System.Windows.Forms.Label totalspend;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label Chartlabel;
        private System.Windows.Forms.PictureBox Alienpic;
        private System.Windows.Forms.PictureBox Spacepic;
        private System.Windows.Forms.Label HPlabel;
        private System.Windows.Forms.Label Addlabel;
        private System.Windows.Forms.PictureBox NextBuypic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Buybutton;
        private System.Windows.Forms.Label NowATKlabel;
        private System.Windows.Forms.Label NowLevellabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox Nowpic;
        private System.Windows.Forms.Label NextATKlabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NextLevellabel;
    }
}

