using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkCE_Store_Management_System.GETTERS_AND_SETTERS.Products
{
    internal class ProductsGetterAndSetter
    {
        public int id { get; set; }
        public int on_line_id { get; set; }
        public string product_name { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public string branch_id { get; set; }
        public string unique_id { get; set; }
        public decimal selling_price { get; set; }
        public decimal cost_price { get; set; }
        public decimal profit { get; set; }
        public decimal total_selling_price { get; set; }
        public decimal total_cost_price { get; set; }
        public decimal total_profit { get; set; }
        public string barcode { get; set; }
        public int quantity { get; set; }
        public string added_by { get; set; }
        public string shell { get; set; }
        public string vendor { get; set; }
        public int is_online { get; set; }
        public DateTime date { get; set; }
        public DateTime updated_at { get; set; }
        public int updated_online { get; set; }
    }
}
