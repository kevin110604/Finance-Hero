using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;        //引用System.Data.SqlClient命名空間
using System.Media;                 //play sound required

namespace FinanceHero
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        int Toppanel_load_once = 0;
        private void Toppanel_Paint(object sender, PaintEventArgs e)
        {
            if (Toppanel_load_once == 0)
            {
                load_record();
                coinlabel.Text = "" + Coin;
                Toppanel_load_once++;
            }
        }

        int Homepanel_load_once = 0;
        private void Homepanel_Paint(object sender, PaintEventArgs e)
        {
            if (Homepanel_load_once == 0)
            {
                create_spend_Label();
                Homepanel_load_once++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Homebutton_Click(sender, e);

            // set panel visable
            Homepanel.Visible = true;
            Shoppanel.Visible = false;
            Heropanel.Visible = false;
            Statispanel.Visible = false;
        }

        private void Homebutton_Click(object sender, EventArgs e)
        {
            Homepanel.Visible = true;
            Shoppanel.Visible = false;
            Heropanel.Visible = false;
            Statispanel.Visible = false;
        }

        private void Shopbutton_Click(object sender, EventArgs e)
        {
            Homepanel.Visible = false;
            Shoppanel.Visible = true;
            Heropanel.Visible = false;
            Statispanel.Visible = false;

            load_shop();
        }

        private void Herobutton_Click(object sender, EventArgs e)
        {
            Homepanel.Visible = false;
            Shoppanel.Visible = false;
            Heropanel.Visible = true;
            Statispanel.Visible = false;

            load_game();
        }

        int only_once = 0;
        private void Statisbutton_Click(object sender, EventArgs e)
        {
            Homepanel.Visible = false;
            Shoppanel.Visible = false;
            Heropanel.Visible = false;
            Statispanel.Visible = true;

            if (only_once < 1)
            {
                load_chart();
                only_once++;
            }
        }

        /*** Top ***/
        int AlienLevel, AlienHP, SpaceLevel, SpaceLATK, SpaceHATK, Coin;
        private void load_record()
        {
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|account.mdf;" +
                "Integrated Security=True";                     //設為True 指定使用Windows 帳號認證連接資料庫
            SqlConnection db = new SqlConnection(cn);           //建立連接物件    
            SqlCommand cmd = new SqlCommand
                ("SELECT * FROM 遊戲紀錄", db);

            try
            {
                db.Open();                                      //使用Open方法開啟和資料庫的連接
                SqlDataReader dr = cmd.ExecuteReader();

                string column_name = "";                        //用不到的column標題
                for (int i = 0; i < dr.FieldCount; i++)         //讀column標題
                {
                    column_name += dr.GetName(i) + "  ";
                }

                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        if (i == 1)
                        {
                            AlienLevel = int.Parse(dr[i].ToString());
                        }
                        else if (i == 2)
                        {
                            AlienHP = int.Parse(dr[i].ToString());
                        }
                        else if (i == 3)
                        {
                            SpaceLevel = int.Parse(dr[i].ToString());
                        }
                        else if (i == 4)
                        {
                            SpaceLATK = int.Parse(dr[i].ToString());
                        }
                        else if (i == 5)
                        {
                            SpaceHATK = int.Parse(dr[i].ToString());
                        }
                        else if (i == 6)
                        {
                            Coin = int.Parse(dr[i].ToString());
                        }
                    }
                }
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void save_game_records()
        {
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|account.mdf;" +
                "Integrated Security=True";                     //設為True 指定使用Windows 帳號認證連接資料庫
            SqlConnection db = new SqlConnection(cn);           //建立連接物件    
            SqlCommand cmd = new SqlCommand
                ("UPDATE 遊戲紀錄 SET AlienLevel = " + AlienLevel +
                ", AlienHP = " + AlienHP +
                ", SpaceLevel = " + SpaceLevel +
                ", SpaceLATK = " + SpaceLATK +
                ", SpaceHATK = " + SpaceHATK +
                ", Coin = " + Coin + "WHERE virtualkey = 1", db);

            try
            {
                db.Open();                                      //使用Open方法開啟和資料庫的連接
                cmd.ExecuteNonQuery();
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        /*** Home ***/
        private void Addbutton_Click(object sender, EventArgs e)
        {
            AddForm addf = new AddForm();
            addf.Show();
        }

        private void create_spend_Label()
        {
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|account.mdf;" +
                "Integrated Security=True";                     //設為True 指定使用Windows 帳號認證連接資料庫
            SqlConnection db = new SqlConnection(cn);           //建立連接物件    
            SqlCommand cmd = new SqlCommand
                ("SELECT * FROM 記帳 ORDER BY date DESC", db);

            try
            {
                db.Open();                                      //使用Open方法開啟和資料庫的連接
                SqlDataReader dr = cmd.ExecuteReader();

                string column_name = "";                        //用不到的column標題
                for (int i = 0; i < dr.FieldCount; i++)         //讀column標題
                {
                    column_name += dr.GetName(i) + "  ";
                }

                Label[] L1 = new Label[30];
                Label[] L2 = new Label[30];
                Label[] LD = new Label[30];
                int index = 0;
                string dateStr, classStr, desStr, MoneyStr;
                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        if (i == 1)
                        {
                            dateStr = dr[i].ToString();
                            LD[index] = set_DateLabel_property(15, 155 + index * 50, 370);
                            Homepanel.Controls.Add(LD[index]);
                            LD[index].Text = " " + dateStr;
                        }
                        else if (i == 2)
                        {
                            classStr = dr[i].ToString();
                            L1[index] = set_Label_property(15, 170 + index * 50, 370);
                            Homepanel.Controls.Add(L1[index]);
                            L1[index].Text = " " + classStr;

                        }
                        else if (i == 3)
                        {
                            desStr = dr[i].ToString();
                            L1[index].Text += "  " + desStr;
                        }
                        else if (i == 4)
                        {
                            MoneyStr = dr[i].ToString();
                            L2[index] = set_MoneyLabel_property(385, 170 + index * 50, 80);
                            L2[index].Text += "$" + MoneyStr;
                            Homepanel.Controls.Add(L2[index]);

                            index++;
                        }
                    }
                }
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Label set_Label_property(int x, int y, int w)
        {
            Label Q = new Label();
            Q.Width = w;
            Q.Height = 35;
            Q.BackColor = Color.Gray;
            Q.Left = x;
            Q.Top = y;
            Q.TextAlign = ContentAlignment.MiddleLeft;
            Q.Font = new Font("微軟正黑體", 12, FontStyle.Regular);

            return Q;
        }

        private Label set_MoneyLabel_property(int x, int y, int w)
        {
            Label Q = new Label();
            Q.Width = w;
            Q.Height = 35;
            Q.BackColor = Color.Gray;
            Q.Left = x;
            Q.Top = y;
            Q.TextAlign = ContentAlignment.MiddleRight;
            Q.Font = new Font("微軟正黑體", 12, FontStyle.Regular);

            return Q;
        }

        private Label set_DateLabel_property(int x, int y, int w)
        {
            Label Q = new Label();
            Q.Width = w;
            Q.Height = 15;
            Q.BackColor = Color.Transparent;
            Q.ForeColor = Color.White;
            Q.Left = x;
            Q.Top = y;
            Q.TextAlign = ContentAlignment.MiddleLeft;
            Q.Font = new Font("Calibri", 10, FontStyle.Regular);

            return Q;
        }


        /*** Shop ***/
        int Space_price2 = 0, HATK2 = 0;
        string spacefile_name1 = "", spacefile_name2 = "";
        private void load_shop()
        {
            /* Now Level */
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|account.mdf;" +
                "Integrated Security=True";                     //設為True 指定使用Windows 帳號認證連接資料庫
            SqlConnection db = new SqlConnection(cn);           //建立連接物件
            SqlCommand cmd = new SqlCommand
                ("SELECT * FROM 飛船 WHERE level = " + SpaceLevel, db);
            try
            {
                db.Open();                                      //使用Open方法開啟和資料庫的連接
                SqlDataReader dr = cmd.ExecuteReader();

                string column_name = "";                        //用不到的column標題
                for (int i = 0; i < dr.FieldCount; i++)         //讀column標題
                {
                    column_name += dr.GetName(i) + "  ";
                }

                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        if (i == 1)
                        {
                            SpaceLATK = int.Parse(dr[i].ToString());
                        }
                        else if (i == 2)
                        {
                            SpaceHATK = int.Parse(dr[i].ToString());
                        }
                        else if (i == 3)
                        {
                            //Space_price1 = int.Parse(dr[i].ToString());
                        }
                        else if (i == 4)
                        {
                            spacefile_name1 = dr[i].ToString();
                        }
                    }
                }
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            /* Next Level */
            SqlCommand cmd2 = new SqlCommand
                ("SELECT * FROM 飛船 WHERE level = " + (SpaceLevel+1), db);

            try
            {
                db.Open();                                      //使用Open方法開啟和資料庫的連接
                SqlDataReader dr = cmd2.ExecuteReader();

                string column_name = "";                        //用不到的column標題
                for (int i = 0; i < dr.FieldCount; i++)         //讀column標題
                {
                    column_name += dr.GetName(i) + "  ";
                }

                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        if (i == 1)
                        {
                            
                        }
                        else if (i == 2)
                        {
                            HATK2 = int.Parse(dr[i].ToString());
                        }
                        else if (i == 3)
                        {
                            Space_price2 = int.Parse(dr[i].ToString());
                        }
                        else if (i == 4)
                        {
                            spacefile_name2 = dr[i].ToString();
                        }
                    }
                }
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            spacefile_name1 = @"..\..\Resources\" + spacefile_name1;
            Nowpic.Image = Image.FromFile(spacefile_name1);
            NowLevellabel.Text = "LEVEL" + SpaceLevel;
            NowATKlabel.Text = "" + SpaceHATK;

            spacefile_name2 = @"..\..\Resources\" + spacefile_name2;
            NextBuypic.Image = Image.FromFile(spacefile_name2);
            label1.Text = "" + Space_price2;
            NextLevellabel.Text = "LEVEL" + (SpaceLevel+1);
            NextATKlabel.Text = "" + HATK2;

        }

        private void Buybutton_Click(object sender, EventArgs e)
        {
            if (Space_price2 <= Coin)
            {
                SpaceLevel++;
                Coin -= Space_price2;
                coinlabel.Text = "" + Coin;
                load_shop();                                    //取得新的飛船攻擊
                save_game_records();                            //將遊戲紀錄存回資料庫
            }
            else
            {
                MessageBox.Show("金幣不足ㄛ");
            }
        }

        private void SpaceShip_levelup()
        {

        }

        /*** Hero ***/
        private void load_game()
        {


            /* image */
            string spacefile_name = "";
            string cn2 = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|account.mdf;" +
                "Integrated Security=True";                     //設為True 指定使用Windows 帳號認證連接資料庫
            SqlConnection db2 = new SqlConnection(cn2);         //建立連接物件    
            SqlCommand cmd2 = new SqlCommand
                ("SELECT * FROM 飛船 WHERE level = " + SpaceLevel, db2);

            try
            {
                db2.Open();                                     //使用Open方法開啟和資料庫的連接
                SqlDataReader dr = cmd2.ExecuteReader();

                string column_name = "";                        //用不到的column標題
                for (int i = 0; i < dr.FieldCount; i++)         //讀column標題
                {
                    column_name += dr.GetName(i) + "  ";
                }

                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        if (i == 1)
                        {
                            //AlienLevel = int.Parse(dr[i].ToString());
                        }
                        else if (i == 2)
                        {
                            //AlienHP = int.Parse(dr[i].ToString());
                        }
                        else if (i == 3)
                        {
                            //SpaceLevel = int.Parse(dr[i].ToString());
                        }
                        else if (i == 4)
                        {
                            spacefile_name = dr[i].ToString();
                        }
                    }
                }
                db2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            spacefile_name = @"..\..\Resources\" + spacefile_name;
            HPlabel.Text = "" + AlienHP;
            Spacepic.SizeMode = PictureBoxSizeMode.StretchImage;
            Alienpic.SizeMode = PictureBoxSizeMode.StretchImage;
            Spacepic.Image = Image.FromFile(spacefile_name);
            Alienpic.Image = Image.FromFile(@"..\..\Resources\alien.png");

        }

        int click_count = 0;
        private void Heropanel_MouseDown(object sender, MouseEventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @"..\..\Resources\shoot1.wav";
            sp.Play();

            AlienHP -= 10 * SpaceHATK;                            //怪物扣血
            HPlabel.Text = "" + AlienHP;
            if (AlienHP <= 0)                                   //如果血扣完了
            {
                if (AlienLevel < 10)                            //怪物等級上限
                {
                    alien_levelup();
                }
                else
                {
                    AlienHP = 0;
                    HPlabel.Text = "" + AlienHP;
                }
            }
            click_count++;
            if (click_count >= 20)                              //每點20下紀錄遊戲數據
            {
                click_count = 0;
                save_game_records();
            }
        }

        private void alien_levelup()
        {
            AlienLevel++;                                       //怪物升級

            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|account.mdf;" +
                "Integrated Security=True";                     //設為True 指定使用Windows 帳號認證連接資料庫
            SqlConnection db = new SqlConnection(cn);           //建立連接物件    
            SqlCommand cmd = new SqlCommand
                ("SELECT hp FROM 怪血量 WHERE level = " + AlienLevel, db);

            try
            {
                db.Open();                                      //使用Open方法開啟和資料庫的連接
                SqlDataReader dr = cmd.ExecuteReader();

                string column_name = "";                        //用不到的column標題
                for (int i = 0; i < dr.FieldCount; i++)         //讀column標題
                {
                    column_name += dr.GetName(i) + "  ";
                }

                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        AlienHP = int.Parse(dr[i].ToString());
                    }
                }
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            HPlabel.Text = "" + AlienHP;                        //更新怪物血量
        }

        /* Statistical */
        private void load_chart()
        {
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|account.mdf;" +
                "Integrated Security=True";                     //設為True 指定使用Windows 帳號認證連接資料庫
            SqlConnection db = new SqlConnection(cn);           //建立連接物件    
            SqlCommand cmd = new SqlCommand
                ("SELECT class, SUM(money) FROM 記帳 GROUP BY class", db);

            try
            {
                db.Open();                                      //使用Open方法開啟和資料庫的連接
                SqlDataReader dr = cmd.ExecuteReader();

                string column_name = "";                        //用不到的column標題
                for (int i = 0; i < dr.FieldCount; i++)         //讀column標題
                {
                    column_name += dr.GetName(i) + "  ";
                }

                string class_name = "";
                int money_value = 0;
                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        if (i % 2 == 0)
                            class_name = dr[i].ToString();
                        else
                            money_value = int.Parse(dr[i].ToString());
                    }
                    chart1.Series["Series1"].Points.AddXY(class_name, money_value);
                }

                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        

        private void Addlabel_Click(object sender, EventArgs e)
        {

        }

        

        

        private void save_coin()
        {
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|account.mdf;" +
                "Integrated Security=True";                     //設為True 指定使用Windows 帳號認證連接資料庫
            SqlConnection db = new SqlConnection(cn);           //建立連接物件    
            SqlCommand cmd = new SqlCommand
                ("UPDATE 遊戲紀錄 SET Coin = " + Coin + "WHERE virtualkey = 1", db);

            try
            {
                db.Open();                                      //使用Open方法開啟和資料庫的連接
                cmd.ExecuteNonQuery();
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        
    }
}
