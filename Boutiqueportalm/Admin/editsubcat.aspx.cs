using RepoExample;
using RepoExample.Example;
using RepoModel.Model;
using RepoServices.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Boutiqueportalm.Admin
{
    public partial class editsubcat : System.Web.UI.Page
    {
        Im objex = new Em();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["id"];

                DataSet ds = new DataSet();
                ds = objex.sel_category("sel_category", "-1", Session["fname"].ToString());

                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "name";
                DropDownList1.DataValueField = "id";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, "--select--");

                DataSet ds1=new DataSet();
                ds1 = objex.sel_subcat("sel_subcat", id, Session["fname"].ToString());

                DropDownList1.SelectedValue = ds1.Tables[0].Rows[0][1].ToString();
                TextBox1.Text = ds1.Tables[0].Rows[0][2].ToString();
                Image1.ImageUrl = ds1.Tables[0].Rows[0][3].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //DataSet ds=new DataSet();
            //ds = objex.sel_subcat_name("sel_subcat_name", TextBox1.Text, Session["fname"].ToString());

            string id = DropDownList1.SelectedValue;
            DataSet ds = new DataSet();
            ds = objex.sel_subcat_name("sel_subcat_name", TextBox1.Text, Session["fname"].ToString(), id);

            if (ds.Tables[0].Rows.Count > 0)
            {
                Label1.Text = "subcategory exists";
            }
            else
            {
                Label1.Text = "";

                if (FileUpload1.HasFile)
                {
                    string rpath = Server.MapPath("/Admin/images") + "/";
                    FileUpload1.SaveAs(rpath + FileUpload1.FileName);
                    string ipath = "~/Admin/images/" + FileUpload1.FileName;

                    string id1 = Request.QueryString["id"];


                    Rms subcat=new Rms();
                    subcat.catid = Convert.ToInt32(DropDownList1.SelectedValue); ;
                    subcat.name = TextBox1.Text;
                    subcat.path = ipath;
                    subcat.updatedby = Session["fname"].ToString();
                    subcat.updatedon = DateTime.Now.ToString();

                    int i = objex.update_subcat("update_subcat", subcat, id1);
                    if (i > 0)
                    {
                        Response.Redirect("Subcat.aspx");
                    }
                }
                else
                {
                    Label3.Text = "Please select";
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Subcat.aspx");
        }
    }
}