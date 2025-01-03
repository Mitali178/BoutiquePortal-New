using RepoExample.Example;
using RepoServices.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Boutiqueportalm.Client
{
    public partial class subcats : System.Web.UI.Page
    {
        Im objex = new Em();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = objex.fill_subcat("fill_subcat", "mitali@gmail.com");
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }
    }
}