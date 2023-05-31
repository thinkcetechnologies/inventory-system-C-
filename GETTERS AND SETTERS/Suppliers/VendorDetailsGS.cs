using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkCE_Store_Management_System.GETTERS_AND_SETTERS.Suppliers
{
    internal class VendorDetailsGS
    {
        public int id { get; set; }
        public string vendor_name { get; set; }
        public decimal amount { get; set; }
        public string status { get; set; }
        public string unique_id { get; set; }
        public string branch_id { get; set; }
        public string added_by { get; set; }
        public int is_online { get; set; }
        public int updated_online { get; set; }
        public DateTime added_at { get; set; }
        public DateTime updated_at { get; set; }
        public int id_from_online { get; set; }
        public decimal part_payment_amount { get; set; }
    }
}
