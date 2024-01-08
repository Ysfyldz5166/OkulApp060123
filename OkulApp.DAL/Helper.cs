using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace OkulApp.DAL
{
    public class Helper : IDisposable
    {
        SqlConnection _connection=null;
        SqlCommand _command=null;
        string cstr = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;//appconfig içerisindeki connectionString için gerekli kodları çektim.



        public int ExecuteNonQuery(string cmdtext, SqlParameter[] parameters=null)
        {
            try
            {
                using (_connection = new SqlConnection(cstr))
                {
                    using (_command = new SqlCommand(cmdtext, _connection))
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
            catch (SqlException ex)
            {
                throw new Exception("Veritabanı hatası", ex); ;
            }
            catch(Exception ex)
            {
                throw new Exception("Bilinmeyen hata", ex); ;
            }
        }

        public SqlDataReader ExecuteReader(string cmdtext, SqlParameter[] parameter = null)
        {
            try
            {
                _connection = new SqlConnection(cstr);
                _command = new SqlCommand(cmdtext, _connection);
                if (parameter != null)
                {
                    _command.Parameters.AddRange(parameter);

                }
                _connection.Open();
                return _command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (SqlException ex)
            {
                throw new Exception("Veritabanı hatası", ex);

            }
            catch (Exception ex)
            {
                throw new Exception("Bilinmeyen  hata", ex);
                
            }


        }    public void Dispose()
        {
            _command.Dispose();
            _connection.Dispose();
        }
    }

}
