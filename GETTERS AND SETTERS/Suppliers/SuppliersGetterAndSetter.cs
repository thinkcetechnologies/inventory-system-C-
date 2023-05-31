using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkCE_Store_Management_System.GETTERS_AND_SETTERS.Suppliers
{
    internal class SuppliersGetterAndSetter
    {
        public int id { get; set; }
        public string supplier_name { get; set; }
        public string supplier_location { get; set; }
        public string supplier_contact { get; set; }
        public string supplier_address { get; set; }
        public string branch_id { get; set; }
        public string unique_id { get; set; }
        public string id_from_online { get; set; }
        public int is_online { get; set; }
        public string updated_online { get; set; }
        public DateTime date { get; set; }
    }
}
