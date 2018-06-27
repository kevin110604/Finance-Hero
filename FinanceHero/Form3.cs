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

        int Addpanel_load_once = 0;
        private void Addpanel_Paint(object sender, PaintEventArgs e)
        {
            if (Addpanel_load_once == 0)
            {
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy/MM/dd HH:mm:ss";
                load_info();
                Addpanel_load_once++;
            }
        }

        private void load_info()
        {
            virtualkey = Home.virtualkey[index];

            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|account.mdf;" +
                "Integrated Security=True";                     //設為True 指定使用Windows 帳號認證連接資料庫
            SqlConnection db = new SqlConnection(cn);           //建立連接物件    
            SqlCommand cmd = new SqlCommand
                ("SELECT * FROM 記帳 WHERE virtualkey = " + virtualkey, db);
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
                            dateTimePicker1.Text = dr[i].ToString();
                        }
                        else if (i == 2)
                        {
                            ClasscomboBox.Text = dr[i].ToString();
                        }
                        else if (i == 3)
                        {
                            DescripttextBox.Text = dr[i].ToString();
                        }
                        else if (i == 4)
                        {
                            MoneytextBox.Text = dr[i].ToString();
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
    }
}
