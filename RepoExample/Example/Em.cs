using RepoServices.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using RepoModel.Model;
using System.Xml.Linq;

namespace RepoExample.Example
{
   
    public class Em : Im
    {
        DBclass objdb=new DBclass();

        public int del_category(string spname, Rm category, string id)
        {
            SortedList lst = new SortedList();
            lst.Add("@updatedby", category.updatedby);
            lst.Add("@updatedon", category.updatedon);

            return objdb.del_category(spname, lst, id);
        }

        public int del_subcat(string spname, Rms subcat, string id)
        {
            SortedList lst=new SortedList();
            lst.Add("@updatedby", subcat.updatedby);
            lst.Add("@updatedon", subcat.updatedon);

            return objdb.del_subcat(spname, lst, id);
        }

        public DataSet fill_product(string spname, string admin)
        {
            return objdb.fill_product(spname,admin);
        }

        public DataSet fill_subcat(string spname, string admin)
        {
            return objdb.fill_subcat(spname, admin);
        }

        //public DataSet fill_category(string spname)
        // {
        //     return objdb.fill_category(spname);
        // }

        public int in_category(string spname, Rm category)
        {
            SortedList lst=new SortedList();
            lst.Add("@name", category.name);
            lst.Add("@path", category.path);
            lst.Add("@createdby", category.createdby);
            lst.Add("@createdon", category.createdon);
            lst.Add("@updatedby", category.updatedby);
            lst.Add("@updatedon", category.updatedon);

            return objdb.in_category(spname, lst);
        }

        public int in_subcat(string spname, Rms subcat)
        {
            SortedList lst = new SortedList();
            lst.Add("@catid",subcat.catid);
            lst.Add("@name", subcat.name);
            lst.Add("@path", subcat.path);
            lst.Add("@createdby", subcat.createdby);
            lst.Add("@createdon", subcat.createdon);
            lst.Add("@updatedby", subcat.updatedby);
            lst.Add("@updatedon", subcat.updatedon);
            return objdb.in_subcat(spname, lst);
        }

        public int in_product(string spname, Rmp product)
        {
            SortedList lst = new SortedList();
            lst.Add("@subid", product.subid);
            lst.Add("@name", product.name);
            lst.Add("@path", product.path);
            lst.Add("@description",product.description);
            lst.Add("@price", product.price);
            lst.Add("@createdby", product.createdby);
            lst.Add("@createdon", product.createdon);
            lst.Add("@updatedby", product.updatedby);
            lst.Add("@updatedon", product.updatedon);
            return objdb.in_product(spname, lst);
        }

        public DataSet sel_admin(string spname, string email, string password)
        {
            SortedList lst = new SortedList();
            lst.Add("@email", email);
            lst.Add("@password", password);
            return objdb.sel_admin(spname,lst);
        }

        public DataSet sel_category(string spname, string id, string admin)
        {
            return objdb.sel_category(spname, id,admin);
        }

        public DataSet sel_category_name(string spname, string name, string admin)
        {
            return objdb.sel_category_name(spname,name,admin);
        }

        public DataSet sel_product_name(string spname, string name, string admin, string id)
        {
            return objdb.sel_product_name(spname,name, admin,id);
        }

        public DataSet sel_subcat(string spname, string id, string admin)
        {
            return objdb.sel_subcat(spname,id,admin);
        }

        public DataSet sel_subcat_name(string spname, string name, string admin,string id)
        {
            return objdb.sel_subcat_name(spname,name,admin,id);
        }

        public int update_category(string spname, Rm category, string id)
        {
            SortedList lst = new SortedList();
            lst.Add("@name", category.name);
            lst.Add("@path", category.path);
            lst.Add("@updatedby", category.updatedby);
            lst.Add("@updatedon", category.updatedon);

            return objdb.update_category(spname, lst,id);
        }

        public int update_subcat(string spname, Rms subcat, string id)
        {
            SortedList lst = new SortedList();
            lst.Add("@catid", subcat.catid);
            lst.Add("@name", subcat.name);
            lst.Add("@path", subcat.path);
            lst.Add("@updatedby", subcat.updatedby);
            lst.Add("@updatedon", subcat.updatedon);

            return objdb.update_subcat(spname, lst, id);
        }

        public int del_product(string spname, Rmp product, string id)
        {
            SortedList lst = new SortedList();
            lst.Add("@updatedby", product.updatedby);
            lst.Add("@updatedon", product.updatedon);

            return objdb.del_product(spname, lst, id);
        }

        public DataSet sel_subcat_d(string spname, string id, string admin)
        {
            return objdb.sel_subcat_d(spname, id, admin);
        }

        public DataSet sel_edt_product(string spname, string id)
        {
            return objdb.sel_edt_product(spname, id);
        }

        public int update_product(string spname, Rmp product, string id)
        {
            SortedList lst = new SortedList();
            lst.Add("@subid", product.subid);
            lst.Add("@name", product.name);
            lst.Add("@path", product.path);
            lst.Add("@description", product.description);
            lst.Add("@price", product.price);
            lst.Add("@updatedby", product.updatedby);
            lst.Add("@updatedon", product.updatedon);

            return objdb.update_product(spname, lst,id);
        }
    }
}
