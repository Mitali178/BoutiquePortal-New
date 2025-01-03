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
    public partial class Subcat : System.Web.UI.Page
    {
        Im objex = new Em();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillgrid();

                DataSet ds= new DataSet();
                ds = objex.sel_category("sel_category", "-1", Session["fname"].ToString());

                DropDownList1.DataSource =ds;
                DropDownList1.DataTextField = "name";
                DropDownList1.DataValueField = "id";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, "--select--");
            }
        }

        public void fillgrid()
        {
            DataSet ds = new DataSet();
            ds = objex.fill_subcat("fill_subcat", Session["fname"].ToString());
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string id = DropDownList1.SelectedValue;
            DataSet ds=new DataSet();
            ds = objex.sel_subcat_name("sel_subcat_name", TextBox1.Text, Session["fname"].ToString(),id);

            if (ds.Tables[0].Rows.Count > 0)
            {
                Label1.Text = "subcategory exists";
            }
            else
            {
                
                if (FileUpload1.HasFile)
                {
                    string rpath = Server.MapPath("/Admin/images") + "/";
                    FileUpload1.SaveAs(rpath + FileUpload1.FileName);
                    string ipath = "~/Admin/images/" + FileUpload1.FileName;

                    Label1.Text = "";
                    
                    Rms subcat= new Rms();
                    subcat.catid = Convert.ToInt32(DropDownList1.SelectedValue); ;
                    subcat.name = TextBox1.Text;
                    subcat.path = ipath;
                    subcat.createdby = Session["fname"].ToString();
                    subcat.createdon = DateTime.Now.ToString();
                    subcat.updatedby = Session["fname"].ToString();
                    subcat.updatedon = DateTime.Now.ToString();

                    //int i = Mclass.execute(q);
                    int i = objex.in_subcat("in_subcat", subcat);
                    if (i > 0)
                    {
                        fillgrid();
                    }
                }
                else
                {
                    Label2.Text = "please select";
                }

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Subcat.aspx");
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "del")
            {
                string id = e.CommandArgument.ToString();

                Rms subcat = new Rms();
                subcat.updatedby = Session["fname"].ToString();
                subcat.updatedon = DateTime.Now.ToString();

                int i = objex.del_subcat("del_subcat", subcat, id);
                if (i > 0)
                {
                    fillgrid();
                }
            }
        }
    }
}