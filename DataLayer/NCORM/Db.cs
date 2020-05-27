using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Reflection;

namespace NewCity.DataAccess
{
    public enum DBType { MsSql, MySql };

    internal class DB
    {
        private string _ConnectionString;
        private int _CommandTimeout;
        private DBType _dbType;
        private SqlConnection _msConnection;
        private MySqlConnection _myConnection;

        public DB(DBType dbtype, string connstr, int cmdtimeout = 30)
        {
            _ConnectionString = connstr;
            _CommandTimeout = cmdtimeout;
            _dbType = dbtype; 
            
        }

        /// <summary>
        /// Connection Object
        /// </summary>
        public IDbConnection Connection
        {
            
            get
            {
                if (_dbType == DBType.MsSql)
                {
                    if (_msConnection == null) _msConnection = new SqlConnection(_ConnectionString);
                    if (_msConnection.State == ConnectionState.Closed) _msConnection.Open();
                    return _msConnection;
                }
                else
                {
                    if (_myConnection == null) _myConnection = new MySqlConnection(_ConnectionString);
                    if (_myConnection.State == ConnectionState.Closed) _myConnection.Open();
                    return _myConnection;
                }

            }
        }



        /// <summary>
        /// Create a New Connection
        /// </summary>
        /// <returns>Connection Object</returns>
        public IDbConnection CreateConnection()
        {
            IDbConnection _conn = null;
            try
            {
                if (_dbType == DBType.MsSql)
                {
                    _conn = new SqlConnection(_ConnectionString);
                    _conn.Open();
                }
                else
                {
                    _conn = new MySqlConnection(_ConnectionString);
                    _conn.Open();
                }
            }
            catch(Exception ex)
            {
                throw ex;
                //NCLog.ExceptionLog(ex, _ConnectionString);
            }
            return _conn;
        }

        
        public IDbCommand CreateCommand() { return CreateCommand(string.Empty); }
        public IDbCommand CreateCommand(string commandText) {
            if (_dbType == DBType.MsSql)
            {
                return new SqlCommand(commandText, (SqlConnection)CreateConnection());
            }
            else
            {
                return new MySqlCommand(commandText, (MySqlConnection)CreateConnection());
            }
        }
        public IDbCommand CreateCommand(string commandText, params object[] sqlParams)
        {
            if (_dbType == DBType.MsSql)
            {
                SqlCommand c = (SqlCommand)CreateCommand(commandText);
                c.CommandTimeout = _CommandTimeout;
                foreach (var sp in sqlParams) c.Parameters.Add(sp);
                return c;
            }
            else
            {
                MySqlCommand c = (MySqlCommand)CreateCommand(commandText);
                c.CommandTimeout = _CommandTimeout;
                foreach (var sp in sqlParams) c.Parameters.Add(sp);
                return c;
            }
        }
        /*
        public object CreateCommand(string commandText, params SqlParameter[] sqlParams)
        {
            if (_dbType == DBType.MsSql)
            {
                SqlCommand c = (SqlCommand)CreateCommand(commandText);
                c.CommandTimeout = _CommandTimeout;
                foreach (var sp in sqlParams) c.Parameters.Add(sp);
                return c;
            }
            else
            {
                MySqlCommand c = (MySqlCommand)CreateCommand(commandText);
                c.CommandTimeout = _CommandTimeout;
                foreach (var sp in sqlParams) c.Parameters.Add(sp);
                return c;
            }
        }
        public MySqlCommand CreateCommand(string commandText, params MySqlParameter[] sqlParams)
        {
            MySqlCommand c = (MySqlCommand)CreateCommand(commandText);
            c.CommandTimeout = _CommandTimeout;
            foreach (var sp in sqlParams) c.Parameters.Add(sp);
            return c;
        }
        */

        /// <summary>
        /// Create SqlParameter
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="value"></param>
        /// <returns>Object of SqlParameter</returns>
        public IDbDataParameter CreateSqlParameter(string parameterName, object value)
        {
            IDbDataParameter o = null;
            if (_dbType == DBType.MsSql)
            {
                o = new SqlParameter(parameterName, value);
            }
            else
            {
                o = new MySqlParameter(parameterName, value);
            }
            return o;
        }

