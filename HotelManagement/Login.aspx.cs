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
    public partial class Login : System.Web.UI.Page
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
                    string qry = "select * from signup where username='" + uname.Text + "' and password='" + pwd.Text + "'";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        Response.Write("<script> alert('login success'</script>");
                        Response.Redirect("Home.aspx");
                    }
                    else
                    {
                        Response.Redirect("register.aspx");
                    }
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                Response.Write("Error " + ex.Message);
            }
        }
    }
}