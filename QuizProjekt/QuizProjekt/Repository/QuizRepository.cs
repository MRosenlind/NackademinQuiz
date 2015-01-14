using QuizProjekt.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QuizProjekt.Repository
{
    public class QuizRepository
    {
        public List<Test> GetAllQuizes(string name = "")
        {
            var query = "SELECT * FROM Tests WHERE Name LIKE @Name";

            var parameters = new List<SqlParameter>() { new SqlParameter("@Name", "%" + name + "%") };

            var result = new List<Test>();
            using (var reader = SqlUtility.RunQuery(query, parameters))
            {
                while (reader.Read())
                {
                    result.Add(new Test
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.SafeGetString(1),
                        Description = reader.SafeGetString(2),
                        
                    });
                }
            }
            return result;
        }

    }
}