using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace KTGiuaKy
{
    public static class InitDatabase
    {
        public static void ConnectDb()
        {
            string path = $"database.db";
            string database_source = $"Data Source = {path}";
            
            using (var connection = new SQLiteConnection(database_source))
            {
                if (connection == null)
                {
                    MessageBox.Show("Ket Noi that bai");
                }
                string query = "create table bank_account (\r\naccount_id int primary key,\r\nowner_name varchar,\r\nowner_adress varchar,\r\nowner_phone varchar,\r\nbalance double,\r\naccount_type varchar,\r\npassword varchar,\r\n)\r\n\r\ncreate table transactions (\r\ntrans_id uuid primary key,\r\naccount id bigint,\r\nhappend_time text,\r\naction_desc varchar,\r\nnote varchar,\r\nforeign key (account_id) reference bank_account (account_id)\r\n)\r\n\r\n\r\n\r\n \r\n";
                var command = new SQLiteCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }
    }
}
