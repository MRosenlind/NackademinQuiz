using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QuizProjekt.Repository
{

    /// <summary>
    /// Jag behövs inte
    /// </summary>
    public static class SqlUtility
    {
        public static SqlDataReader RunQuery(string query, IEnumerable<SqlParameter> parameters)
        {
            var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString);
            connection.Open();

            var command = new SqlCommand(query, connection);
            foreach (var param in parameters)
            {
                command.Parameters.Add(param);
            }

            return command.ExecuteReader();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static int RunUpdate(string query, IEnumerable<SqlParameter> parameters)
        {
            var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString);
            connection.Open();

            var command = new SqlCommand(query, connection);
            foreach (var param in parameters)
            {
                command.Parameters.Add(param);
            }

            return command.ExecuteNonQuery();
        }
        public static string SafeGetString(this SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetString(colIndex);
            else
                return string.Empty;
        }
    }
}