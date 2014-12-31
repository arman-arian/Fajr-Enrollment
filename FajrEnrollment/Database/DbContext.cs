using System.Data;
using System.Data.SqlClient;

namespace FajrEnrollment.Database
{
    public static class DbContext
    {
        private const string ConnectionString =
            @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Fajr.mdf;Integrated Security=True;Connect Timeout=30";

        public static int Command(string query)
        {
            var sqlConnection = new SqlConnection(ConnectionString);
            var cmd = new SqlCommand
            {
                CommandText = query,
                CommandType = CommandType.Text,
                Connection = sqlConnection
            };

            sqlConnection.Open();
            var rowsAffected = cmd.ExecuteNonQuery();
            sqlConnection.Close();

            return rowsAffected; // تعداد رکوردهای ثبت شده در بانک اطلاعاتی
        }

        public static DataTable Query(string query)
        {
            var sqlConnection = new SqlConnection(ConnectionString);
            var cmd = new SqlCommand
            {
                CommandText = query,
                CommandType = CommandType.Text,
                Connection = sqlConnection
            };

            var dt = new DataTable();

            sqlConnection.Open();
            dt.Load(cmd.ExecuteReader());
            sqlConnection.Close();

            return dt;
        }
    }
}
