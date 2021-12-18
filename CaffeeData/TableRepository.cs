using CaffeeData.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffeeData
{
    public class TableRepository
    {
        private ConstantParameters constant = new ConstantParameters();

        public List<Table> GetAllTables()
        {
            using(SqlConnection sqlConnection = new SqlConnection(constant.connectionString))
            {
                SqlCommand command = new SqlCommand();

                command.Connection = sqlConnection;

                command.CommandText = "SELECT * FROM Tables";

                List<Table> tables = new List<Table>();

                sqlConnection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                while(dataReader.Read())
                {
                    Table t = new Table();

                    t.Id = dataReader.GetInt32(0);

                    t.Occupied = dataReader.GetBoolean(1);

                    t.position_w = dataReader.GetInt32(2);

                    t.position_h = dataReader.GetInt32(3);

                    tables.Add(t);
                }

                return tables;

            }
        }

        public int InsertTable(Table t)
        {
            using (SqlConnection sqlConnection = new SqlConnection(constant.connectionString))
            {
                SqlCommand command = new SqlCommand();

                command.Connection = sqlConnection;

                command.CommandText = string.Format("INSERT INTO Tables VALUES({0}, {1}, {2})",
                    t.Occupied,t.position_w,t.position_h);

                sqlConnection.Open();

                return command.ExecuteNonQuery();
            }
        }


    }
}
