using CaffeeData.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffeeData
{
    public class ReceiptRepository
    {
        private ConstantParameters constant = new ConstantParameters();

        public List<Receipt> GetAllReceipts()
        {
            using (SqlConnection sqlConnection = new SqlConnection(constant.connectionString))
            {
                SqlCommand command = new SqlCommand();

                command.Connection = sqlConnection;

                command.CommandText = "SELECT * FROM Receipts";

                List<Receipt> receipts = new List<Receipt>();

                sqlConnection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Receipt r = new Receipt();

                    r.Id = dataReader.GetInt32(0);

                    r.Date = dataReader.GetDateTime(1);

                    r.Price = dataReader.GetDecimal(2);

                    receipts.Add(r);
                }

                return receipts;
            }
        }

        public int InsertReceipt(Receipt r)
        {
            using (SqlConnection sqlConnection = new SqlConnection(constant.connectionString))
            {
                SqlCommand command = new SqlCommand();

                command.Connection = sqlConnection;

                command.CommandText = string.Format("INSERT INTO Receipts VALUES('{0}', {1})", r.Date, r.Price);

                sqlConnection.Open();

                return command.ExecuteNonQuery();
            }
        }

    }
}
