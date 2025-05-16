using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTGiuaKy
{
    public class User
    {
        public int account_id {  get; set; }
        public string password { get; set; }
        public string ownder_name { get; set; }
        public string owner_address { get; set; }
        public string owner_phone { get; set; }
        public double balance { get; set; }
        public string account_type { get; set; }

        public User(int account_id, string password, string ownder_name, string owner_address, string owner_phone, double balance, string account_type)
        {
            this.account_id = account_id;
            this.password = password;
            this.ownder_name = ownder_name;
            this.owner_address = owner_address;
            this.owner_phone = owner_phone;
            this.balance = balance;
            this.account_type = account_type;
        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   account_id == user.account_id;
        }

        public override int GetHashCode()
        {
            return 1713396956 + account_id.GetHashCode();
        }
    }
}
