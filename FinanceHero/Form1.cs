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
            // set panel visable
            Homepanel.Visible = false;
            Shoppanel.Visible = false;
            Heropanel.Visible = true;
            Statispanel.Visible = false;

        }
        private void Homebutton_Click(object sender, EventArgs e)
        {
            Homepanel.Visible = true;
            Shoppanel.Visible = false;
            Heropanel.Visible = false;
            Statispanel.Visible = false;

            //read data
            this.Text = "記帳英雄";

            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                "Integrated Security=True";         //設為True 指定使用Windows 帳號認證連接資料庫

            SqlConnection db = new SqlConnection(cn);           //建立連接物件
            db.Open();                                          //使用Open方法開啟和資料庫的連接
            SqlCommand cmd = new SqlCommand
                ("SELECT TOP 3 * FROM 記帳", db);
            SqlDataReader dr = cmd.ExecuteReader();

            string data = "";                                   //宣告字串存放資料內容
            for (int i = 0; i < dr.FieldCount; i++)
            {
                data += dr.GetName(i) + "  ";
            }
            buttontitle.Text = data;


            int j = 1;
            data = "";
            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    data += dr[i].ToString() + "  ";            //把資料讀出來
                }

                if (j == 1)
                    buttond1.Text = data;
                else if (j == 2)
                    buttond2.Text = data;
                else if (j == 3)
                    buttond3.Text = data;

                j++;
                data = "";
            }

            db.Close();                                         //使用Close方法關閉和資料庫的連接


        }

        private void Shopbutton_Click(object sender, EventArgs e)
        {
            Homepanel.Visible = false;
            Shoppanel.Visible = false;
            Heropanel.Visible = true;
            Statispanel.Visible = false;
        }

        private void Herobutton_Click(object sender, EventArgs e)
        {
            Homepanel.Visible = false;
            Shoppanel.Visible = false;
            Heropanel.Visible = true;
            Statispanel.Visible = false;
        }

        private void Statisbutton_Click(object sender, EventArgs e)
        {
            Homepanel.Visible = false;
            Shoppanel.Visible = false;
            Heropanel.Visible = false;
            Statispanel.Visible = true;
        }

    }
}
