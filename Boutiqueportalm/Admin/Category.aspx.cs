using RepoExample;
using RepoExample.Example;
using RepoModel.Model;
using RepoServices.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Boutiqueportalm.Admin
{
    public partial class Country : System.Web.UI.Page
    {
        Im objex = new Em();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillgrid();
            }
        }

        public void fillgrid()
        {
            DataSet ds= new DataSet();
            ds = objex.sel_category("sel_category","-1", Session["fname"].ToString());
            GridView1.DataSource = ds;
            GridView1.DataBind();

            //string q = "Select * from category where isdlt='" + 0 + "' ";

            //Mclass.gridbind(q, ref GridView1);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = objex.sel_category_name("sel_category_name", TextBox1.Text, Session["fname"].ToString());

            //string q1 = "select * from category where name=('" + TextBox1.Text + "') and isdlt='" + 0 + "'";
            //DataSet ds = Mclass.getdata(q1);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Label1.Text = "category exists";
            }
            else
            {
                
                if (FileUpload1.HasFile)
                {
                    Label1.Text = "";

                    string rpath = Server.MapPath("/Admin/images") + "/";
                    FileUpload1.SaveAs(rpath + FileUpload1.FileName);
                    string ipath = "~/Admin/images/" + FileUpload1.FileName;

                    Rm category = new Rm();
                    category.name = TextBox1.Text;
                    category.path = ipath;
                    category.createdby = Session["fname"].ToString();
                    category.createdon = DateTime.Now.ToString();
                    category.updatedby= Session["fname"].ToString();
                    category.updatedon= DateTime.Now.ToString();    

                    int i = objex.in_category("in_category",category);
                    if (i > 0)
                    {
                        fillgrid();
                    }
                }
                else
                {
                    Label2.Text = "Please select ";
                }

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Category.aspx");
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "del")
            {
                string id = e.CommandArgument.ToString();

                Rm category = new Rm();
                category.updatedby = Session["fname"].ToString();
                category.updatedon = DateTime.Now.ToString();

                int i = objex.del_category("del_category", category, id);

                if (i > 0)
                {
                  fillgrid();
                }

            }
        }
    }
}