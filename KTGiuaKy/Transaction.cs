using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTGiuaKy
{
    public class Transaction
    {
        public int account_id {get;set;}
        public string happend_time {get;set;}
        public string action_desc {get;set;}
        public string note { get;set;}
        public int trans_id { get;set;}

        public Transaction(int account_id, string happend_time, string action_desc, string note, int trans_id)
        {
            this.account_id = account_id;
            this.happend_time = happend_time;
            this.action_desc = action_desc;
            this.note = note;
            this.trans_id = trans_id;
        }

        public override bool Equals(object obj)
        {
            return obj is Transaction transaction &&
                   account_id == transaction.account_id &&
                   trans_id == transaction.trans_id;
        }

        public override int GetHashCode()
        {
            int hashCode = -72463133;
            hashCode = hashCode * -1521134295 + account_id.GetHashCode();
            hashCode = hashCode * -1521134295 + trans_id.GetHashCode();
            return hashCode;
        }
    }
}
