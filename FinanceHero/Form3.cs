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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int index = Home.select_index;
        int virtualkey = 0;
        private void Confirmbutton_Click(object sender, EventArgs e)
        {
            virtualkey = Home.virtualkey[index];

            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|account.mdf;" +
                "Integrated Security=True";                     //設為True 指定使用Windows 帳號認證連接資料庫
            SqlConnection db = new SqlConnection(cn);           //建立連接物件    
            SqlCommand cmd = new SqlCommand
                ("UPDATE 記帳 SET date = " + "N" + "'" + dateTimePicker1.Text + "'," +
                 "class = " + "N" + "'" + ClasscomboBox.Text.Replace("'", "''") + "'," +
                 "description = " + "N" + "'" + DescripttextBox.Text.Replace("'", "''") + "'," +
                 "money = " + MoneytextBox.Text +
                 "WHERE virtualkey = " + virtualkey, db);
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
            label1.Text = "OK!";
        }
    }
}
