using RepoExample.Example;
using RepoServices.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Boutiqueportalm.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        Im objex = new Em();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds=objex.sel_admin("sel_admin",TextBox1.Text,TextBox2.Text);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                Session["fname"] = ds.Tables[0].Rows[0][1].ToString();
                Response.Redirect("Default.aspx");
                Label1.Text = "valid";
            }
            else
            {
                Label1.Text = "invalid";
            }
            }
    }
}