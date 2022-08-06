using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace HotelManagement
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UFR5MDR;Initial Catalog=HotelManagementDB;Integrated Security=True;"))
                {
                    con.Open();
                    string qry = "insert into signup values(@username,@email,@mobilenumber,@password)";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("username", uname.Text);
                    cmd.Parameters.AddWithValue("password", pwd.Text);
                    cmd.Parameters.AddWithValue("email", txtemail.Text);
                    cmd.Parameters.AddWithValue("mobilenumber", mobnum.Text);
                    cmd.ExecuteNonQuery();

                    uname.Text = "";
                    pwd.Text = "";
                    txtemail.Text = "";
                    mobnum.Text = "";
                    uname.Focus();
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
                    Response.Redirect("login.aspx");
                }

            }
            catch (Exception ex)
            {
                Response.Write("Error " + ex.Message);
            }
        }
    }
}