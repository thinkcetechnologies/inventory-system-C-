using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkCE_Store_Management_System.GETTERS_AND_SETTERS.Sales
{
    internal class SalesGetterAndSetter
    {

        public int id { get; set; }
        public string product_name { get; set; }
        public int product_id { get; set; }
        public int quantity { get; set; }
        public decimal total_price { get; set; }
        public string transaction_id { get; set; }
        public string unit_price { get; set; }
        public string branch_id { get; set; }
        public string unique_id { get; set; }
        public int is_online { get; set; }
        public string sales_by { get; set; }
        public int returned { get; set; }
        public string date_to_show { get; set; }
        public DateTime date { get; set; }

    }
}
