using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoModel.Model
{
    public class Rm
    {
        public int id { get; set; }
        public string name { get; set; }
        public string path { get; set; }
        public string createdby { get; set; }
        public string createdon { get; set; }
        public string updatedby { get; set;}
        public string updatedon { get; set; }
        public string isdlt { get; set; }
    }
}