        /// <summary>
        /// Execute SQL
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <param name="sqlParams"></param>
        /// <returns>Dataset Object</returns>
        public DataSet GetDataSet(string sqlStr, params object[] sqlParams)
        {
            DataSet ds = null;
            try
            {
                if (_dbType == DBType.MsSql)
                {
                    SqlCommand c = (SqlCommand)CreateCommand(sqlStr.Replace('?','@'), sqlParams);
                    SqlDataAdapter sda = new SqlDataAdapter(c);
                    ds = new DataSet();
                    sda.Fill(ds);
                    c.Connection.Close();
                    c.Connection.Dispose();
                    c.Dispose();
                    sda.Dispose();
                }
                else
                {
                    MySqlCommand c = (MySqlCommand)CreateCommand(sqlStr.Replace('@','?'), sqlParams);
                    MySqlDataAdapter sda = new MySqlDataAdapter(c);
                    ds = new DataSet();
                    sda.Fill(ds);
                    c.Connection.Close();
                    c.Connection.Dispose();
                    c.Dispose();
                    sda.Dispose();
                }
            }
            catch (Exception e)
            {
                //NCLog.ExceptionLog(e, sqlStr);
                throw new Exception(sqlStr + Environment.NewLine + e.Message);
            }
            return ds;
        }
        //public DataSet GetDataSet(string sqlStr, params object[] args) { return GetDataSet(string.Format(sqlStr, args)); }
        public DataSet GetDataSet(string sqlStr)
        {
            DataSet ds = null;
            try
            {
                if (_dbType == DBType.MsSql)
                {
                    SqlCommand c = (SqlCommand)CreateCommand(sqlStr);
                    SqlDataAdapter sda = new SqlDataAdapter(c);
                    ds = new DataSet();
                    sda.Fill(ds);
                    c.Connection.Close();
                    c.Connection.Dispose();
                    c.Dispose();
                    sda.Dispose();
                }
                else
                {
                    MySqlCommand c = (MySqlCommand)CreateCommand(sqlStr);
                    MySqlDataAdapter sda = new MySqlDataAdapter(c);
                    ds = new DataSet();
                    sda.Fill(ds);
                    c.Connection.Close();
                    c.Connection.Dispose();
                    c.Dispose();
                    sda.Dispose();
                }
            }
            catch (Exception ex)
            {
                //NCLog.ExceptionLog(ex, sqlStr);
                throw new Exception(sqlStr + Environment.NewLine + ex.Message);
            }
            return ds;
        }


