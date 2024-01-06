using System;
using System.Data.SqlClient;
using System.Configuration;

namespace OkulApp.DAL
{
    public class Helper
    {
        SqlConnection _connection=null;
        SqlCommand _command=null;
            string cstr = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;//appconfig içerisindeki connectionString için gerekli kodları çektim.
        public int ExecuteNonQuery(string cmdtext, SqlParameter[] parameters=null)
        {
            using (_connection = new SqlConnection(cstr))
            {
                using (_command=new SqlCommand(cmdtext,_connection))
                {
                    if (parameters != null)
                    {
                        _command.Parameters.AddRange(parameters);

                    }
                    _connection.Open();
                    return _command.ExecuteNonQuery();
                }
            }
        }
    }
}
