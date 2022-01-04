using CaffeeData.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffeeData
{
    public class OrderItemRepository
    {
        private ConstantParameters constant = new ConstantParameters();

        public List<OrderItem> GetAllOrderItems()
        {
            using(SqlConnection sqlConnection = new SqlConnection(constant.connectionString))
            {
                SqlCommand command = new SqlCommand();

                command.Connection = sqlConnection;

                command.CommandText = "SELECT * FROM OrderItems";

                List<OrderItem> orderItems = new List<OrderItem>();

                sqlConnection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                while(dataReader.Read())
                {
                    OrderItem orderItem = new OrderItem();

                    orderItem.Id = dataReader.GetInt32(0);

                    orderItem.ItemQuantity = dataReader.GetInt32(1);

                    orderItem.ItemId = dataReader.GetInt32(2);

                    orderItem.BillId = dataReader.GetInt32(3);

                    orderItems.Add(orderItem);
                }

                return orderItems;

            }
        }

        public int InsertOrderItem(OrderItem orderItem)
        {
            using (SqlConnection sqlConnection = new SqlConnection(constant.connectionString))
            {
                SqlCommand command = new SqlCommand();

                command.Connection = sqlConnection;

                command.CommandText = string.Format("INSERT INTO Order_Items VALUES({0},{1},{2})",
                    orderItem.ItemQuantity,orderItem.ItemId,orderItem.BillId);

                sqlConnection.Open();

                return command.ExecuteNonQuery();
            }
        }
        public List<OrderItem> GetAllOrderItemsByTableId(int billId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(constant.connectionString))
            {
                SqlCommand command = new SqlCommand();

                command.Connection = sqlConnection;

                command.CommandText = string.Format("SELECT * FROM OrderItems WHERE order_id={0}", billId);

                List<OrderItem> orderItems = new List<OrderItem>();

                sqlConnection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    OrderItem orderItem = new OrderItem();

                    orderItem.Id = dataReader.GetInt32(0);

                    orderItem.ItemQuantity = dataReader.GetInt32(1);

                    orderItem.ItemId = dataReader.GetInt32(2);

                    orderItem.BillId = dataReader.GetInt32(3);

                    orderItems.Add(orderItem);
                }

                return orderItems;

            }
        }

    }
}
