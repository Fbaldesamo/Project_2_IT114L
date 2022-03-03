using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

namespace Project_2_IT114L
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Visible = false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            OleDbConnection my_con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Others\\Documents\\Database1.accdb");
            my_con.Open();
            OleDbCommand o_cmd = new OleDbCommand("insert into Table1 values(@Sem_Code,@Sem_Title,@SemDB)", my_con);
            o_cmd.Parameters.AddWithValue("@Sem_Code", TextBox1.Text.Trim());
            o_cmd.Parameters.AddWithValue("@Sem_Title", TextBox2.Text.Trim());
            o_cmd.Parameters.AddWithValue("@SemDB", TextBox3.Text.Trim());
            //o_cmd.Parameters.AddWithValue("d", TextBox4.Text);
            int i = o_cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Label1.Text = "Data inserted successfully";
            }
            my_con.Close();




            //First_try
            //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Others\\Documents\\Database1.accdb");

            //con.Open();


            //OleDbCommand cmd = new OleDbCommand();
            //"insert into Table1 values('"+TextBox1.Text+ "','" + TextBox2.Text + "'," + TextBox3.Text + ")",con;
            //int r = cmd.ExecuteNonQuery();

            //con.Close();
            //if (r > 0)
            //{
            //    Label1.Visible = true;


            //}


        }
    }
}