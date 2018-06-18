using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient; //引用System.Data.SqlClient命名空間
//for test
namespace FinanceHero
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            load_database();

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

            load_database();
        }

        private void Shopbutton_Click(object sender, EventArgs e)
        {
            Homepanel.Visible = false;
            Shoppanel.Visible = true;
            Heropanel.Visible = false;
            Statispanel.Visible = false;
        }

        private void Herobutton_Click(object sender, EventArgs e)
        {
            Homepanel.Visible = false;
            Shoppanel.Visible = false;
            Heropanel.Visible = true;
            Statispanel.Visible = false;
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

        private void Addbutton_Click(object sender, EventArgs e)
        {
            AddForm addf = new AddForm();
            addf.Show();
        }

        private void load_database()
        {
            //read data
            this.Text = "記帳英雄";

            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                "Integrated Security=True";                     //設為True 指定使用Windows 帳號認證連接資料庫

            SqlConnection db = new SqlConnection(cn);           //建立連接物件
            db.Open();                                          //使用Open方法開啟和資料庫的連接
            SqlCommand cmd = new SqlCommand
                ("SELECT TOP 3 * FROM 記帳", db);
            SqlDataReader dr = cmd.ExecuteReader();

            string data = "";                                   //宣告字串存放資料內容
            string key = "", date = "";
            for (int i = 0; i < dr.FieldCount; i++)             //讀column標題
            {
                data += dr.GetName(i) + "  ";
            }
            buttontitle.Text = "用途 / 名稱 / 金額";


            int j = 1;
            data = "";
            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    if (i == 0)                                 //讀key
                        key = dr[i].ToString();
                    else if (i == 1)                            //讀日期
                        date = dr[i].ToString();
                    else if (i <= 3)                            //把資料讀出來
                        data += dr[i].ToString() + " / ";
                    else
                        data += dr[i].ToString();
                }

                if (j == 1)
                {
                    datelabel1.Text = date;
                    databuttond1.Text = data;
                }
                else if (j == 2)
                {
                    datelabel2.Text = date;
                    databuttond2.Text = data;
                }
                else if (j == 3)
                {
                    datelabel3.Text = date;
                    databuttond3.Text = data;
                }

                j++;
                data = "";
            }

            db.Close();                                         //使用Close方法關閉和資料庫的連接
        }

        private void load_chart()
        {
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|Database1.mdf;" +
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
    }
}
