using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTGiuaKy
{
    public static class Auth
    {
        public static User getuser(string account_id)
        {
            string path = $"database.db";
            string database_source = $"Data Source = {path}";

            using (var connection = new SQLiteConnection(database_source))
            {
                if (connection == null)
                {
                    MessageBox.Show("Ket Noi that bai");
                    return null;
                }
                string query = "Select account_id,password from bank_account where account_id = @account_id";
                var command = new SQLiteCommand(query,connection);

                command.Parameters.AddWithValue(account_id, account_id);
                using (var reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        return new User(Convert.ToInt32(reader["account_id"]), reader["password"].ToString(), reader["owner_name"].ToString(), reader["ownder_address"].ToString(), reader["owner_phone"].ToString(), Convert.ToInt32(reader["balance"]), reader["account_type"].ToString());
                    }
                }
            }
            return null;
        }
    }
}
