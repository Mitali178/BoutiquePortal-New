using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoModel.Model
{
    public class Rmp
    {
        public int id { get; set; }
        public int subid { get; set; }
        public string name { get; set; }
        public string path { get; set; }
        public string description { get; set; }
        public string price { get; set; }
        public string createdby { get; set; }
        public string createdon { get; set; }
        public string updatedby { get; set; }
        public string updatedon { get; set; }
        public string isdlt { get; set; }
    }
}
