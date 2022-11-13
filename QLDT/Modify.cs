using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLDT
{
    class Modify
    {
        public Modify()
        {

        }
        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand;
        public DataTable Table(string query)//dùng để trả về bảng dữ liệu.
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query , sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
                return dataTable;
        }
        public void Command(string query)//dùng để thêm , sửa , xóa.
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}
