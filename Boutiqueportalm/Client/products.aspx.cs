using RepoExample.Example;
using RepoServices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Boutiqueportalm.Client
{
    public partial class products : System.Web.UI.Page
    {
        Im objex = new Em();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataList1.DataSource = objex.fill_product("fill_product","mitali@gmail.com");
            DataList1.DataBind();
        }
    }
}