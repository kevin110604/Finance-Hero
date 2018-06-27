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

        int once = 0;
        private void Addpanel_Paint(object sender, PaintEventArgs e)
        {
            //MessageBox.Show("paint");
            if (once == 0)
            {
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                once++;
            }
        }

        private void Confirmbutton_Click(object sender, EventArgs e)
        {
            get_account_key();                                  //取得該前最後一筆記帳的key
            account_key++;

            Edit("INSERT INTO 記帳(date,class,description,money,virtualkey) VALUES(" +
               "N" + "'" + dateTimePicker1.Text + "'," +
               "N" + "'" + ClasscomboBox.Text.Replace("'", "''") + "'," +
               "N" + "'" + DescripttextBox.Text.Replace("'", "''") + "'," +
               MoneytextBox.Text + "," +
               account_key + ")");

            label1.Text = "OK!";
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

    }
}
