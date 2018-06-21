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
            Edit("INSERT INTO 記帳(date,class,description,money,virtualkey) VALUES('" +
               TimetextBox.Text+ "'," +
               "N" + "'" + ClasscomboBox.Text.Replace("'", "''") + "'," +
               "N" + "'" + DescripttextBox.Text.Replace("'", "''") + "'," +
               MoneytextBox.Text + "," +
               KeytextBox.Text + ")");

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
    }
}
