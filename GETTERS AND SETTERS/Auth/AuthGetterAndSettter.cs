using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkCE_Store_Management_System.GETTERS_AND_SETTERS.Auth
{
    internal class AuthGetterAndSettter
    {
        public int id { get; set; }
        public string username { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string contact { get; set; }
        public int is_staff { get; set; }
        public string branch_id { get; set; }
        public string app_id { get; set; }
        public string password { get; set; }
        public int is_added_to_online_db { get; set; }
        public DateTime joined { get; set; }
        public int updated_online { get; set; }
    }
}
