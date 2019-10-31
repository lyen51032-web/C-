using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace adonet
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str_user_name = "查無使用者!!";

            /*
             1.連結設定
             2.開啟
             3.關閉
             */
            using (SqlConnection conn = new SqlConnection())
            {


                conn.ConnectionString = "Data Source=.;Initial Catalog=weberp;User ID=sa;Password=1qaz@wsx";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    //connection開啟
                    cmd.Connection = conn;//物件要有關連
                    cmd.CommandText = "SELECT mname FROM sys_user WHERE mno = @mno";//變數+@=參數
                    cmd.Parameters.Clear();//先把參數清乾淨
                    cmd.Parameters.AddWithValue("@mno", TextBox1.Text);//去欄位撈資料
                    SqlDataReader dr =cmd.ExecuteReader();//不用實作化
                    if (dr.HasRows) {//有資料化就是true 無資料就是false

                        //讀到把值回傳
                        dr.Read();//有資料指標往下移
                        str_user_name = dr["mname"].ToString();
                    }
                    dr.Close();//跟connection一樣要關閉

                }
                conn.Close();

            }
            Label2.Text = str_user_name;

        }
    }
}