        /// <summary>
        /// Execute SQL
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <param name="sqlParams"></param>
        /// <returns>Table Object</returns>
        public DataTable GetDataTable(string sqlStr, params object[] sqlParams)
        {
            DataTable dt = null;
            try
            {
                if (_dbType == DBType.MsSql)
                {

                    SqlCommand c = (SqlCommand)CreateCommand(sqlStr.Replace('?','@'), sqlParams);
                    SqlDataAdapter sda = new SqlDataAdapter(c);
                    dt = new DataTable();
                    sda.Fill(dt);
                    c.Connection.Close();
                    c.Connection.Dispose();
                    c.Dispose();
                    sda.Dispose();
                }
                else
                {

                    MySqlCommand c = (MySqlCommand)CreateCommand(sqlStr.Replace('@','?'), sqlParams);
                    MySqlDataAdapter sda = new MySqlDataAdapter(c);
                    dt = new DataTable();
                    sda.Fill(dt);
                    c.Connection.Close();
                    c.Connection.Dispose();
                    c.Dispose();
                    sda.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
                //NCLog.ExceptionLog(ex, sqlStr);
            }
            return dt;
        }
        //public DataTable GetDataTable(string sqlStr, params object[] args) { return GetDataTable(string.Format(sqlStr, args)); }
        public DataTable GetDataTable(string sqlStr)
        {
            DataTable dt = null;
            try
            {
                if (_dbType == DBType.MsSql)
                {
                    SqlCommand c = (SqlCommand)CreateCommand(sqlStr);
                    SqlDataAdapter sda = new SqlDataAdapter(c);
                    dt = new DataTable();
                    sda.Fill(dt);
                    c.Connection.Close();
                    c.Connection.Dispose();
                    c.Dispose();
                    sda.Dispose();
                }
                else
                {
                    MySqlCommand c = (MySqlCommand)CreateCommand(sqlStr);
                    MySqlDataAdapter sda = new MySqlDataAdapter(c);
                    dt = new DataTable();
                    sda.Fill(dt);
                    c.Connection.Close();
                    c.Connection.Dispose();
                    c.Dispose();
                    sda.Dispose();
                }
            }
            catch (Exception ex)
            {
                //NCLog.ExceptionLog(ex, sqlStr);
                throw new Exception(sqlStr + Environment.NewLine + ex.Message);
            }
            return dt;
        }


        /// <summary>
        /// Execute SQL
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <param name="sqlParams"></param>
        /// <returns>Datarow Object</returns>
        public DataRow GetDataRow(string sqlStr, params object[] sqlParams)
        {
            DataRow r = null;
            try
            {
                DataTable dt = GetDataTable(sqlStr, sqlParams);
                if (dt != null && dt.Rows.Count > 0) r = dt.Rows[0];
            }
            catch (Exception e)
            {
                throw e;
                //NCLog.ExceptionLog(e, sqlStr);
            }
            return r;
        }

        //public DataRow GetDataRow(string sqlStr, params object[] args) { return GetDataRow(string.Format(sqlStr, args)); }
        public DataRow GetDataRow(string sqlStr)
        {
            DataRow r = null;
            try
            {
                DataTable dt = GetDataTable(sqlStr);
                if (dt.Rows.Count > 0) r = dt.Rows[0];
            }
            catch (Exception ex)
            {
                //NCLog.ExceptionLog(ex, sqlStr);
                throw new Exception(sqlStr + Environment.NewLine + ex.Message);
            }
            return r;
        }


        /// <summary>
        /// Execute SQL
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <param name="sqlParams"></param>
        /// <returns>Number of Affected Row</returns>
        public int ExecuteSql(string sqlStr, params object[] sqlParams)
        {
            int i = 0;
            try
            {
                if (_dbType == DBType.MsSql)
                {
                    SqlCommand c = (SqlCommand)CreateCommand(sqlStr.Replace('?','@'), sqlParams);
                    i = c.ExecuteNonQuery();
                    c.Connection.Close();
                    c.Connection.Dispose();
                    c.Dispose();
                }
                else
                {
                    MySqlCommand c = (MySqlCommand)CreateCommand(sqlStr.Replace('@','?'), sqlParams);
                    i = c.ExecuteNonQuery();
                    c.Connection.Close();
                    c.Connection.Dispose();
                    c.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
                //NCLog.ExceptionLog(ex, sqlStr);
            }
            return i;
        }
        //public int ExecuteSql(string sqlStr, params object[] args) { return ExecuteSql(string.Format(sqlStr, args)); }
        public int ExecuteSql(string sqlStr)
        {
            int i = 0;
            try
            {
                if (_dbType == DBType.MsSql)
                {
                    SqlCommand c = (SqlCommand)CreateCommand(sqlStr);
                    i = c.ExecuteNonQuery();
                    c.Connection.Close();
                    c.Connection.Dispose();
                    c.Dispose();
                }
                else
                {
                    MySqlCommand c = (MySqlCommand)CreateCommand(sqlStr);
                    i = c.ExecuteNonQuery();
                    c.Connection.Close();
                    c.Connection.Dispose();
                    c.Dispose();
                }
            }
            catch (Exception ex)
            {
                //NCLog.ExceptionLog(ex, sqlStr);
                throw new Exception(sqlStr + Environment.NewLine + ex.Message);
            }
            return i;
        }


        /// <summary>
        /// Execute SQL
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="sqlParams"></param>
        /// <returns>Object in SQL SELECT Statement</returns>
        public object ExecuteScalar(string sqlStr, params object[] sqlParams)
        {
            object o = null;
            try
            {
                if (_dbType == DBType.MsSql)
                {
                    SqlCommand c = (SqlCommand)CreateCommand(sqlStr.Replace('?','@'), sqlParams);
                    o = c.ExecuteScalar();
                    c.Connection.Close();
                    c.Connection.Dispose();
                    c.Dispose();
                }
                else
                {
                    MySqlCommand c = (MySqlCommand)CreateCommand(sqlStr.Replace('@','?'), sqlParams);
                    o = c.ExecuteScalar();
                    c.Connection.Close();
                    c.Connection.Dispose();
                    c.Dispose();

                }
            }
            catch (Exception ex)
            {
                throw ex;
                //NCLog.ExceptionLog(ex, sqlStr);
            }
            return o;
        }
        //public object ExecuteScalar(string sqlStr, params object[] args) { return ExecuteScalar(string.Format(sqlStr, args)); }
        public object ExecuteScalar(string sqlStr)
        {
            object o = null;
            try
            {
                if (_dbType == DBType.MsSql)
                {
                    SqlCommand c = (SqlCommand)CreateCommand(sqlStr);
                    o = c.ExecuteScalar();
                    c.Connection.Close();
                    c.Connection.Dispose();
                    c.Dispose();
                }
                else
                {
                    MySqlCommand c = (MySqlCommand)CreateCommand(sqlStr);
                    o = c.ExecuteScalar();
                    c.Connection.Close();
                    c.Connection.Dispose();
                    c.Dispose();
                }
            }
            catch (Exception ex)
            {
                //NCLog.ExceptionLog(ex, sqlStr);
                throw new Exception(sqlStr + Environment.NewLine + ex.Message);
            }
            return o;
        }

        /// <summary>
        /// Quote Value in SQL-Statement
        /// </summary>
        /// <param name="aStr"></param>
        /// <param name="dbtype"></param>
        /// <returns>String of Quoted Value</returns>
        public static string QuotedValue(string aStr, DBType dbtype = DBType.MySql)
        {
            string result = "";
            if (dbtype == DBType.MsSql)
            {
                result = Regex.Escape(aStr);
            }
            else
            {
                result = MySqlHelper.DoubleQuoteString(MySqlHelper.EscapeString(aStr));
            }
            result = "'" + result + "'";
            return result;
        }

        public string QuotedValue(string aStr)
        {
            string result = "";
            if (_dbType == DBType.MsSql)
            {
                result = Regex.Escape(aStr);
            }
            else
            {
                result = MySqlHelper.DoubleQuoteString(MySqlHelper.EscapeString(aStr));
            }
            result = "'" + result + "'";
            return result;
        }

        public  string QuotedValueByType(string aStr,PropertyInfo PI)
        {
            string result = "";
            if (_dbType == DBType.MsSql)
            {
                result = Regex.Escape(aStr);
            }
            else
            {
                result = MySqlHelper.DoubleQuoteString(MySqlHelper.EscapeString(aStr));
            }
            if (PI.PropertyType == typeof(Guid?) && aStr== "00000000-0000-0000-0000-000000000000")
            {
                result = "null";
            }
            else if (PI.PropertyType == typeof(string) || PI.PropertyType == typeof(Guid) || PI.PropertyType == typeof(Guid?))
            {
                result = "'" + result + "'";
            }
            else if (PI.PropertyType == typeof(DateTime) || PI.PropertyType == typeof(DateTime?))
            {
                return $"'{Convert.ToDateTime(aStr):yyyy-MM-dd HH:mm:ss}'";
            }
                
            return result;
        }
        /// <summary>
        /// Quote Field Name in SQL-Statement
        /// </summary>
        /// <param name="aField"></param>
        /// <param name="dbtype"></param>
        /// <returns>String of Quoted Field Name</returns>
        public static string QuotedFieldName(string aField,DBType dbtype = DBType.MySql)
        {
            return string.Format("{1}{0}{2}", aField, (dbtype == DBType.MySql ? "`" : "["), (dbtype == DBType.MySql ? "`" : "]"));
        }

        public string QuotedFieldName(string aField)
        {
            return string.Format("{1}{0}{2}", aField, (_dbType == DBType.MySql ? "`" : "["), (_dbType == DBType.MySql ? "`" : "]"));
        }
    }
}
