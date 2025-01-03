using RepoExample;
using RepoExample.Example;
using RepoModel.Model;
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
    public partial class editcategory : System.Web.UI.Page
    {
        Im objex = new Em();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["id"];

                //To Get country
                DataSet ds=new DataSet();
                ds = objex.sel_category("Sel_category", id, Session["fname"].ToString());
                //string q = "select * from category where id=" + id;
                TextBox1.Text = ds.Tables[0].Rows[0][1].ToString();
                Image1.ImageUrl = ds.Tables[0].Rows[0][2].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = objex.sel_category_name("sel_category_name", TextBox1.Text, Session["fname"].ToString());

            if (ds.Tables[0].Rows.Count > 0)
            {
                Label1.Text = "category exists";
            }
            else
            {
                Label1.Text = "";

                if (FileUpload1.HasFile)
                {
                    string rpath = Server.MapPath("/Admin/images") + "/";
                    FileUpload1.SaveAs(rpath + FileUpload1.FileName);
                    string ipath = "~/Admin/images/" + FileUpload1.FileName;

                    string id = Request.QueryString["id"];

                    //To Update Country
                    //q = "update category set name='" + TextBox1.Text + "',path='" + ipath + "',updby='" + Session["fname"] + "',updon='" + DateTime.Now + "' where id=" + id;
                    Rm category = new Rm();
                    category.name = TextBox1.Text;
                    category.path = ipath;
                    category.updatedby = Session["fname"].ToString();
                    category.updatedon = DateTime.Now.ToString();


                    int i = objex.update_category("update_category", category, id);
                    if (i > 0)
                    {
                        Response.Redirect("Category.aspx");
                    }
                }
                else
                {
                    Label2.Text = "Please select";
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Category.aspx");
        }
    }
}