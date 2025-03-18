using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_web_app
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            
            if (username == "admin" && password == "password")
            {
                
                Response.Redirect("Welcome.aspx");
            }
            else
            {
                Response.Redirect("Invalid.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}