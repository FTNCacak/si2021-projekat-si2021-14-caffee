using CaffeeData.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffeeData
{
    public class ItemRepository
    {
        //creating ConstantParameters class, to get a connection string from it
        private ConstantParameters constant = new ConstantParameters();

        //returns all Items from database
        public List<Item> GetAllItems()
        {   
            using (SqlConnection sqlConnection = new SqlConnection(constant.connectionString))
            {
                SqlCommand sql = new SqlCommand();

                sql.Connection = sqlConnection;

                sql.CommandText = ("SELECT * FROM Items");

                List<Item> items = new List<Item>();

                sqlConnection.Open();

                SqlDataReader dataReader = sql.ExecuteReader();

                while(dataReader.Read())
                {
                    Item i = new Item();

                    i.ItemCode = dataReader.GetInt32(0);

                    i.Name = dataReader.GetString(1);

                    i.Price = dataReader.GetDecimal(2);

                    items.Add(i);
                }

                return items;
            }
        }
        //This function returns rows affected as returned value(in int)
        public int InsertItem(Item i)
        {
            using (SqlConnection sqlConnection = new SqlConnection(constant.connectionString))
            {
                SqlCommand sql = new SqlCommand();

                sql.Connection = sqlConnection;

                sql.CommandText = string.Format("INSERT INTO Items VALUES('{0}',{1})", i.Name, i.Price);

                sqlConnection.Open();

                return sql.ExecuteNonQuery();
            }
        }

        public int UpdatePriceAndName(int id, decimal newPrice , string itemName)
        {
            using (SqlConnection sqlConnection = new SqlConnection(constant.connectionString))
            {
                

                SqlCommand command = new SqlCommand();

                command.Connection = sqlConnection;

                sqlConnection.Open();

                command.CommandText = string.Format("UPDATE Items SET name='{0}',price={1} WHERE item_code={2}",itemName,newPrice , id);

                return command.ExecuteNonQuery();
            }
        }

        public int DeleteItem(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(constant.connectionString))
            {
                SqlCommand command = new SqlCommand();

                command.Connection = sqlConnection;

                command.CommandText = string.Format("DELETE FROM Items WHERE item_code={0}",id);

                sqlConnection.Open();

                return command.ExecuteNonQuery();
            }
        }
        public int DeleteItemByName(string name)
        {
            using (SqlConnection sqlConnection = new SqlConnection(constant.connectionString))
            {
                SqlCommand command = new SqlCommand();

                command.Connection = sqlConnection;

                command.CommandText = string.Format("DELETE FROM Items WHERE name = {0}", name);

                sqlConnection.Open();

                return command.ExecuteNonQuery();
            }
        }

    }
}
