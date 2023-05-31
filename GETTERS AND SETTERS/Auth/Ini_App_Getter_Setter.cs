using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkCE_Store_Management_System.GETTERS_AND_SETTERS
{
    internal class Ini_App_Getter_Setter
    {
        public int id { get; set; }
        public string company_name { get; set; }
        public string company_location { get; set; }
        public int num_of_branches { get; set; }
        public string unique_id { get; set; }
        public DateTime created { get; set; }
        public string company_address { get; set; }
        public string branch_id { get; set; }
        public string branch_name { get; set; }
        public string branch_location { get; set; }
        public string branch_address { get; set; }
        public string contact { get; internal set; }
    }
}
