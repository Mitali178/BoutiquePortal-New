using RepoModel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoServices.Services
{
    public interface Im
    {
        DataSet sel_admin(string spname, string email, string password);
        //DataSet fill_category(string spname);
        DataSet sel_category_name(string spname,string name,string admin);
        DataSet sel_category(string spname, string id,string admin);
        DataSet fill_subcat(string spname,string admin);    
        DataSet sel_subcat_name(string spname, string name, string admin, string id);
        DataSet sel_subcat(string spname,string id,string admin);
        DataSet fill_product(string spname,string admin);
        DataSet sel_product_name(string spname,string name,string admin, string id);
        DataSet sel_subcat_d(string spname,string id,string admin);
        DataSet sel_edt_product(string spname,string id);
        int in_category(string spname,Rm category);
        int del_category(string spname,Rm category,string id);
        int update_category(string spname,Rm category,string id);
        int in_subcat(string spname, Rms subcat);
        int del_subcat(string spname, Rms subcat, string id);
        int update_subcat(string spname,Rms subcat,string id);
        int in_product(string spname, Rmp product);
        int del_product(string spname, Rmp product, string id);
        int update_product(string spname, Rmp product, string id);
    }
}
