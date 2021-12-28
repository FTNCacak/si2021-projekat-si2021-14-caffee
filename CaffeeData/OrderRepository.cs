using CaffeeData.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffeeData
{
    public class OrderRepository
    {
        private ConstantParameters constant = new ConstantParameters();

        public List<Order> GetAllOrders()
        {
            using (SqlConnection sqlConnection = new SqlConnection(constant.connectionString))
            {
                SqlCommand command = new SqlCommand();

                command.Connection = sqlConnection;

                command.CommandText = "SELECT * FROM Orders";

                List<Order> orders = new List<Order>();

                sqlConnection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                while(dataReader.Read())
                {
                    Order o = new Order();

                    o.Id = dataReader.GetInt32(0);

                    o.BillNumber = dataReader.GetInt32(1);

                    orders.Add(o);

                }

                return orders;
            }
        }

        public int InsertOrder(Order o)
        {
            using(SqlConnection sqlConnection = new SqlConnection(constant.connectionString))
            {
                SqlCommand command = new SqlCommand();

                command.Connection = sqlConnection;

                command.CommandText = string.Format("INSERT INTO Orders VALUES({0}, {1}", o.Id, o.BillNumber);

                sqlConnection.Open();

                return command.ExecuteNonQuery();
            }
        }
    }
}
