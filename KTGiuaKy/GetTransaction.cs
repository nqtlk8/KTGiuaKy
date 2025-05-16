using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;

namespace KTGiuaKy
{
    public static class GetTransaction
    {
        public static List<Transaction> GetTransactionByID(string account_id)
        {
            List<Transaction> transactions = new List<Transaction>();
            string path = $"database.db";
            string database_source = $"Data Source = {path}";

            using (var connection = new SQLiteConnection(database_source))
            {
                if (connection == null)
                {
                    MessageBox.Show("Ket Noi that bai");
                    return null;
                }
                string query = "Select * from transactions where account_id = @account_id";
                var command = new SQLiteCommand(query, connection);

                command.Parameters.AddWithValue(@account_id, account_id);

                using (var reader = command.ExecuteReader())
                {
                    do
                    {
                        Transaction transaction = new Transaction(Convert.ToInt32(reader["account_id"]), reader["happend_time"].ToString(), reader["action_desc"].ToString(), reader["note"].ToString(), Convert.ToInt32(reader["trans_id"]));
                        transactions.Add(transaction);
                    }
                    while (reader.Read());
                    return transactions;
                }
            }
            return null;
        }

    }
}
