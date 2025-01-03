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
    public partial class editproduct : System.Web.UI.Page
    {
        Im objex = new Em();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //To Bind Country
                //string q = "select * from category where isdlt='" + 0 + "'";
                //Mclass.bindDropdown(q, ref DropDownList1, "name", "id");

                DataSet ds = new DataSet();
                ds = objex.sel_category("sel_category", "-1", Session["fname"].ToString());

                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "name";
                DropDownList1.DataValueField = "id";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, "--select--");

                //To get data for editing
                string id = Request.QueryString["id"];
                //string q1 = "select c.id,s.id,p.name,p.path,p.description,p.price from category as c inner join subcat as s on c.id=s.catid inner join product as p on s.id=p.subid where p.id=" + id;

                //DataSet ds = Mclass.getdata(q1);
                DataSet ds2 = objex.sel_edt_product("sel_edt_product", id);
                DropDownList1.SelectedValue = ds2.Tables[0].Rows[0][0].ToString();

                //To Bind State
                string id1 = DropDownList1.SelectedValue.ToString();
                //string q2 = "select * from subcat where isdlt='" + 0 + "' and catid=" + id1;
                //Mclass.bindDropdown(q2, ref DropDownList2, "name", "id");
                DataSet ds3 = objex.sel_subcat_d("sel_subcat_d", id1, Session["fname"].ToString());

                DropDownList2.DataSource = ds3;
                DropDownList2.DataTextField = "name";
                DropDownList2.DataValueField = "id";
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, "--select--");

                DropDownList2.SelectedValue = ds2.Tables[0].Rows[0][1].ToString();

                TextBox1.Text = ds2.Tables[0].Rows[0][2].ToString();
                TextBox2.Text = ds2.Tables[0].Rows[0][5].ToString();
                TextBox3.Text = ds2.Tables[0].Rows[0][4].ToString();
                Image1.ImageUrl = ds2.Tables[0].Rows[0][3].ToString();

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

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string q1 = "select * from product where name=('" + TextBox1.Text + "') and isdlt='" + 0 + "'";
            //DataSet ds = Mclass.getdata(q1);

            string id = DropDownList2.SelectedValue;

            DataSet ds = new DataSet();
            ds = objex.sel_product_name("sel_product_name", TextBox1.Text, Session["fname"].ToString(), id);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Label1.Text = "Product exists";
            }
            else
            {
                Label1.Text = "";
                //string q = "";
                if (FileUpload1.HasFile)
                {
                    string rpath = Server.MapPath("/Admin/images") + "/";
                    FileUpload1.SaveAs(rpath + FileUpload1.FileName);
                    string ipath = "~/Admin/images/" + FileUpload1.FileName;

                    string id1 = Request.QueryString["id"];

                    //q = "update product set subid=" + DropDownList2.SelectedValue + ",name='" + TextBox1.Text + "',price='" + TextBox2.Text + "',description='" + TextBox3.Text + "',path='" + ipath + "',updby='" + Session["fname"] + "',updon='" + DateTime.Now + "' where id=" + id;

                    Rmp product = new Rmp();
                    product.subid = Convert.ToInt32(DropDownList2.SelectedValue);
                    product.name = TextBox1.Text;
                    product.path = ipath;
                    product.description = TextBox3.Text;
                    product.price = TextBox2.Text;
                    product.updatedby = Session["fname"].ToString();
                    product.updatedon = DateTime.Now.ToString();

                    int i = objex.update_product("update_product", product,id1);
                   // int i = Mclass.execute(q);
                    if (i > 0)
                    {
                        Response.Redirect("Product.aspx");
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
    }
}