using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinanceHero
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }
       
        private void Confirmbutton_Click(object sender, EventArgs e)
        {
            get_account_key();                                  //取得該前最後一筆記帳的key
            account_key++;

            Edit("INSERT INTO 記帳(date,class,description,money,virtualkey) VALUES('" +
               dateTimePicker1.Text + "'," +
               "N" + "'" + ClasscomboBox.Text.Replace("'", "''") + "'," +
               "N" + "'" + DescripttextBox.Text.Replace("'", "''") + "'," +
               MoneytextBox.Text + "," +
               account_key + ")");

            AddForm_Load(sender, e);
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            //建立SqlConnection物件db
            SqlConnection db = new SqlConnection();
            //設定db連接ch15DB資料庫檔案
            db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|account.mdf;" +
                "Integrated Security=True";
            //建立DataAdapter物件da
            //da帶入查詢的SQL語法為toolStripTextBox1文字方塊的內容
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM 記帳", db);
            //建立DataSet物件ds
            DataSet ds = new DataSet();
            //將da物件所取得的資料填入ds物件
            da.Fill(ds);
            //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
            dataGridView1.DataSource = ds.Tables[0];
        }

        void Edit(string sqlstr)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|account.mdf;" +
                    "Integrated Security=True";
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = sqlstr;
                cmd.ExecuteNonQuery();
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        int account_key;
        private void get_account_key()
        {
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|account.mdf;" +
                "Integrated Security=True";                     //設為True 指定使用Windows 帳號認證連接資料庫
            SqlConnection db = new SqlConnection(cn);           //建立連接物件    
            SqlCommand cmd = new SqlCommand
                ("SELECT TOP 1 virtualkey FROM 記帳 ORDER BY virtualkey DESC", db);

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
                        account_key = int.Parse(dr[i].ToString());
                    }
                }
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int load_once = 0;
        private void Addpanel_Paint(object sender, PaintEventArgs e)
        {
            //MessageBox.Show("paint");
            if (load_once == 0)
            {
                create();
                load_once++;
            }
        }

        private void create()
        {
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|account.mdf;" +
                "Integrated Security=True";                     //設為True 指定使用Windows 帳號認證連接資料庫
            SqlConnection db = new SqlConnection(cn);           //建立連接物件    
            SqlCommand cmd = new SqlCommand
                ("SELECT * FROM 記帳", db);

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
                int index = 0;
                string dateStr, classStr, desStr, MoneyStr;
                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        if (i == 1)
                        {
                            dateStr = dr[i].ToString();

                        }
                        else if (i == 2)
                        {
                            classStr = dr[i].ToString();
                            L1[index] = set_Label_property(20, 444 + index * 40, 222);
                            this.Addpanel.Controls.Add(L1[index]);
                            L1[index].Text = classStr;

                        }
                        else if (i == 3)
                        {
                            desStr = dr[i].ToString();
                            L1[index].Text += "  " + desStr;
                        }
                        else if (i == 4)
                        {
                            MoneyStr = dr[i].ToString();
                            L2[index] = set_Label_property(242, 444 + index * 40, 80);
                            L2[index].Text += "$" + MoneyStr;
                            this.Addpanel.Controls.Add(L2[index]);

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
            Q.Height = 29;
            Q.BackColor = Color.LightGreen;
            Q.Left = x;
            Q.Top = y;
            Q.TextAlign = ContentAlignment.MiddleLeft;
            Q.Font = new Font("微軟正黑體", 12, FontStyle.Regular);

            return Q;
        }
    }
}
