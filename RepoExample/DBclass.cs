using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml.Linq;
using RepoModel.Model;

namespace RepoExample
{
    public class DBclass
    {
        private static SqlConnection con;

        //open connection
        private static void connection()
        {
            string str = @"Data Source=(localdb)\local;Initial Catalog=BoutiquePortalm;Persist Security Info=True;User ID=Mitali;Password=123";
            con = new SqlConnection(str);
            con.Open();
        }

        //close connection
        private static void close()
        {
            con.Close();
        }
        public DataSet sel_admin(string spname,SortedList lst)
        {
            connection();

            DataSet dataSet = new DataSet();
            int i;

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = spname;
            cmd.CommandType = CommandType.StoredProcedure;

            for (i = 0; i < lst.Count; i++)
            {
                cmd.Parameters.AddWithValue((string)lst.GetKey(i), lst.GetByIndex(i));
            }

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            da.Fill(dataSet);
            close();

            return dataSet;
        }

        public DataSet fill_category(string spname)
        {
            connection();

            DataSet dataSet = new DataSet();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = spname;
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            da.Fill(dataSet);
            close();

            return dataSet;
        }

        public int in_category(string spname,SortedList lst) 
        { 
            connection();
            DataSet dataSet = new DataSet();
            int i;

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = spname;
            cmd.CommandType = CommandType.StoredProcedure;

            for (i = 0; i < lst.Count; i++)
            {
                cmd.Parameters.AddWithValue((string)lst.GetKey(i), lst.GetByIndex(i));
            }

            i=cmd.ExecuteNonQuery();
            close();

            return i;
        }

        public DataSet sel_category(string spname, string id, string admin)
        {
            connection();
            DataSet dataSet = new DataSet();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandText = spname;

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@createdby", admin);

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            da.Fill(dataSet);
            close();

            return dataSet;
        }
        public DataSet sel_category_name(string spname,string name, string admin)
        {
            connection();
            DataSet dataSet = new DataSet();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandText = spname;

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@createdby", admin);

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            da.Fill(dataSet);
            close();

            return dataSet;
        }

        public int del_category(string spname,SortedList lst, string id)
        {
            connection();
            DataSet dataSet = new DataSet();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandText = spname;

            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < lst.Count; i++)
            {
                cmd.Parameters.AddWithValue((string)lst.GetKey(i), lst.GetByIndex(i));
            }

            cmd.Parameters.AddWithValue("@id", id);

            int j = cmd.ExecuteNonQuery();
            close();

            return j;
        }

        public int update_category(string spname,SortedList lst,string id)
        {
            connection();
            DataSet dataSet = new DataSet();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandText = spname;

            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < lst.Count; i++)
            {
                cmd.Parameters.AddWithValue((string)lst.GetKey(i), lst.GetByIndex(i));
            }

            cmd.Parameters.AddWithValue("@id", id);

            int j = cmd.ExecuteNonQuery();
            close();

            return j;
        }

        public DataSet fill_subcat(string spname, string admin)
        {
            connection();
            DataSet dataSet = new DataSet();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandText = spname;

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@createdby", admin);

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            da.Fill(dataSet);
            close();

            return dataSet;
        }

        public DataSet sel_subcat_name(string spname, string name, string admin,string id)
        {
            connection();
            DataSet dataSet = new DataSet();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandText = spname;

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@createdby", admin);
            cmd.Parameters.AddWithValue("@catid", id);

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            da.Fill(dataSet);
            close();

            return dataSet;
        }

        public int in_subcat(string spname,SortedList lst)
        {
            connection();
            DataSet dataSet = new DataSet();
            int i;

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = spname;
            cmd.CommandType = CommandType.StoredProcedure;

            for (i = 0; i < lst.Count; i++)
            {
                cmd.Parameters.AddWithValue((string)lst.GetKey(i), lst.GetByIndex(i));
            }

            i = cmd.ExecuteNonQuery();
            close();

            return i;
        }

        public int del_subcat(string spname,SortedList lst,string id)
        {
            connection();
            DataSet dataSet = new DataSet();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandText = spname;

            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < lst.Count; i++)
            {
                cmd.Parameters.AddWithValue((string)lst.GetKey(i), lst.GetByIndex(i));
            }

            cmd.Parameters.AddWithValue("@id", id);

            int j = cmd.ExecuteNonQuery();
            close();

            return j;
        }

        public DataSet sel_subcat(string spname, string id, string admin)
        {
            connection();
            DataSet dataSet = new DataSet();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandText = spname;

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@createdby", admin);

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            da.Fill(dataSet);
            close();

            return dataSet;
        }

        public int update_subcat(string spname,SortedList lst,string id)
        {
            connection();
            DataSet dataSet = new DataSet();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandText = spname;

            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < lst.Count; i++)
            {
                cmd.Parameters.AddWithValue((string)lst.GetKey(i), lst.GetByIndex(i));
            }

            cmd.Parameters.AddWithValue("@id", id);

            int j = cmd.ExecuteNonQuery();
            close();

            return j;
        }

        public DataSet fill_product(string spname,string admin)
        {
            connection();
            DataSet dataSet = new DataSet();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandText = spname;

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@createdby", admin);

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            da.Fill(dataSet);
            close();

            return dataSet;
        }

        public DataSet sel_product_name(string spname,string name, string admin, string id)
        {
            connection();
            DataSet dataSet = new DataSet();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandText = spname;

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@createdby", admin);
            cmd.Parameters.AddWithValue("@subid", id);

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            da.Fill(dataSet);
            close();

            return dataSet;
        }

        public int in_product(string spname,SortedList lst)
        {
            connection();
            DataSet dataSet = new DataSet();
            int i;

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = spname;
            cmd.CommandType = CommandType.StoredProcedure;

            for (i = 0; i < lst.Count; i++)
            {
                cmd.Parameters.AddWithValue((string)lst.GetKey(i), lst.GetByIndex(i));
            }

            i = cmd.ExecuteNonQuery();
            close();

            return i;
        }
        public int del_product(string spname,SortedList lst,string id)
        {
            connection();
            DataSet dataSet = new DataSet();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandText = spname;

            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < lst.Count; i++)
            {
                cmd.Parameters.AddWithValue((string)lst.GetKey(i), lst.GetByIndex(i));
            }

            cmd.Parameters.AddWithValue("@id", id);

            int j = cmd.ExecuteNonQuery();
            close();

            return j;
        }

        public DataSet sel_subcat_d(string spname ,string id, string admin)
        {
            connection();
            DataSet dataSet = new DataSet();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandText = spname;

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@createdby", admin);
            cmd.Parameters.AddWithValue("@catid", id);

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            da.Fill(dataSet);
            close();

            return dataSet;
        }


        public DataSet sel_edt_product(string spname ,string id)
        {
            connection();
            DataSet dataSet = new DataSet();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandText = spname;

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", id);

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            da.Fill(dataSet);
            close();

            return dataSet;
        }

        public int update_product(string spname ,SortedList lst, string id)
        {
            connection();
            DataSet dataSet = new DataSet();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            cmd.CommandText = spname;

            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < lst.Count; i++)
            {
                cmd.Parameters.AddWithValue((string)lst.GetKey(i), lst.GetByIndex(i));
            }

            cmd.Parameters.AddWithValue("@id", id);

            int j = cmd.ExecuteNonQuery();
            close();

            return j;
        }
    }
    


    
}
