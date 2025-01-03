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
    public partial class Product : System.Web.UI.Page
    {
        Im objex = new Em();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillgrid();

                //Binding Country
                /*string q = "select * from category where isdlt='" + 0 + "'";
                Mclass.bindDropdown(q, ref DropDownList1, "name", "id");

                DropDownList2.Items.Insert(0, "--Select--");*/

                DataSet ds = new DataSet();
                ds = objex.sel_category("sel_category", "-1", Session["fname"].ToString());

                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "name";
                DropDownList1.DataValueField = "id";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, "--select--");
            }
        }

        public void fillgrid()
        {
            //string q = "select p.id,c.name,s.name,p.name,p.description,p.price,p.path from category as c inner join subcat as s on c.id=s.catid inner join product as p on s.id=p.subid where p.isdlt='" + 0 + "' ";

            //Mclass.gridbind(q, ref GridView1);
            GridView1.DataSource = objex.fill_product("fill_product", Session["fname"].ToString());
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // string q1 = "select * from product where name=('" + TextBox1.Text + "') and isdlt='" + 0 + "'";
            //DataSet ds = Mclass.getdata(q1);

            string id = DropDownList2.SelectedValue;
            
            DataSet ds = new DataSet();
            ds = objex.sel_product_name("sel_product_name", TextBox1.Text, Session["fname"].ToString(),id);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Label1.Text = "product exists";
            }
            else
            {
                if (FileUpload1.HasFile)
                {
                    string rpath = Server.MapPath("/Admin/images") + "/";
                    FileUpload1.SaveAs(rpath + FileUpload1.FileName);
                    string ipath = "~/Admin/images/" + FileUpload1.FileName;

                    
                    Label1.Text = "";
                    //string q = "insert into product(subid,name,path,description,price,crtby,crton,updby,updon,isdlt)values(" + DropDownList2.SelectedValue + ",'" + TextBox1.Text + "','" + ipath + "','" + TextBox3.Text + "','" + TextBox2.Text + "','" + Session["fname"] + "','" + DateTime.Now + "','" + Session["fname"] + "','" + DateTime.Now + "','" + 0 + "')";
                    //int i = Mclass.execute(q);

                    Rmp product = new Rmp();
                    product.subid = Convert.ToInt32(DropDownList2.SelectedValue);
                    product.name = TextBox1.Text;
                    product.path = ipath;
                    product.description= TextBox3.Text;
                    product.price= TextBox2.Text;
                    product.createdby = Session["fname"].ToString();
                    product.createdon = DateTime.Now.ToString();
                    product.updatedby = Session["fname"].ToString();
                    product.updatedon = DateTime.Now.ToString();
                    int i = objex.in_product("in_product", product);
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
            Response.Redirect("Product.aspx");
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "del")
            {
                string id = e.CommandArgument.ToString();
                //string q = "update product set isdlt='" + 1 + "',updby='" + Session["fname"] + "',updon='" + DateTime.Now + "' where id=" + id;

                //int i = Mclass.execute(q);
                Rmp product = new Rmp();
                product.updatedby = Session["fname"].ToString();
                product.updatedon = DateTime.Now.ToString();

                int i = objex.del_product("del_product", product,id);
                if (i > 0)
                {
                    fillgrid();
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = DropDownList1.SelectedValue.ToString();

            //string q = "select * from subcat where isdlt='" + 0 + "' and catid=" + id;
            //Mclass.bindDropdown(q, ref DropDownList2, "name", "id");

            DataSet ds = new DataSet();
            ds = objex.sel_subcat_d("sel_subcat_d", id, Session["fname"].ToString());

            DropDownList2.DataSource = ds;
            DropDownList2.DataTextField = "name";
            DropDownList2.DataValueField = "id";
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, "--select--");
        }
    }
}